using OpenQA.Selenium;

using selenium.site.wikipedia.resultspage;
using Resources = WikipediaPageObjectModel.Properties.Resources;

namespace selenium.site.wikipedia.wikipage.homepage
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
    public class HomePage : WikiLoadPage
    {
        public HomePage(IWebDriver webDriver)
            : base(webDriver)
        {
        }
        private ResultsPage resultsPage = null;
        public ResultsPage ResultsPage
        {
            get
            {
                return resultsPage;
            }
            set
            {
                resultsPage = ResultsPage;
            }
        }

        #region Central Logo Elements
        public IWebElement LinkCentralLogoChinese
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoChinese);
            }
        }

        public IWebElement LinkCentralLogoEnglish
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoEnglish);
            }
        }

        public IWebElement LinkCentralLogoFrench
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoFrench);
            }
        }

        public IWebElement LinkCentralLogoGerman
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoGerman);
            }
        }

        public IWebElement LinkCentralLogoItalian
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoItalian);
            }
        }

        public IWebElement LinkCentralLogoJapanese
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoJapanese);
            }
        }

        public IWebElement LinkCentralLogoPolish
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoPolish);
            }
        }

        public IWebElement LinkCentralLogoPortuguese
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoPortuguese);
            }
        }

        public IWebElement LinkCentralLogoRussian
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoRussian);
            }
        }

        public IWebElement LinkCentralLogoSpanish
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoSpanish);
            }
        }

        public IWebElement SearchResultsHeading
        {
            get
            {
                return getElementByXPath(Resources.ResultsXPathSearchResultClass);
            }
        }

        public IWebElement TitleCentralLogo
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathCentralLogoTitle);
            }
        }
        #endregion

        #region Search Form Elements
        public IWebElement SearchGoButton
        {
            get
            {
                return getElementByXPath(Resources.HomeXPathSearchButton);
            }

        }

        public IWebElement SearchTextField
        {
            get
            {
                return getElementByID(Resources.HomeIDSearchFormTextField);
            }
        }

        public IWebElement SearchErrorMsgText
        {
            get
            {
                return getElementByXPath(Resources.ResultsXPathSpecialError);
            }
        }
        #endregion

    }
}
