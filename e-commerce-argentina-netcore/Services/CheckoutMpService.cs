using e_commerce_argentina_netcore.Models;
using MercadoPago.DataStructures.Preference;
using MercadoPago.Resources;

namespace e_commerce_argentina_netcore.Services
{
    public class CheckoutMpService
    {
        private readonly string _accessToken;

        public CheckoutMpService()
        {
            this._accessToken = "TEST-2322448352582789-061101-864d55dd7466f15dd8b44b180b0e8f42-582774213";
            MercadoPago.SDK.AccessToken = this._accessToken;
        }

        public string CrearPreferencia(ArticuloViewModel articulo)
        {
            Preference preference = new Preference();
            preference.Id = "1234";
            preference.Items.Add(
                new Item()
                {
                    Title = "Samsung Galaxy Z-Flip",
                    Description = "Samsung Galaxy Z-Flip",
                    PictureUrl = "https://images.samsung.com/ar/smartphones/galaxy-z-flip/images/galaxy-z-flip-share-image.jpg",
                    Quantity = 1,
                    UnitPrice = 139999
                });
            preference.ExternalReference = "pablogaston1989@gmail.com"; 

            preference.Save();

            return preference.Id;
        }
    }
}
