using Microsoft.VisualStudio.TestTools.UnitTesting;

using selenium.site.shared;
using selenium.site.wikipedia.resultspage;

using TestDataResources = WikipediaAutomation.Properties.Resources;

namespace selenium.site.wikipedia.wikipage.homepage.Tests
{
    [TestClass()]
    public class SearchFormTests
    {

        #region private members
        //global for the test run
        private static TestContext testContextInstance;
        private static HomePage homePage = new HomePage(CommonMethods.webDriver);
        private static ResultsPage resultsPage = new ResultsPage(homePage);
        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Initialisation and cleanup
        /// <summary>
        /// Executes once before the test-suite
        /// </summary>
        [ClassInitialize]
        public static void setup(TestContext testContext)
        {
            testContextInstance = testContext;
        }

        [TestInitialize]
        public void setupForTest()
        {
            homePage.goToWikiHomePage();
        }

        /// <summary>
        /// Executes once at the end of the test-suite
        /// </summary>
        [ClassCleanup]
        public static void teardown()
        {
            homePage.closeBrowser();
        }
        #endregion

        [TestMethod]
        public void searchForValidTerm()
        {
            // Enter a valid string into the Search field for most basic validation
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchValidTerm);

            // Click go button
            homePage.SearchGoButton.Click();

            // Get actual URL for valid term
            string actualResult = homePage.getCurrentUrl();

            // Get expected URL for valid term
            string expectedResult = TestDataResources.HomeSearchValidTermURL;

            // Compare with expected error msg value
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForRedirectTerm()
        {
            // Enter an empty string into the Search field to assure the field is blank
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchRedirectTerm);

            // Click go button
            homePage.SearchGoButton.Click();

            // Look for Redirect text
            string actualResult = resultsPage.PageRedirectClass.Text.Trim();

            // Get the expected URL for landing on the special page
            string expectedResult = TestDataResources.HomeSearchRedirectText;

            // Compare with expected error msg value
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForBlankTerm()
        {
            // Enter an empty string into the Search field to assure the field is blank
            homePage.SearchTextField.SendKeys("");

            // Click go button
            homePage.SearchGoButton.Click();

            // Get URL at search result page when search term doesn't exist
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for landing on the special page
            string expectedResult = TestDataResources.SpecialPageURL;

            // Compare with expected error msg value
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForLeftCurlyBracket()
        {
            // Enter a left curly bracket into the search field
            string tmpo = TestDataResources.HomeSearchTermLeftCurlyBracket;
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchTermLeftCurlyBracket);

            // Click go button
            homePage.SearchGoButton.Click();

            // Get error msg at search result page
            string actualResult = homePage.SearchResultsHeading.Text;

            // Get the expected search result heading after search
            string expectedResult = TestDataResources.HomeSearchLeftCurlyBracketResult;

            // Compare with expected error msg value
            Assert.AreEqual(actualResult, expectedResult,
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForOutOfBoundsTerm()
        {
            // Enter a term that exceeds the length limit for a URL
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchTermOutOfBounds);

            // Click go button
            homePage.SearchGoButton.Click();

            // Get error msg at search result page
            string actualResult = resultsPage.ErrorPageTitle.Text;

            // Get the expected search result heading after search
            string expectedResult = TestDataResources.HomeSearchFailureText;

            // Compare with expected error msg value
            Assert.AreEqual(actualResult, expectedResult,
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void searchForTooLongTerm()
        {
            // Enter a term that exceeds the length limit for a search item into the search field
            homePage.SearchTextField.SendKeys(TestDataResources.HomeSearchTermExceedsLengthLimit);

            // Click go button
            homePage.SearchGoButton.Click();

            // Get error msg at search result page
            string actualResult = resultsPage.ErrorMsg.Text;

            // Compare with expected error msg value
            Assert.AreEqual(actualResult, TestDataResources.ErrorMsgExceedsLengthLimit);
        }

    }
}