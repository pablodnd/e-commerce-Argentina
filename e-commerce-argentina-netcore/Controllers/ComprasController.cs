using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce_argentina_netcore.Models;
using e_commerce_argentina_netcore.Services;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce_argentina_netcore.Controllers
{
    public class ComprasController : Controller
    {
        public IActionResult Compras()
        {
            CheckoutMpService checkout = new CheckoutMpService();
            ArticuloViewModel articulo = new ArticuloViewModel()
            {
            };
            articulo.Id = checkout.CrearPreferencia(articulo);
            return View(articulo);
        }
    }
}