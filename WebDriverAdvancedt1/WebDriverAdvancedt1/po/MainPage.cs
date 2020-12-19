using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebDriverAdvanced.po
{
    class MainPage
    {
        private IWebDriver driver;
        // //div/a[@href="/Product"]

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement inputName => driver.FindElement(By.Id("Name"));
        private IWebElement inputPassword => driver.FindElement(By.Id("Password"));
        private IWebElement clickButton => driver.FindElement(By.CssSelector(".btn"));

        public HomePage WriteFields(string nm, string pw)
        {

            new Actions(driver).SendKeys(inputName, nm).Build().Perform();

            new Actions(driver).SendKeys(inputPassword, pw).Build().Perform();

            new Actions(driver).MoveToElement(clickButton).Click(clickButton).Build().Perform();

            return new HomePage(driver);
            // inputName.SendKeys(nm);
            // inputPassword.SendKeys(pw);
            // clickButton.Click();
        }
    }
}
