using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Mime;

namespace mdCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}



        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 1,
        //        name = "mohammad",
        //        family = "fallahi",
        //        job = "Progrmmer",
        //        telegram = "@mdblack1999"
        //    });
        //}


        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("alert('salam in yek alert javascript ast')");
        //}
        //--------------------------------------------
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        // با کد  بالایی فرقی ندارد
        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}
        //----------------------------------------
        //public IActionResult Index()
        //{
        //    return View("Footer");
        //}

        //------------------------------------
        //public ContentResult Index()
        //{
        //    ////return Content("<h1>سلام دنیا!! این یک ContentResult است </h1>","text/html",System.Text.Encoding.UTF8);
        //    return Content("<h1>This is Content Result</h1><script>confirm('This is confirm script ?');</script>", "text/html");

        //}
        //----------------------------------------
        //show Text File
        //public FileResult Index()
        //{
        //    return File("~/test.txt", "text/html");
        //}

        //downloadble File in Browser
        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(fileByte,MediaTypeNames.Text.Plain,fileName);
        //}
        //--------------------------------------------
        //public RedirectResult Index()
        //{
        //    return Redirect("https://google.com");
        //}
        //----------------------------------------------
        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}
        //-----------------------------------------------
        //public IActionResult Index()
        //{
        //    return new StatusCodeResult(402);
        //}

        //public IActionResult Index()
        //{
        //    //return new OkResult();
        //    return new BadRequestResult();
        //}

    }
    public class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string message)
        {
            Content = message;
            ContentType = "application/javascript";
        }
    }
}
