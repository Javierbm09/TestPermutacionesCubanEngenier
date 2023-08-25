using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestPermutacionesCubanEngenier.Models;
using TestPermutacionesCubanEngenier.Services;

namespace TestPermutacionesCubanEngenier.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPermutationService _permutationService;

        public HomeController(IPermutationService permutationService)
        {
            _permutationService = permutationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(Permutation model)
        {
            if (ModelState.IsValid && !string.IsNullOrWhiteSpace(model.Numbers))
            {
                List<int> lista = new List<int>(Array.ConvertAll(model.Numbers.Split(','), int.Parse));
                List<int> result = _permutationService.NextPermutation(lista);
                ViewBag.Result = string.Join(", ", result);
            }

            return View(model);
        }
    }
}
