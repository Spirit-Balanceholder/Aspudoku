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

        public ActionResult Hint(short[,] puzzle)
        {
            //fields == sudo.puzzle oftewel de puzzle die we eekrijgen. 



            //short x, y, v;
            //int s;
            //bool filled = false;

            //while (!filled)
            //{

            //    if (!IsComplete())
            //    {
            //        game.hint(out x, out y, out v, out s);
            //        if (Fields[y - 1, x - 1].Text.Equals(""))
            //        {
            //            Fields[y - 1, x - 1].Text = v.ToString();
            //            filled = true;
            //            Console.Beep(800, 50);

            //            //might need this later on 
            //            // break;
            //        }
            //        else
            //        {
            //            filled = false;
            //        }
            //    }
            //    else
            //    {
            //        Console.Beep(800, 500);
            //        filled = true;
            //    }

            //}
            return RedirectToAction("Index");
        }          

      
    }
}
