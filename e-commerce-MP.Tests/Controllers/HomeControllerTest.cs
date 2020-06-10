using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using e_commerce_MP;
using e_commerce_MP.Controllers;

namespace e_commerce_MP.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
