﻿using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using FinalProject_Blog.Models;
using FinalProject_Blog.ViewModels;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITagRepository _tagRepository;
        private readonly ICommentRepository _commentRepository;

        public PostController(IPostRepository postRepository, ICategoryRepository categoryRepository, ITagRepository tagRepository, ICommentRepository commentRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository;
            _commentRepository = commentRepository;
        }

        public ViewResult Category(string categoryId)
        {
            IEnumerable<Post> posts;
            int _categoryId = Convert.ToInt32(categoryId);
            if (_categoryId == 0)
            {
                posts = _postRepository.Posts;
            }
            else
            {
                posts = _postRepository.PostsByCategory(_categoryId);
            }
            var postListViewModel = new PostListViewModel
            {
                Posts = posts,
                CurrentCategory = _categoryRepository.CurrentCategory(_categoryId)
            };
            return View(postListViewModel);
        }

        public IActionResult Tag(string tagId)
        {
            int _tagId = Convert.ToInt32(tagId);
            IEnumerable<Post> posts = _tagRepository.LoadPostToTag(_tagId);
            var postListViewModel = new PostListViewModel
            {
                Posts = posts,
                CurrentCategory = _tagRepository.CurrentTag(_tagId),
            };
            return View(postListViewModel);
        }

        public IActionResult Detail(string postId)
        {
            int _postId = Convert.ToInt32(postId);
            Post post = _postRepository.GetPostById(_postId);
            List<Comment> comments = _commentRepository.LoadComment(_postId).ToList();
            ViewBag.listComment = comments;
            var tuple = new Tuple<Post, Comment>(post, new Comment());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult CreateComment([Bind] Comment comment)
        {
            comment.PostedOn = DateTime.Now;
            _commentRepository.CreateComment(comment);
            return RedirectToAction("Detail", "Post", new { postId = comment.PostId });
        }

        public IActionResult Search(string searchKey)
        {
            List<Post> posts = new List<Post>();
            if (!string.IsNullOrEmpty(searchKey))
            {
                posts = _postRepository.PostsBySearchKey(searchKey).ToList();
            }
            var postListViewModel = new PostListViewModel
            {
                Posts = posts,
                CurrentCategory = "Search"
            };
            return View(postListViewModel);
        }

        public IActionResult Subscribe(string email)
        {
            PostListViewModel model = new PostListViewModel();
            if (_postRepository.SaveSubscribeEmail(email))
            {
                var msg = new MimeMessage();
                msg.From.Add(new MailboxAddress("BigKitten", "bigkitten.info@gmail.com"));
                msg.To.Add(new MailboxAddress("subsciber", email));
                msg.Subject = "Confirm your subscription for BigKitten";
                msg.Body = new TextPart
                {
                    Text = "Howdy. You recently signed up to follow this blog's posts. " +
                    "This means once you confirm below, you will receive each new post by email. Blog Name: Big Kitten."
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("bigkitten.info@gmail.com", "Chich0em");
                    client.Send(msg);
                    client.Disconnect(true);
                }
            }
            return View(model);
        }
    }
}
