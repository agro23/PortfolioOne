using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;


namespace PortfolioAssignment.Controllers
{
    public class CommentsController : Controller
    {
        public PortfolioDbContext _db;
        public UserManager<ApplicationUser> _userManager;

        public CommentsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PortfolioDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Create()
        {
            Comment newComment = new Comment(int.Parse(Request.Form["blogPostId"]), Request.Form["author"], Request.Form["content"]);
            _db.Comments.Add(newComment);
            _db.SaveChanges();
            return RedirectToAction("Details", "BlogPost", new { id = newComment.BlogPostId });
        }
    }
}


////using System.Linq;
////using System.Threading.Tasks;
////using Microsoft.AspNetCore.Mvc;
////using Microsoft.AspNetCore.Authorization;
////using Portfolio.Models;
////using Microsoft.AspNetCore.Identity;
////using System.Security.Claims;

////namespace Portfolio.Controllers
////{
//    //[Authorize]
//    //public class CommentController : Controller

//    //{
//        //private readonly PortfolioDbContext _db;
//        //private readonly UserManager<ApplicationUser> _userManager;

//        //public CommentController(UserManager<ApplicationUser> userManager, PortfolioDbContext db)
//        //{
//        //    _userManager = userManager;
//        //    _db = db;
//        //}

//        //public IActionResult Index()
//        //{
//        //    return View();
//        //}
//        //public async Task<IActionResult> Index()
//        //{
//        //    var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//        //    var currentUser = await _userManager.FindByIdAsync(userId);
//        //    return View(_db.Comments.Where(x => x.ApplicationUser.Id == currentUser.Id));
//        //}

//        //public IActionResult Details(int id)
//        //{
//        //    var thisComment = _db.Comments.FirstOrDefault(Comments => Comments.CommentId == id);
//        //    return View(thisComment);
//        //}

//        //public IActionResult Create(int id)
//        //{
//        //    Comment Model = new Comment();
//        //    Model.BlogPostId = id;
//        //    return View(Model);
//        //}

//        //[HttpPost]
//        //public async Task<IActionResult> Create(Comment comment)
//        //{
//        //    var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//        //    var currentUser = await _userManager.FindByIdAsync(userId);
//        //    comment.ApplicationUser = currentUser;
//        //    _db.Comments.Add(comment);
//        //    _db.SaveChanges();
//        //    return RedirectToAction("Index", "BlogPost");
//        //}

//        //public IActionResult Create()
//        //{
//        //    //Comment newComment = new Comment(int.Parse(Request.Form["postId"]), Request.Form["author"], Request.Form["content"]);
//        //    Comment newComment = new Comment(int.Parse(Request.Form["postId"]), Request.Form["content"]);
//        //    _db.Comments.Add(newComment);
//        //    _db.SaveChanges();
//        //    return RedirectToAction("Details", "Posts", new { id = newComment.BlogPostId });
//        //}


//        //public ActionResult Delete(int id)
//        //{
//        //    var thisComment = _db.Comments.FirstOrDefault(Comments => Comments.CommentId == id);
//        //    return View(thisComment);
//        //}
//        //[HttpPost, ActionName("Delete")]
//        //public IActionResult DeleteConfirmed(int id)
//        //{
//        //    var thisComment = _db.Comments.FirstOrDefault(Comments => Comments.CommentId == id);
//        //    _db.Comments.Remove(thisComment);
//        //    _db.SaveChanges();
//        //    return RedirectToAction("Index");
//        //}
////    }
////}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Portfolio.Models;
//using System.Security.Claims;


//namespace Portfolio.Controllers
//{
//    [Authorize]
//    public class CommentController : Controller

//    {
//        private readonly PortfolioDbContext _db;
//        private readonly UserManager<ApplicationUser> _userManager;

//        //public CommentController(UserManager<ApplicationUser> userManager, PortfolioDbContext db)
//        //{
//        //    _userManager = userManager;
//        //    _db = db;
//        //}

//        //public IActionResult Create()
//        //{
//        //    Comment newComment = new Comment(int.Parse(Request.Form["postId"]), Request.Form["author"], Request.Form["content"]);
//        //    _db.Comments.Add(newComment);
//        //    _db.SaveChanges();
//        //    return RedirectToAction("Details", "BlogPost", new { id = newComment.BlogPostId });
//        //}

//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Create(Comment comment)
//        //{
//        //    //comment.BlogPostId = await _db.BlogPosts
//        //    //    .Include(c => c.Comments)
//        //    //    .FirstOrDefaultAsync(p => p.Id == comment.BlogPostId);
//        //    //var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//        //    //var currentUser = await _userManager.FindByIdAsync(userId);
//        //    //comment.ApplicationUser = currentUser;
//        //    //comment.UserId = userId;


//        //        var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//        //        var currentUser = await _userManager.FindByIdAsync(userId);
//        //        comment.ApplicationUser = currentUser;
//        //        _db.Comments.Add(comment);
//        //        _db.SaveChanges();
//        //        //return RedirectToAction("Index", "BlogPost");
//        //        return RedirectToAction("Details", "BlogPost", new { id = comment.BlogPostId });

//        //    //if (ModelState.IsValid)
//        //    //{
//        //    //    _db.Comments.Add(comment);
//        //    //    await _db.SaveChangesAsync();
//        //    //    return RedirectToAction("Details", "BlogPost", new { id = comment.BlogPostId });
//        //    //}
//        //    //return View(comment);
//        //}

//        public ApplicationDbContext _db;

//        public CommentsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
//        {
//            _userManager = userManager;
//            _db = db;
//        }

//        public IActionResult Create()
//        {
//            Comment newComment = new Comment(int.Parse(Request.Form["postId"]), Request.Form["author"], Request.Form["content"]);
//            _db.Comments.Add(newComment);
//            _db.SaveChanges();
//            return RedirectToAction("Details", "Posts", new { id = newComment.PostId });
//        }

//        public ActionResult Delete(int id)
//        {
//            var thisComment = _db.Comments.FirstOrDefault(Comments => Comments.CommentId == id);
//            return View(thisComment);
//        }
//        [HttpPost, ActionName("Delete")]
//        public IActionResult DeleteConfirmed(int id)
//        {
//            var thisComment = _db.Comments.FirstOrDefault(Comments => Comments.CommentId == id);
//            _db.Comments.Remove(thisComment);
//            _db.SaveChanges();
//            return RedirectToAction("Index");
//        }
//    }
//}

