using Aspudoku.Models;
using Sudoku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspudoku.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(int CreateGame = 0)
        {
            if (Sudo.puzzle == null || CreateGame == 1)
            {
                Sudo.Create();
                ViewData["puzzle"] = Sudo.puzzle;

                if (CreateGame == 1)
                    return RedirectToAction("Index");
            }
            else
            {
                ViewData["puzzle"] = Sudo.puzzle;
            }
            return View();
        }

        public ActionResult Search(string name)
        {
            //some operations goes here
            
            return RedirectToAction("Index"); //return "Events" view to the user
        }
    }
}
