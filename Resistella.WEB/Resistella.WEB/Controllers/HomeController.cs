using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Resistella.WEB.Configuration;
using Resistella.WEB.Models;
using Resistella.WEB.Models.API_Communication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Resistella.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiConnection _apiConnection;
        public HomeController(ILogger<HomeController> logger, IOptions<ApiConnection> conection)
        {
            _logger = logger;
            _apiConnection=conection.Value;
        }

        public IActionResult Index()
        {
            new APi_dal().GetArticle(_apiConnection.Adress);
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
