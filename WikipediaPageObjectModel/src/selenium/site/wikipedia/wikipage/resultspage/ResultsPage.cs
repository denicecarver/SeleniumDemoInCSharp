using OpenQA.Selenium;

using selenium.site.wikipedia.wikipage;

using Resources = WikipediaPageObjectModel.Properties.Resources;

namespace selenium.site.wikipedia.resultspage
{
    public class ResultsPage : WikiChildPage
    {
        public ResultsPage(WikiLoadPage wikiPage)
            : base(wikiPage)
        {

        }

        #region Result Page Elements
        public IWebElement ErrorMsg
        {
            get
            {
                return wikiPage.getElementByXPath(Resources.ResultsXPathSpecialError);
            }
        }

        public IWebElement PageRedirectClass
        {
            get
            {
                return wikiPage.getElementByXPath(Resources.ResultsXPathSearchRedirectClass);
            }
        }

        public IWebElement ErrorPageTitle
        {
            get
            {
                return wikiPage.getElementByXPath(Resources.ResultsXPathSearchFailureHeader);
            }
        }
        #endregion

    }
}
