using System;
using testMVC.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testMVC.Models;


namespace testMVC.Controllers
{
    public class HomeController : Controller
    {
        public IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository){
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            _productRepository.InsertProducts();
            return View(_productRepository.GetProducts("Clothing"));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
