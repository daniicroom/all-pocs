using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PocAauth.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PocAauth.Controllers
{
    [Authorize]
    public class PruebaController : Controller
    {
        private readonly ILogger<PruebaController> _logger;

        public PruebaController(ILogger<PruebaController> logger)
        {
            _logger = logger;
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Standart()
        {
            return View();
        }
        public IActionResult Reenvio()
        {
            return View();
        }
    }
}
