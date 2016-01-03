using OpenQA.Selenium;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using selenium.shared;

namespace selenium.site.wikipedia.wikipage.homepage.Tests
{
    /// <summary>
    /// Summary description for LanguageLinksDataTests
    /// </summary>
    [TestClass]
    public class LanguageLinksDataTests
    {
        public LanguageLinksDataTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region private members
        //global for the test run
        private static TestContext testContextInstance;
        private static HomePage homePage = new HomePage(CommonMethods.WebDriver);
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
        [ClassInitialize]
        public static void setup(TestContext testContext)
        {
            testContextInstance = testContext;
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


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        //[TestMethod]
        //public void createLanguageLinksTable()
        //{
        //    CommonMethods.CreateLanguageLinkDataTable();
        //}

        //[TestMethod]
        //public void loadLanguageLinks()
        //{
        //    ReadOnlyCollection<IWebElement> webElementListPrimary = homePage.getElementsByXPath(".//*[@id='www-wikipedia-org']/div/ul/li/a");
        //    CommonMethods.LoadLanguageLinkData(webElementListPrimary);
        //    ReadOnlyCollection<IWebElement> webElementListSecondary = homePage.getElementsByXPath(".//*[@id='www-wikipedia-org']/div/ul/li/a/span");
        //    CommonMethods.LoadLanguageLinkData(webElementListSecondary);
        //    ReadOnlyCollection<IWebElement> webElementListTertiary = homePage.getElementsByXPath(".//*[@id='www-wikipedia-org']/div/ul/li/a/bdi");
        //    CommonMethods.LoadLanguageLinkData(webElementListTertiary);
        //}

        //[TestMethod]
        //[DataSource("Provider=OleSQLite.SQLiteSource; Data Source=wikidata.db;")]
        //public void goToURLS() {
        //    var temp = TestContext.DataRow[0];
        //    temp.ToString();
        //}
        
    }
}
