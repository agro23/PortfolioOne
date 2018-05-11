using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<StarredProject> model = StarredProject.GitRepoList();
            return View(model);
        }

        //public IActionResult GitRepoList()
        //{
        //    var allRepos = StarredProject.GitRepoList();
        //    return View(allRepos);
        //}
    }
}
