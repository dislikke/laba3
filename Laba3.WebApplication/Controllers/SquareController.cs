using Laba3.ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Laba3.WebApplication.Models;

namespace Laba3.WebApplication.Controllers
{
    public class SquareController : Controller
    {
        [HttpGet]
        public IActionResult Index(SquareModel vm)
        {
            return View(vm);
        }

        [HttpPost]
        public IActionResult Calculator(IFormCollection collection, SquareModel vm)
        {
            double SmallRadius = vm.smallRadius;
            double LargeRadius = vm.largeRadius;
            double Generatrix = vm.generatrix;
            double LatSquare = new ClassSquare().S(SmallRadius, LargeRadius, Generatrix);
            vm.latSquare = LatSquare;
            return View(vm);
        }
    }
}
