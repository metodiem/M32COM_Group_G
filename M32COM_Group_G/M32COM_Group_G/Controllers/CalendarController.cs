using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M32COM_Group_G.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }
        //public JsonResult GetEvents()
        //{
        //    using (MyDatabaseEntities dc = new MyDatabaseEntities())
        //    {
        //        var events = dc.Events.ToList();
        //        return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        //    }
        //}
    }
}