using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Decision.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            var article = new ArticleController();
            return View(article);
        }

        /*[HttpPost]
        public ActionResult Create(Article article)
        {
            entities.Article.AddObject(article);
            entities.SaveChanges();

            return Redirect("/");
        }*/
    }
}