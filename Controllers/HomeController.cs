﻿using desafio_final_atos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace desafio_final_atos.Controllers
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

        public IActionResult Cliente()
        {
            return View();
        }
        public IActionResult Produto()
        {
            return View();
        }
        public IActionResult Venda()
        {
            return View();
        }
        public IActionResult ItemVenda()
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