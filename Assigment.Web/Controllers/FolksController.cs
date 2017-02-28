using Assigment.Interface;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assigment.Web.Controllers
{
    public class FolksController : Controller
    {
        // GET: Folks
        public static IFolksService _iFolksService;
        public FolksController(IFolksService folksService)
        {
            _iFolksService = folksService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllFolksDetails()
        {
            List<FolksViewModel> resultObj = _iFolksService.GetAllFolksDetails();
            return Json(new { data = resultObj }, JsonRequestBehavior.AllowGet);
        }
    }
}