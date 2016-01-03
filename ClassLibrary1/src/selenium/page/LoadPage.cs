using System;

using OpenQA.Selenium;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace selenium.page
{
    public class LoadPage
    {
        public LoadPage(IWebDriver webDriver, string homePageUrl)
        {
            this.webDriver = webDriver;
            HomePageUrl = homePageUrl;
        }

        private IWebDriver webDriver;
        private static string HomePageUrl = null;

        protected void goToUrl()
        {
            goToUrl(HomePageUrl);
        }

        protected void goToUrl(string url)
        {
            try
            {
                webDriver.Navigate().GoToUrl(url);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.StackTrace);
            }
        }

        protected IWebElement getElementById(By mechanism)
        {
            return webDriver.FindElement(mechanism);
        }

        protected ReadOnlyCollection<IWebElement> getElementsById(By mechanism)
        {
            return webDriver.FindElements(mechanism);
        }

        protected string getTextByXPath(string elementXPath)
        {
            return getElementById(By.XPath(elementXPath)).Text;
        }

        public IWebElement getElementByXPath(string elementXPath)
        {
            return getElementById(By.XPath(elementXPath));
        }

        public ReadOnlyCollection<IWebElement> getElementsByXPath(string elementXPath)
        {
            return getElementsById(By.XPath(elementXPath));
        }

        protected IWebElement getElementByID(string elementID)
        {
            return getElementById(By.Id(elementID));
        }

        /// <summary>
        /// Provides a way for tests to determine current location
        /// </summary>
        /// <returns> string URL</returns>
        public string getCurrentUrl()
        {
            return webDriver.Url;
        }

        public void closeBrowser()
        {
            webDriver.Quit();
        }

    }
}
