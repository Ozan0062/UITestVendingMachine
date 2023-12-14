using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Net;

namespace UITestVendingMachine
{
    [TestClass]
    public class UITest
    {
        private static readonly string DriverDirectory = "C:\\Driver";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
            //_driver = new EdgeDriver(DriverDirectory);

            _driver.Navigate().GoToUrl("https://nice-rock-09b5d2203.4.azurestaticapps.net/");

        }

        [ClassCleanup]
        public static void TearDown()
        {
            //_driver.Dispose();
        }

        //[TestMethod]
        //public void CreateTest()
        //{
        //    string Title = _driver.Title;
        //    Assert.AreEqual("Vending Machine", Title);
        //    IWebElement create = _driver.FindElement(By.Id("create"));
        //    create.Click();
        //    string CreateTitle = _driver.Title;
        //    Assert.AreEqual("Opret Bruger", CreateTitle);
        //    IWebElement addFirstName = _driver.FindElement(By.Id("addFirstName"));
        //    addFirstName.SendKeys("Oliver");
        //    IWebElement addLastName = _driver.FindElement(By.Id("addLastName"));
        //    addLastName.SendKeys("Kruse");
        //    IWebElement addEmail = _driver.FindElement(By.Id("addEmail"));
        //    addEmail.SendKeys("oliverkruse@gmail.com");
        //    IWebElement addMobileNumber = _driver.FindElement(By.Id("addMobileNumber"));
        //    addMobileNumber.SendKeys("93959416");
        //    IWebElement addUser = _driver.FindElement(By.Id("addUser"));
        //    addUser.Click();
        //}


        [TestMethod]
        public void AccountingTest()
        {
            string Title = _driver.Title;
            Assert.AreEqual("Vending Machine", Title);
            IWebElement create = _driver.FindElement(By.Id("accounting"));
            create.Click();
            string AccountingTitle = _driver.Title;
            Assert.AreEqual("Regnskab", AccountingTitle);
            IWebElement addFilter = _driver.FindElement(By.Id("addFilter"));
            addFilter.SendKeys("Oliver");
            IWebElement buttonFilter = _driver.FindElement(By.Id("buttonFilter"));
            buttonFilter.Click();
            IWebElement sumButton = _driver.FindElement(By.Id("sumButton"));
            sumButton.Click();
        }
    }
}