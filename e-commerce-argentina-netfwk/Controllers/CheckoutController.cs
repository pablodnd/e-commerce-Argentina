using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_commerce_argentina_netfwk.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            CheckoutMpService checkout = new CheckoutMpService();
            ArticuloViewModel miArticulo = new ArticuloViewModel();
            miArticulo.InitPoint = checkout.CrearPreferencia(miArticulo)?.InitPoint;
            return View(miArticulo);
        }
        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Failure()
        {
            return View();
        }

        public ActionResult Pending()
        {
            return View();
        }
    }
}