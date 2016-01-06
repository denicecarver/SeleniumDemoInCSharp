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
        public void goesToChineseLandingPageFromCentralLogoLink()
        {
            // Click on the Chinese link next to the Central Logo
            // that leads to the Chinese landing page
            homePage.LinkCentralLogoChinese.Click();

            // Get the actual URL of the Chinese landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Chinese landing page
            string expectedResult = HomePageTestResources.HomePageLinkToChineseLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://zh.wikipedia.org/wiki/Wikipedia:%E9%A6%96%E9%A1%B5
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        // This test goes to the English landing page from the central logo link and
        // verifies the URL is correct
        [TestMethod]
        public void goesToEnglishLandingPageFromCentralLogoLink()
        {
            // Click on the English link next to the Central Logo
            // that leads to the English landing page
            homePage.LinkCentralLogoEnglish.Click();

            // Get the actual URL of the English landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the English landing page
            // https://en.wikipedia.org/wiki/Main_Page
            string expectedResult =
                HomePageTestResources.HomePageLinkToEnglishLandingPage;

            // Compare actual and expected URLs, noting details if the test fails
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToFrenchLandingPageFromCentralLogo()
        {
            // Click on the French link next to the Central Logo
            // that leads to the French landing page
            homePage.LinkCentralLogoFrench.Click();

            // Get the actual URL of the French landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the French landing page
            string expectedResult = HomePageTestResources.HomePageLinkToFrenchLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://fr.wikipedia.org/wiki/Wikip%C3%A9dia:Accueil_principal
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToGermanLandingPageFromCentralLogo()
        {
            // Click on the German link next to the Central Logo
            // that leads to the English landing page
            homePage.LinkCentralLogoGerman.Click();

            // Get the actual URL of the German landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the German landing page
            string expectedResult = HomePageTestResources.HomePageLinkToGermanLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://de.wikipedia.org/wiki/Wikipedia:Hauptseite
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToItalianLandingPageFromCentralLogo()
        {
            // Click on the Italian link next to the Central Logo
            // that leads to the Italian landing page
            homePage.LinkCentralLogoItalian.Click();

            // Get the actual URL of the Italian landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Italian landing page
            string expectedResult = HomePageTestResources.HomePageLinkToItalianLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://it.wikipedia.org/wiki/Pagina_principale
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToJapaneseLandingPageFromCentralLogo()
        {
            // Click on the Japanese link next to the Central Logo
            // that leads to the Japanese landing page
            homePage.LinkCentralLogoJapanese.Click();

            // Get the actual URL of the Japanese landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Japanese landing page
            string expectedResult = HomePageTestResources.HomePageLinkToJapaneseLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // "https://ja.wikipedia.org/wiki/%E3%83%A1%E3%82%A4%E3%83%B3%E3%83%9A%E3%83%BC%E3%82%B8"
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPolishLandingPageFromCentralLogo()
        {
            // Click on the Polish link next to the Central Logo
            // that leads to the Polish landing page
            homePage.LinkCentralLogoPolish.Click();

            // Get the actual URL of the Polish landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Polish landing page
            string expectedResult = HomePageTestResources.HomePageLinkToPolishLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToPortugueseLandingPageFromCentralLogoLink()
        {
            // Click on the Portuguese link next to the Central Logo
            // that leads to the Portuguese landing page
            homePage.LinkCentralLogoPortuguese.Click();

            // Get the actual URL of the Portuguese landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Portuguese landing page
            string expectedResult = HomePageTestResources.HomePageLinkToPortugueseLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://pt.wikipedia.org/wiki/Wikip%C3%A9dia:P%C3%A1gina_principal
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToRussianLandingPageFromCentralLogoLink()
        {
            // Click on the Russian link next to the Central Logo
            // that leads to the Russian landing page
            homePage.LinkCentralLogoRussian.Click();

            // Get the actual URL of the Russian landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Russian landing page
            string expectedResult = HomePageTestResources.HomePageLinkToRussianLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://ru.wikipedia.org/wiki/%D0%97%D0%B0%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D1%81%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }

        [TestMethod]
        public void goesToSpanishLandingPageFromCentralLogoLink()
        {
            // Click on the Spanish link next to the Central Logo
            // that leads to the Spanish landing page
            homePage.LinkCentralLogoSpanish.Click();

            // Get the actual URL of the Spanish landing page
            string actualResult = homePage.getCurrentUrl();

            // Get the expected URL for the Spanish landing page
            string expectedResult = HomePageTestResources.HomePageLinkToSpanishLandingPage;

            // Compare actual and expected URLs, noting details if test fails
            // https://es.wikipedia.org/wiki/Wikipedia:Portada
            Assert.IsTrue(actualResult.Equals(expectedResult),
                    CommonMethods.FormatAssertMessage(expectedResult, actualResult));
        }
        #endregion

    }
}
