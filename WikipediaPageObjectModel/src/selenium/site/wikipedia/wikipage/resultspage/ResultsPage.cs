using OpenQA.Selenium;

using selenium.page;

using Resources = WikipediaPageObjectModel.Properties.Resources;

namespace selenium.site.wikipedia.resultspage
{
    public class ResultsPage : ChildPage
    {
        public ResultsPage(LoadPage wikiPage)
            : base(wikiPage)
        {

        }

        #region Result Page Elements
        public IWebElement ErrorMsg
        {
            get
            {
                return loadPage.getElementByXPath(Resources.ResultsXPathSpecialError);
            }
        }

        public IWebElement PageRedirectClass
        {
            get
            {
                return loadPage.getElementByXPath(Resources.ResultsXPathSearchRedirectClass);
            }
        }

        public IWebElement ErrorPageTitle
        {
            get
            {
                return loadPage.getElementByXPath(Resources.ResultsXPathSearchFailureHeader);
            }
        }
        #endregion

    }
}
