using mdCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace mdCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
            new Article(1,"آموزش ASP.NET Core MVC","اولین پروژه ی برنامه نویسی من با تکنولوژی Asp.Net","blog-post-thumb-card-1.jpg"),
            new Article(2,"آموزش برنامه نویسی با فلاتر","اولین آموزش فارسی فلاتر به صورت جامع برای فارسی زبانان","blog-post-thumb-card-2.jpg"),
            new Article(3,"آموزش Git & GitHub","اولین پکیج جامع آموزشی Git","blog-post-thumb-card-3.jpg"),
            new Article(4,"آموزش معماری پیاز","آموزش کامل معماری پیاز Onion Architecture","blog-post-thumb-card-4.jpg"),
            };
            return View("LatestArticles",articles);
            
        }
    }
}
