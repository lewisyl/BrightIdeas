using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                HttpContext.Session.SetInt32("IsLoggedIn", 0);
                return View();
            }
            else
            {
                return RedirectToAction("Dashboard");
            }
        }


        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {

            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u=>u.Email == newUser.Email))
                {
                    ModelState.AddModelError("newUser.Email", "This Email has been used!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetInt32("IsLoggedIn", 1);
                    return RedirectToAction("Dashboard");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser returnUser)
        {
            if (ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault(u=>u.Email == returnUser.Email);
                if (userInDb == null)
                {
                    ModelState.AddModelError("returnUser.Email", "Invalid Email/Password");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(returnUser, userInDb.Password, returnUser.Password);
                    if (result == 0)
                    {
                        ModelState.AddModelError("returnUser.Password", "Invalid Email/Password");
                        return View("Index");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                        HttpContext.Session.SetInt32("IsLoggedIn", 1);
                        return RedirectToAction("Dashboard");
                    }
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("dashboard")]
        public IActionResult Dashboard()
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Dashboard dashboardContext = new Dashboard();
                List<Idea> AllIdeas = dbContext.Ideas
                    .OrderByDescending(lkdby=>lkdby.LikedBy.Count)
                    .Include(idea=>idea.LikedBy)
                    .ThenInclude(like=>like.User)
                    .ToList();
                List<User> AllUsers = dbContext.Users
                    .Include(u=>u.Likes)
                    .ThenInclude(like=>like.Idea)
                    .ToList();
                int? thisuserID = HttpContext.Session.GetInt32("UserId");
                if (thisuserID == null)
                {
                    thisuserID = dbContext.Users.Last().UserId;
                    HttpContext.Session.SetInt32("UserId", thisuserID.Value);
                }
                User UserInDb = dbContext.Users.FirstOrDefault(u=>u.UserId == HttpContext.Session.GetInt32("UserId").Value);
                dashboardContext.ThisUser = UserInDb;
                dashboardContext.AllIdeas = AllIdeas;
                dashboardContext.AllUsers = AllUsers;
                return View(dashboardContext);
            }
        }

        [HttpPost("new-idea")]
        public IActionResult AddIdea(Dashboard newIdea)
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    int creatorId = HttpContext.Session.GetInt32("UserId").Value;
                    newIdea.Idea.CreatedBy = creatorId;
                    dbContext.Add(newIdea.Idea);
                    dbContext.SaveChanges();
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    Dashboard dashboardContext = new Dashboard();
                    List<Idea> AllIdeas = dbContext.Ideas
                        .OrderByDescending(lkdby=>lkdby.LikedBy.Count)
                        .Include(idea=>idea.LikedBy)
                        .ThenInclude(like=>like.User)
                        .ToList();
                    List<User> AllUsers = dbContext.Users
                        .Include(u=>u.Likes)
                        .ThenInclude(like=>like.Idea)
                        .ToList();
                    int? thisuserID = HttpContext.Session.GetInt32("UserId");
                    if (thisuserID == null)
                    {
                        thisuserID = dbContext.Users.Last().UserId;
                        HttpContext.Session.SetInt32("UserId", thisuserID.Value);
                    }
                    User UserInDb = dbContext.Users.FirstOrDefault(u=>u.UserId == HttpContext.Session.GetInt32("UserId").Value);
                    dashboardContext.ThisUser = UserInDb;
                    dashboardContext.AllIdeas = AllIdeas;
                    dashboardContext.AllUsers = AllUsers;
                    return View("Dashboard",dashboardContext);
                }
            }
        }

        [HttpGet("like/{ideaId}")]
        public IActionResult LikeThis(int ideaId)
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                int userId = HttpContext.Session.GetInt32("UserId").Value;
                Like newLike = new Like();
                newLike.UserId = userId;
                newLike.IdeaId = ideaId;
                dbContext.Add(newLike);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        [HttpGet("unlike/{ideaId}")]
        public IActionResult UnlikeThis(int ideaId)
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                int userId = HttpContext.Session.GetInt32("UserId").Value;
                Like unlike = dbContext.Likes
                    .FirstOrDefault(l=>l.IdeaId == ideaId);
                dbContext.Remove(unlike);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        [HttpGet("delete/{ideaId}")]
        public IActionResult DeleteIdea(int ideaId)
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Idea deleteThisIdea = dbContext.Ideas.FirstOrDefault(i=>i.IdeaId == ideaId);
                dbContext.Ideas.Remove(deleteThisIdea);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        [HttpGet("idea-detail/{ideaId}")]
        public IActionResult IdeaDetail(int ideaId)
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Idea thisIdea = dbContext.Ideas
                    .FirstOrDefault(i=>i.IdeaId==ideaId);
                List<User> Likers = dbContext.Users
                    .Include(u=>u.Likes)
                    .Where(l=>l.Likes.Any(lk=>lk.IdeaId==ideaId))
                    .ToList();
                List<User> AllUsers = dbContext.Users
                    .Include(u=>u.Likes)
                    .ThenInclude(like=>like.Idea)
                    .ToList();
                Dashboard detailContext = new Dashboard();
                detailContext.Idea = thisIdea;
                detailContext.Likers = Likers;
                detailContext.AllUsers = AllUsers;
                return View(detailContext);
            }
        }

        [HttpGet("users/{userId}")]
        public IActionResult UserDetail(int userId)
        {
            int? IfLoggedIn = HttpContext.Session.GetInt32("IsLoggedIn");
            if (IfLoggedIn != 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                User thisUser = dbContext.Users
                .FirstOrDefault(u=>u.UserId==userId);
                int TotalPosts = dbContext.Ideas
                .Where(i=>i.CreatedBy==userId)
                .Count();
                int TotalLikes = dbContext.Likes
                .Where(l=>l.UserId==userId)
                .Count();
                UserDetail userDetail = new UserDetail();
                userDetail.TotalLikes = TotalLikes;
                userDetail.TotalPosts = TotalPosts;
                userDetail.User = thisUser;
                return View(userDetail);
            }
        }
        



    }
}
