using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverBasic
{

    public class Tests
    {
        private OpenQA.Selenium.IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Test]
        public void LoginTest()
        {
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            var tittle = driver.FindElement(By.TagName("h2")).Text;
            Assert.AreEqual("Home page", tittle);
           
        }

        [Test]
        public void ProductEditionTest()
        {
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.XPath("//li/a[@href=\"/Product\"]")).Click();

            driver.FindElement(By.XPath("//a[@href=\"/Product/Create\"]")).Click();

            driver.FindElement(By.Id("ProductName")).SendKeys("Juce");
           
            driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]//option[@value=\"1\"]")).Click();
                        
            driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]//option[@value=\"1\"]")).Click();
                        
            driver.FindElement(By.Id("UnitPrice")).SendKeys("20");
                        
            driver.FindElement(By.Id("QuantityPerUnit")).SendKeys("24 - 12 oz bottles");
                       
            driver.FindElement(By.Id("UnitsInStock")).SendKeys("17");
                       
            driver.FindElement(By.Id("UnitsOnOrder")).SendKeys("0");
                        
            driver.FindElement(By.Id("ReorderLevel")).SendKeys("0");

            driver.FindElement(By.CssSelector(".btn")).Click();

            var text = driver.FindElement(By.TagName("h2")).Text;

            Assert.AreEqual("All Products",text);

        }

        [Test]
        public void AssertionTest()
        {
            
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.XPath("//div/a[@href=\"/Product\"]")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//li/a[@href=\"/Product\"]")));

            driver.FindElement(By.XPath("//a[@href=\"/Product/Edit?ProductId=2\"]")).Click();

            var productName = driver.FindElement(By.Id("ProductName")).GetAttribute("value");
            
            var categoryId = driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]//option[@value=\"1\"]")).GetAttribute("value");
           
            var supplierId = driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]//option[@value=\"1\"]")).GetAttribute("value");
           
            var unitPrice = driver.FindElement(By.Id("UnitPrice")).GetAttribute("value");
            
            var quantityPerUnit = driver.FindElement(By.Id("QuantityPerUnit")).GetAttribute("value");
            
            var unitsInStock = driver.FindElement(By.Id("UnitsInStock")).GetAttribute("value");
            
            var unitsOnOrder = driver.FindElement(By.Id("UnitsOnOrder")).GetAttribute("value");
           
            var reorderLevel = driver.FindElement(By.Id("ReorderLevel")).GetAttribute("value");

            Assert.AreEqual("Chang", productName);
            Assert.AreEqual("1", categoryId);
            Assert.AreEqual("1", supplierId);
            Assert.AreEqual("19,0000", unitPrice);
            Assert.AreEqual("24 - 12 oz bottles", quantityPerUnit);
            Assert.AreEqual("17", unitsInStock);
            Assert.AreEqual("40", unitsOnOrder);
            Assert.AreEqual("25", reorderLevel);

        }

        [Test]

        public void LogoutTest()
        {

            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.XPath("//li/a[@href=\"/Account/Logout\"]")).Click();
                             
            var text = driver.FindElement(By.TagName("h2")).Text;

            Assert.AreEqual("Login", text);
                
        }

        [TearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}