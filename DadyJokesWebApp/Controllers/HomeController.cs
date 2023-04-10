using DaddyJokesWebApp.Models;
using DaddyJokesWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using DaddyJokesWebApp.Filters;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DaddyJokesWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDaddyJokeservice _DaddyJokeservice;

        public HomeController(IDaddyJokeservice DaddyJokeservice, ILogger<HomeController> logger)
        {
            _logger = logger;
            _DaddyJokeservice = DaddyJokeservice;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [TypeFilter(typeof(DaddyJokesExceptionFilter))]
        public IActionResult RandomJoke()
        {
            var joke = _DaddyJokeservice.GetRandomJoke().Result;
            return View(joke);
        }
        [HttpGet]
        [TypeFilter(typeof(DaddyJokesExceptionFilter))]
        public IActionResult RandomJokeCount()
        {
            var joke = _DaddyJokeservice.GetRandomJokeCount().Result;
            return View(joke);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
