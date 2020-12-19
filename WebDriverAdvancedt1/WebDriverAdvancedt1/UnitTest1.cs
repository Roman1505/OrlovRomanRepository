using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverAdvanced.po;


namespace WebDriverBasic
{

    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private MainPage mainPage;
        private HomePage homePage;
        private AllProductsPage allProductsPage;
        private ProductEditingPage productEditingPage;

        
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void Test1()
        {

            mainPage = new MainPage(driver);
            homePage = mainPage.WriteFields("user", "user");
            var adress = driver.Url;
            var tittle = driver.FindElement(By.TagName("h2")).Text;
            var image = driver.FindElement(By.TagName("img")).GetAttribute("src");
            Assert.AreEqual("Home page", tittle);
            Assert.AreEqual("http://localhost:5000/images/logo.jpg", image);
            allProductsPage = homePage.GoTo();
            productEditingPage = allProductsPage.GoToPage();
            productEditingPage.WriteFields("ProductName", "Chang chang");
            productEditingPage.WriteFields("//select[@id=\"CategoryId\"]//option[@value=\"1\"]");
            productEditingPage.WriteFields("//select[@id=\"SupplierId\"]//option[@value=\"1\"]");
            productEditingPage.WriteFields("UnitPrice", "24 - 12 oz bottles");
            productEditingPage.WriteFields("QuantityPerUnit", "20");
            productEditingPage.WriteFields("UnitsInStock", "17");
            productEditingPage.WriteFields("UnitsOnOrder", "0");
            productEditingPage.WriteFields("ReorderLevel", "0");
            allProductsPage = productEditingPage.Return();

        }



        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}