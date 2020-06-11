using System.Collections.Generic;
using MercadoPago.Common;
using MercadoPago.DataStructures.Preference;
using MercadoPago.Resources;

namespace e_commerce_argentina_netfwk
{
    public class CheckoutMpService
    {
        private readonly string _accessToken;

        public CheckoutMpService()
        {
            this._accessToken = "TEST-2322448352582789-061101-864d55dd7466f15dd8b44b180b0e8f42-582774213";
            MercadoPago.SDK.AccessToken = this._accessToken;
            MercadoPago.SDK.IntegratorId = "dev_24c65fb163bf11ea96500242ac130004";
        }

        public Preference CrearPreferencia(ArticuloViewModel articulo)
        {
            Preference preference = new Preference();
            preference.NotificationUrl = "https://webhook.site/b92ce833-40a4-43f9-85e2-b4ab7e9a43c4";
            var redirects = new BackUrls();
            redirects.Failure = "https://localhost:44394/Checkout/Failure";
            redirects.Success = "https://localhost:44394/Checkout/Success";
            redirects.Pending = "https://localhost:44394/Checkout/Pending";
            preference.BackUrls = redirects;
            preference.AutoReturn = AutoReturnType.approved;
            PaymentMethods paymentMethods = new PaymentMethods();
            paymentMethods.Installments = 6;

            MercadoPago.DataStructures.Preference.PaymentMethod methodAmex = new MercadoPago.DataStructures.Preference.PaymentMethod();
            methodAmex.Id = "amex";
            PaymentType paymentTypeATM = new PaymentType();
            paymentTypeATM.Id = "atm";
            var excludedPaymentMethods = new List<MercadoPago.DataStructures.Preference.PaymentMethod>();
            excludedPaymentMethods.Add(methodAmex);
            paymentMethods.ExcludedPaymentMethods = excludedPaymentMethods;
            var excludedPaymentTypes = new List<PaymentType>();
            excludedPaymentTypes.Add(paymentTypeATM);
            paymentMethods.ExcludedPaymentTypes = excludedPaymentTypes;
            preference.PaymentMethods = paymentMethods;
            
            preference.Id = "1234";
            preference.Items.Add(
                new Item()
                {
                    Title = "Samsung Galaxy Z-Flip",
                    Description = "Samsung Galaxy Z-Flip",
                    PictureUrl = "https://images.samsung.com/ar/smartphones/galaxy-z-flip/images/galaxy-z-flip-share-image.jpg",
                    Quantity = 1,
                    UnitPrice = 139999,
                    CurrencyId = CurrencyId.ARS
                });
            preference.ExternalReference = "pablogaston1989@gmail.com"; 

            preference.Save();

            return preference;
        }
    }
}
