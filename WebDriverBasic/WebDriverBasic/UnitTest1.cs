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

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            var adress = driver.Url;
            var tittle = driver.FindElement(By.TagName("h2")).Text;
            var image = driver.FindElement(By.TagName("img")).GetAttribute("src");
            Assert.AreEqual("http://localhost:5000/", adress);
            Assert.AreEqual("Home page", tittle);
            Assert.AreEqual("http://localhost:5000/images/logo.jpg", image);

        }

        [Test]
        public void Test2()
        {
            driver.Url = "http://localhost:5000/Product";
            Assert.AreNotEqual("http://localhost:5000/", driver.Url);
            Assert.AreNotEqual("http://localhost:5000/Account/Login?ReturnUrl=%2F", driver.Url);

            driver.FindElement(By.LinkText("Create new")).Click();

            driver.FindElement(By.Id("ProductName")).Click();
            driver.FindElement(By.Id("ProductName")).SendKeys("Chang chang");

            driver.FindElement(By.Id("CategoryId")).Click();
            driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]//option[@value=\"1\"]")).Click();

            driver.FindElement(By.Id("SupplierId")).Click();
            driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]//option[@value=\"1\"]")).Click();

            driver.FindElement(By.Id("UnitPrice")).Click();
            driver.FindElement(By.Id("UnitPrice")).SendKeys("20");

            driver.FindElement(By.Id("QuantityPerUnit")).Click();
            driver.FindElement(By.Id("QuantityPerUnit")).SendKeys("24 - 12 oz bottles");

            driver.FindElement(By.Id("UnitsInStock")).Click();
            driver.FindElement(By.Id("UnitsInStock")).SendKeys("17");

            driver.FindElement(By.Id("UnitsOnOrder")).Click();
            driver.FindElement(By.Id("UnitsOnOrder")).SendKeys("0");

            driver.FindElement(By.Id("ReorderLevel")).Click();
            driver.FindElement(By.Id("ReorderLevel")).SendKeys("0");

            driver.FindElement(By.CssSelector(".btn")).Click();
            Assert.AreEqual("http://localhost:5000/Product", driver.Url);

        }

        [Test]
        public void Test3()
        {
            driver.FindElement(By.LinkText("Chang chang")).Click();

            var a2 = driver.FindElement(By.Id("ProductName")).GetAttribute("value");
            Assert.AreEqual("Chang chang", a2);

            var a3 = driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]//option[@value=\"1\"]")).GetAttribute("value");
            Assert.AreEqual("1", a3);

            var a4 = driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]//option[@value=\"1\"]")).GetAttribute("value");
            Assert.AreEqual("1", a3);

            var a5 = driver.FindElement(By.Id("UnitPrice")).GetAttribute("value");
            Assert.AreEqual("20", a5);

            var a6 = driver.FindElement(By.Id("QuantityPerUnit")).GetAttribute("value");
            Assert.AreEqual("24 - 12 oz bottles", a6);

            var a7 = driver.FindElement(By.Id("UnitsInStock")).GetAttribute("value");
            Assert.AreEqual("17", a7);

            var a8 = driver.FindElement(By.Id("UnitsOnOrder")).GetAttribute("value");
            Assert.AreEqual("0", a8);

            var a9 = driver.FindElement(By.Id("ReorderLevel")).GetAttribute("value");
            Assert.AreEqual("0", a9);
        }

        [Test]

        public void Test4()
        {
            driver.Url = "http://localhost:5000/Account/Login?ReturnUrl=%2F";

            var a10 = driver.FindElement(By.XPath("//lable[@for=\"Name\"]")).GetAttribute("for");
            Assert.AreEqual("Name", a10);

            var a11 = driver.FindElement(By.XPath("//lable[@for=\"Password\"]")).GetAttribute("for");
            Assert.AreEqual("Password", a11);


        }

        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}