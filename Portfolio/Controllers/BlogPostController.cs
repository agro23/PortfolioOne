using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Portfolio.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System;

namespace Portfolio.Controllers
{
    [Authorize]
    public class BlogPostController : Controller
    {
        private readonly PortfolioDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public BlogPostController(UserManager<ApplicationUser> userManager, PortfolioDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            return View(_db.BlogPosts.Where(x => x.ApplicationUser.Id == currentUser.Id));
        }

        public IActionResult Create()
        {
            return View();
        }

        //public IActionResult Details(int id)
        //{
        //    var thisBlogPost = _db.BlogPosts.FirstOrDefault(BlogPosts => BlogPosts.BlogPostId == id);
        //    return View(thisBlogPost);
        //}



        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var post = await _context.Posts
            var post = await _db.BlogPosts

                .Include(c => c.Comments)
                .SingleOrDefaultAsync(m => m.BlogPostId == id);
            Comment comment = new Comment();
            comment.BlogPost = post;
            comment.BlogPostId = (int)id;
            //ViewBag.Comments = _context.Comments.Where(c => c.PostId == id);
            ViewBag.Comments = _db.Comments.Where(c => c.BlogPostId == id);

            if (post == null)
            {
                return NotFound();
            }

            return View(comment);
        }


        // GET: BlogPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _db.BlogPosts.SingleOrDefaultAsync(m => m.BlogPostId == id);
            if (blogPost == null)
            {
                return NotFound();
            }
            return View(blogPost);
        }

        // POST: BlogPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BlogPostId,Title,Content")] BlogPost blogPost)
        {
            if (id != blogPost.BlogPostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(blogPost);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogPostExists(blogPost.BlogPostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(blogPost);
        }

        private bool BlogPostExists(int id)
        {
            return _db.BlogPosts.Any(e => e.BlogPostId == id);
        }



        [HttpPost]
        public async Task<IActionResult> Create(BlogPost blogpost)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            blogpost.ApplicationUser = currentUser;
            _db.BlogPosts.Add(blogpost);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisBlogPost = _db.BlogPosts.FirstOrDefault(BlogPosts => BlogPosts.BlogPostId == id);
            return View(thisBlogPost);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisBlogPost = _db.BlogPosts.FirstOrDefault(BlogPosts => BlogPosts.BlogPostId == id);
            _db.BlogPosts.Remove(thisBlogPost);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
