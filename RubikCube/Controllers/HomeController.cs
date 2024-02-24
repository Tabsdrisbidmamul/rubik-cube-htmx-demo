using Microsoft.AspNetCore.Mvc;
using RubikCube.Models;
using RubikCube.Services;
using System.Diagnostics;

namespace RubikCube.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRubikCube _rubikCubeService;

        public HomeController(ILogger<HomeController> logger, IRubikCube rubikCubeService)
        {
            _logger = logger;
            _rubikCubeService = rubikCubeService;
        }

        public IActionResult Index()
        {
            
            return View(new RubikCubeModel {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult Reset()    
        {
            _rubikCubeService.reset();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateFront90Clockwise() 
        {
            _rubikCubeService.rotateFront90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateFront90AntiClockwise() 
        {
            _rubikCubeService.rotateFront90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateBack90Clockwise() 
        {
            _rubikCubeService.rotateBack90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateBack90AntiClockwise()
        {
            _rubikCubeService.rotateBack90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateUp90Clockwise() 
        {
            _rubikCubeService.rotateUp90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateUp90AntiClockwise()
        {
            _rubikCubeService.rotateUp90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateDown90Clockwise() 
        {
            _rubikCubeService.rotateDown90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateDown90AntiClockwise()
        {
            _rubikCubeService.rotateDown90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }
        
        public IActionResult RotateRight90Clockwise()
        {
            _rubikCubeService.rotateRight90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult RotateRight90AntiClockwise()
        {
            _rubikCubeService.rotateRight90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.getRubikFaces()
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
