using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoPago;
using MercadoPago.Resources;
using MercadoPago.DataStructures.Preference;

namespace e_commerce_MP.Services
{
    public class CheckoutMPService
    {
        private readonly string _accessToken;

        public CheckoutMPService()
        {
            this._accessToken = string.Empty;
        }

        public string CrearPreferencia(Articulo articulo)
        {
            //Preference preference = new Preference();

            //preference.Items.Add(
            //    new Item() { 

            //    });

            //preference.Save();

            return "123";

            //return preference.Id;
        }
    }
}
