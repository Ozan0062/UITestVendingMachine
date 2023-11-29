using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

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

            _driver.Navigate().GoToUrl("file:///C:/Users/ohsab/Desktop/Datamatiker/3.%20Semester/3.%20Semester%20Projekt/Hjemmeside/index.html");

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
        //    addFirstName.SendKeys("Jacob");
        //    IWebElement addLastName = _driver.FindElement(By.Id("addLastName"));
        //    addLastName.SendKeys("Jacobsen");
        //    IWebElement addEmail = _driver.FindElement(By.Id("addEmail"));
        //    addEmail.SendKeys("jacobjacobsen@gmail.com");
        //    IWebElement addMobileNumber = _driver.FindElement(By.Id("addMobileNumber"));
        //    addMobileNumber.SendKeys("85239712");
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

        }
    }
}