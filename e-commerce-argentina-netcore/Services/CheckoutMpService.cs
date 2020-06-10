using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce_argentina_netcore.Models;

namespace e_commerce_argentina_netcore.Services
{
    public class CheckoutMpService
    {
        private readonly string _accessToken;

        public CheckoutMpService()
        {
            this._accessToken = string.Empty;
        }

        public string CrearPreferencia(ArticuloViewModel articulo)
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
