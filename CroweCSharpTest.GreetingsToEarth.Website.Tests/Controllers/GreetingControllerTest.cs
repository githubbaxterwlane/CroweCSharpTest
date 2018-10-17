using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CroweCSharpTest.GreetingsToEarthWebsite.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class GreetingControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            GreetingController controller = new GreetingController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
      
    }
}
