using OpenQA.Selenium;

using selenium.page;
using Resources = BrainHQPageObjectModel.Properties.Resources;

namespace selenium.site.brainhq.brainpage.homepage
{
    /// <summary> HomePage is a WikiLoadPage that carries the webdriver and has all other pages in the site
    /// The load page is tied to the driver and anything affect the overall testing environment.
    /// In the case of Wikipedia, the load page is the international home page:
    ///     HomePage -> is a -> WikiLoadPage
    /// The remaining pages are all "have a" relationships
    ///     WikiLoadPage -> has a -> WikiChildPage
    /// WikiChildPage is any page that the user goes to after the WikiLoadPage so all child pages
    /// like the ResultsPage are members of the HomePage
    /// </summary>
    public class HomePage : LoadPage
    {
        public HomePage(IWebDriver webDriver)
            : base(webDriver, Resources.HomePageUrl)
        {
        }

        /// <summary>
        /// Method for test initialization
        /// </summary>
        public void goToBrainHomePage()
        {
            goToUrl();
        }

        public IWebElement LinkLoginDialog
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathLinkLoginDialog);
            }
        }

        public IWebElement TabProgressPage
        {
            get
            {
                return getElementByXPath(Resources.LandingXPathTabProgressPage);
            }
        }

        public IWebElement TextFieldLoginEmailAddress
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathTextLoginEmailAddress);
            }
        }

        public IWebElement TextFieldLoginPassword
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathTextLoginPassword);
            }
        }

        public IWebElement ButtonLogin
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathButtonLogin);
            }
        }

    }
}
