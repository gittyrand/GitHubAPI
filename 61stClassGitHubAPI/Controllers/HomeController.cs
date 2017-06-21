using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _61stClassGitHubAPI.Models;
using GitHubStuff.Data;

namespace _61stClassGitHubAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult GetInfo(string login)
        {
            GitHubFunctions repo = new GitHubFunctions();
            GitHubViewModel vm = new GitHubViewModel();
            vm.ghUser = repo.GetUser(login);
            vm.ghRepos = repo.GetRepos(login);
            return Json( vm , JsonRequestBehavior.AllowGet);
        } 
    }
}