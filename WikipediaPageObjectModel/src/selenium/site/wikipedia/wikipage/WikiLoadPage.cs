using System;

using OpenQA.Selenium;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace selenium.site.wikipedia.wikipage

{
    public class WikiLoadPage
    {
        public WikiLoadPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        private IWebDriver webDriver;

        private const string WikiOrgUrl = "https://www.wikipedia.org/";

        protected void goToUrl()
        {
            goToUrl(WikiOrgUrl);
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
        /// Method for test initialization
        /// </summary>
        public void goToWikiHomePage()
        {
            goToUrl();
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
