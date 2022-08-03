using System.Web.Mvc;
using MicroServices01;
using MicroServices01.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicroServices01.Tests.Controllers
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
