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

        #region link to login dialog and dialog elements
        public IWebElement LinkLoginDialog
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathLinkLoginDialog);
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
        #endregion

        // Tab to go to Progress main page
        public IWebElement TabProgressPage
        {
            get
            {
                return getElementByXPath(Resources.LandingXPathTabProgressPage);
            }
        }

        // Tab to go to BrainAQ Progress page
        public IWebElement TabAQPerformanceSummaryPage
        {
            get
            {
                return getElementByXPath(Resources.LandingXPathTabAQPerformanceSummaryPage);
            }
        }

        // Tab to go to Stars Progress page
        public IWebElement TabStarsPerformanceSummaryPage
        {
            get
            {
                return getElementByXPath(Resources.LandingXPathTabStarsPerformanceSummaryPage);
            }
        }

        // Tab to go to Levels Progress page
        public IWebElement TabLevelsPerformanceSummaryPage
        {
            get
            {
                return getElementByXPath(Resources.LandingXPathTabLevelsPerformanceSummaryPage);
            }
        }

        // Tab to go to Percentile Progress page
        public IWebElement TabPercentilePerformanceSummaryPage
        {
            get
            {
                return getElementByXPath(Resources.LandingXPathTabPercentilePerformanceSummaryPage);
            }
        }

    }
}
