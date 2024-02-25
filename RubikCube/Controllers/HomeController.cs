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
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult Reset()    
        {
            _rubikCubeService.Reset();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateFront90Clockwise() 
        {
            _rubikCubeService.RotateFront90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateFront90AntiClockwise() 
        {
            _rubikCubeService.RotateFront90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateBack90Clockwise() 
        {
            _rubikCubeService.RotateBack90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateBack90AntiClockwise()
        {
            _rubikCubeService.RotateBack90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateUp90Clockwise() 
        {
            _rubikCubeService.RotateUp90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateUp90AntiClockwise()
        {
            _rubikCubeService.RotateUp90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateDown90Clockwise() 
        {
            _rubikCubeService.RotateDown90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateDown90AntiClockwise()
        {
            _rubikCubeService.RotateDown90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }
        
        public IActionResult RotateRight90Clockwise()
        {
            _rubikCubeService.RotateRight90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateRight90AntiClockwise()
        {
            _rubikCubeService.RotateRight90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateLeft90Clockwise()
        {
            _rubikCubeService.RotateLeft90Clockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
            });
        }

        public IActionResult RotateLeft90AntiClockwise()
        {
            _rubikCubeService.RotateLeft90AntiClockwise();
            return PartialView("~/Views/Partials/RubikContainer.cshtml", new RubikCubeModel
            {
                faces = _rubikCubeService.GetRubikFaces()
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
