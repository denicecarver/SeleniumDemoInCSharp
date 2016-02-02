using Microsoft.VisualStudio.TestTools.UnitTesting;

using selenium.shared;

namespace selenium.site.brainhq.brainpage.homepage
{
    [TestClass()]
    public class HeaderBarTests
    {

        #region private members
        //global for the test run
        private static TestContext context;
        private static HomePage homePage = new HomePage(CommonMethods.WebDriver);
        #endregion

        #region Initialisation and cleanup
        [ClassInitialize]
        public static void setup(TestContext testContext)
        {
            context = testContext;
        }

        [TestInitialize]
        public void setForNextTest()
        {
            homePage.goToBrainHomePage();
        }

        [ClassCleanup]
        public static void teardown()
        {
            homePage.closeBrowser();
        }
        #endregion

        [TestMethod]
        public void goesToProgressPage()
        {
            homePage.TabProgressPage.Click();
        }

    }
}
