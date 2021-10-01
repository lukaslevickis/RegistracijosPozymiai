using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistracijosPozymiai.DAL;
using RegistracijosPozymiai.DAL.Collections;
using RegistracijosPozymiai.DAL.Repositories;
using RegistracijosPozymiai.Models;

namespace RegistracijosPozymiai.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMongoRepository<Option> _optionRepository;

        public HomeController(IMongoRepository<Option> optionRepository)
        {
            _optionRepository = optionRepository;
        }

        public IActionResult Index()
        {
            var aa = _optionRepository.Get();
            return View();
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
