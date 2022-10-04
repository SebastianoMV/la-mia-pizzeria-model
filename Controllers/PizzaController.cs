﻿using la_mia_pizzeria_model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("Margherita", "Pomodoro, mozzarella", "data:image/jpeg;base64,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", 5));
            pizzas.Add(new Pizza("Marinara", "Pomodoro, aglio", "data:image/jpeg;base64,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", 5));
            pizzas.Add(new Pizza("Patate", "Pomodoro, mozzarella, patate", "data:image/jpeg;base64,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", 6));
        
            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> pizzas = new List<Pizza>();
           
            return View(pizzas);
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