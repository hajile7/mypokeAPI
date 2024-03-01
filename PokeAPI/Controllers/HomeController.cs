using Microsoft.AspNetCore.Mvc;
using PokeAPI.Models;
using PokeAPI.Models.DALs;
using System.Diagnostics;

namespace PokeAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Result(string pokemon)
        {
            PokemonModel result = PokemonDAL.GetPokemon(pokemon);
            if (result == null)
            {
                RedirectToAction("Index");
            }
            return View(result);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
