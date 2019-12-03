using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication.Controllers;

namespace MyApplicationTest
{
    [TestClass]
    public class HomeControllerTest
    {
        //declare the home controller globally
        HomeController homeController;

        [TestInitialize]
        //this method runs automatically before every method
        public void TestInitialize()
        {

            //initialize the controller so we can test it
            homeController = new HomeController();
        }


        [TestMethod]
        public void IndexLoadsRightView()
        {
            //Step 1: Arrange the test -> setup any objects or variables
            //This step is moved to the initialize method

            //Step 2: Act(Call the method we want to test)
            var result = homeController.Index();

            //Step 3: Assert-> Evaluate the result to see if we get desired output
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AboutLoadsRightView()
        {
            //arrange
            //var homeController = new HomeController();
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
            //var homeController = new HomeController();
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
