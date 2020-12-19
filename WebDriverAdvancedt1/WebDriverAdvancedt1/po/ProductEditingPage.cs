using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.po
{
    class ProductEditingPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ProductEditingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement productName => driver.FindElement(By.Id("ProductName"));
        private IWebElement categoryId => driver.FindElement(By.Id("CategoryId"));
        private IWebElement supplierId => driver.FindElement(By.Id("SupplierId"));
        private IWebElement unitPrice => driver.FindElement(By.Id("UnitPrice"));
        private IWebElement quantityPerUnit => driver.FindElement(By.Id("QuantityPerUnit"));
        private IWebElement unitsInStock => driver.FindElement(By.Id("UnitsInStock"));
        private IWebElement unitsOnOrder => driver.FindElement(By.Id("UnitsOnOrder"));
        private IWebElement reorderLevel => driver.FindElement(By.Id("ReorderLevel"));
        private IWebElement categoryList => driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]//option[@value=\"1\"]"));
        private IWebElement supplierList => driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]//option[@value=\"1\"]"));
        private IWebElement clickButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));
        

        public void WriteFields(string path, string value)
        {
            driver.FindElement(By.Id(path)).Click();
            driver.FindElement(By.Id(path)).SendKeys(value);
        }

        public void WriteFields(string path)
        {
            driver.FindElement(By.XPath(path)).Click();
        }

        public AllProductsPage Return()
        {
            new Actions(driver).MoveToElement(clickButton).Click(clickButton).Build().Perform();
            return new AllProductsPage(driver);
        }
    }
}
