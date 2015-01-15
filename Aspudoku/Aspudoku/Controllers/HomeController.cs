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
        Sudo sudo = new Sudo();
        //
        // GET: /Home/
        public ActionResult Index(int CreateGame = 0)
        {
            if (CreateGame == 1)
            {
                sudo.Create();
                ViewData["puzzle"] = sudo.puzzle;
            }
            return View();
        }
    }
}
