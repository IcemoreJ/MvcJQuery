using MvcJQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJQuery.Controllers
{
    public class HomeController : Controller
    {
        //wqw
        MyFirstDatabaseEntities db = new MyFirstDatabaseEntities();
        public ActionResult Index()
        {
            List<UserInfos> list = db.UserInfos.ToList();
            return View(list);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public ActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(UserInfo user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        userServer.Add(user);
        //        return RedirectToAction("Index");
        //    }

        //    return View();
        //}

        //public ActionResult Details(int id = 0)
        //{
        //    var user = userServer.GetById(id);
        //    if (user == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(user);
        //}

        //public ActionResult Delete(int id = 0)
        //{
        //    var user = userServer.GetById(id);
        //    if (user == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View();
        //}/
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteInfo(int id)
        //{
        //    var user = userServer.GetById(id);

        //    userServer.Delete(user);
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Edit(int id = 0)
        //{
        //    var user = userServer.GetById(id);

        //    if (user == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(user);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(UserInfo user)
        //{
        //    bool flag = userServer.Updata(user);

        //    if (flag == false)
        //    {
        //        return HttpNotFound();
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}