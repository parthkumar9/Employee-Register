using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRegisterUnitTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexReturnsSomething()
        {
            //Step 1: Arrange the test -> setup any objects or variables
            var homeController = new HomeController();

            //Step 2: Act(Call the method we want to test)
            var result = homeController.Index();

            //Step 3: Assert-> Evaluate the result to see if we get desired output
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AboutLoadsRightView()
        {
            //arrange
            var homeController = new HomeController();
            //act
            var result = homeController.About();

            //we got back to the parent IActionResult class
            //we now need to convert this to ViewResult object
            //then we can check the name of the view
            var viewResult = (ViewResult)result;


            //assert
            Assert.AreEqual("About", viewResult.ViewName);
        }

        [TestMethod]
        public void ContactLoadsRightView()
        {
            //arrange
            var homeController = new HomeController();
            //act
            var result = homeController.Contact();

            //we got back to the parent IActionResult class
            //we now need to convert this to ViewResult object
            //then we can check the name of the view
            var viewResult = (ViewResult)result;


            //assert
            Assert.AreEqual("Contact", viewResult.ViewName);
        }
    }
}
