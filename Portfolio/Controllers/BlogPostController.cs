using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Portfolio.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

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

        public IActionResult Details(int id)
        {
            var thisBlogPost = _db.BlogPosts.FirstOrDefault(BlogPosts => BlogPosts.BlogPostId == id);
            return View(thisBlogPost);
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
