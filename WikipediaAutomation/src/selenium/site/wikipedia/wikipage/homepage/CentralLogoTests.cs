using Microsoft.VisualStudio.TestTools.UnitTesting;

using selenium.shared;
using HomePageTestResources = WikipediaAutomation.Properties.Resources;

namespace selenium.site.wikipedia.wikipage.homepage.Tests
{
    [TestClass()]
    public class CentralLogoTests
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
            homePage.goToWikiHomePage();
        }

        [ClassCleanup]
        public static void teardown()
        {
            homePage.closeBrowser();
        }
        #endregion

        #region Central Logo Items Exist Testing
        [TestMethod]
        public void isWikipediaLogoFound()
        {
            // Is found if the logo element with title attribute 'Wikipedia' is found
            Assert.IsNotNull(homePage.TitleCentralLogo);
        }

        [TestMethod]
        public void isChineseLinkFound()
        {
            // Is found if the Chinese link exists
            Assert.IsNotNull(homePage.LinkCentralLogoChinese);
        }

        [TestMethod]
        public void isEnglishLinkFound()
        {
            // Is found if the English link exists
            Assert.IsNotNull(homePage.LinkCentralLogoEnglish);
        }

        [TestMethod]
        public void isFrenchLinkFound()
        {
            // Is found if the French link exists
            Assert.IsNotNull(homePage.LinkCentralLogoFrench);
        }

        [TestMethod]
        public void isGermanLinkFound()
        {
            // Is found if the Spanish link exists
            Assert.IsNotNull(homePage.LinkCentralLogoGerman);
        }

        [TestMethod]
        public void isItalianLinkFound()
        {
            // Is found if the Japanese link exists
            Assert.IsNotNull(homePage.LinkCentralLogoItalian);
        }

        [TestMethod]
        public void isJapaneseLinkFound()
        {
            // Is found if the Russian link exists
            Assert.IsNotNull(homePage.LinkCentralLogoJapanese);
        }

        [TestMethod]
        public void isPolishLinkFound()
        {
            // Is found if the German link exists
            Assert.IsNotNull(homePage.LinkCentralLogoPolish);
        }

        [TestMethod]
        public void isPortugueseLinkFound()
        {
            // Is found if the Italian link exists
            Assert.IsNotNull(homePage.LinkCentralLogoPortuguese);
        }

        [TestMethod]
        public void isRussianLinkFound()
        {
            // Is found if the Polish link exists
            Assert.IsNotNull(homePage.LinkCentralLogoRussian);
        }

        [TestMethod]
        public void isSpanishLinkFound()
        {
            // Is found if the Portuguese link exists
            Assert.IsNotNull(homePage.LinkCentralLogoSpanish);
        }
        #endregion

        #region Central Logo Links Testing
        [TestMethod]
        public void goesToChineseWikiFromCentralLogoLink()
        {
            // Click on the Chinese link
            homePage.LinkCentralLogoChinese.Click();

            // Get the actual URL after clicking on the Chinese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Chinese link
            string expectedResult = HomePageTestResources.HomePageURLChinese;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToEnglishWikiFromCentralLogoLink()
        {
            // Click on the English link
            homePage.LinkCentralLogoEnglish.Click();

            // Get the actual URL after clicking on the English link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the English Wiki Home page
            string expectedResult = HomePageTestResources.HomePageURLEnglish;

            // Compare actual and expected URLs
            // (uses contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToFrenchWikiFromCentralLogo()
        {
            // Click on the French link
            homePage.LinkCentralLogoFrench.Click();

            // Get the actual URL after clicking on the French link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the French link
            string expectedResult = HomePageTestResources.HomePageURLFrench;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToGermanWikiFromCentralLogo()
        {
            // Click on the German link
            homePage.LinkCentralLogoGerman.Click();

            // Get the actual URL after clicking on the German link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the German link
            string expectedResult = HomePageTestResources.HomePageURLGerman;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToItalianWikiFromCentralLogo()
        {
            // Click on the Italian link
            homePage.LinkCentralLogoItalian.Click();

            // Get the actual URL after clicking on the Italian link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Italian link
            string expectedResult = HomePageTestResources.HomePageURLItalian;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToJapaneseWikiFromCentralLogo()
        {
            // Click on the Japanese link
            homePage.LinkCentralLogoJapanese.Click();

            // Get the actual URL after clicking on the Japanese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Japanese link
            string expectedResult = HomePageTestResources.HomePageURLJapanese;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPolishWikiFromCentralLogo()
        {
            // Click on the Polish link
            homePage.LinkCentralLogoPolish.Click();

            // Get the actual URL after clicking on the Polish link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Polish link
            string expectedResult = HomePageTestResources.HomePageURLPolish;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPortugueseWikiFromCentralLogoLink()
        {
            // Click on the Portuguese link
            homePage.LinkCentralLogoPortuguese.Click();

            // Get the actual URL after clicking on the Portuguese link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Portuguese link
            string expectedResult = HomePageTestResources.HomePageURLPortuguese;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToRussianWikiFromCentralLogoLink()
        {
            // Click on the Russian link
            homePage.LinkCentralLogoRussian.Click();

            // Get the actual URL after clicking on the Russian link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Russian link
            string expectedResult = HomePageTestResources.HomePageURLRussian;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToSpanishWikiFromCentralLogoLink()
        {
            // Click on the Spanish link
            homePage.LinkCentralLogoSpanish.Click();

            // Get the actual URL after clicking on the Spanish link
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Spanish link
            string expectedResult = HomePageTestResources.HomePageURLSpanish;

            // Compare actual and expected URLs
            // (use contains instead of equals in test because landing page may not be homepage for a language)
            Assert.IsTrue(actualResult.Contains(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }
        #endregion

    }
}
