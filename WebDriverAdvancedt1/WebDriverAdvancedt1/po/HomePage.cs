using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.po
{
    class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        private IWebElement clickButton => driver.FindElement(By.LinkText("All Products"));

        public AllProductsPage GoTo()
        {

            new Actions(driver).MoveToElement(clickButton).Click().Build().Perform();
            //new Actions(driver).Click(clickButton).Build().Perform();
            return new AllProductsPage(driver);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".price__final")));
            //return finalPriceLabel.Text;
        }
    }
}
