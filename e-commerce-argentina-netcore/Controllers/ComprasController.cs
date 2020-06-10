using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_argentina_netcore.Controllers
{
    public class ComprasController : Controller
    {
        public IActionResult Compras()
        {
            return View();
        }
    }
}