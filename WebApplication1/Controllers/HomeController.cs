using OthelloModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public static class Game
    {
        public static OthelloGame OthelloGame = new OthelloGame();

        public static char ToChar(this GamePiece gp)
        {
            switch (gp)
            {
                case GamePiece.Blank:
                default:
                    return ' ';
                case GamePiece.Black:
                    return '\u25CF';
                case GamePiece.White:
                    return '\u25CB';
            }
        }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(Game.OthelloGame);
        }

        public ActionResult Move(int row, int col)
        {
            Game.OthelloGame.Move(row, col);

            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}