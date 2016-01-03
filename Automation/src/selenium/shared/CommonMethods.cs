
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Data.SQLite;

namespace selenium.shared
{
    public static class CommonMethods
    {

        public static IWebDriver WebDriver = new FirefoxDriver();
        public static string ConnectionString = "data source=C:\\Source\\SeleniumDemoInCSharp\\WikipediaAutomation\\sitedata\\wikipedia\\wikidata.db";

        #region Error Handling
        public static string FormatAssertMessage(string expectedResult, string actualResult)
        {
            return "\n\tExpected Value: " + expectedResult +
                    "\n\tActual Value:  " + actualResult;
        }

        public static string FormatAssertMessage(string expectedResult, string actualResult, string id)
        {
            return "\n\tExpected Value: " + expectedResult +
                    "\n\tActual Value:  " + actualResult +
                    "\n\tID of dataItem:  " + id;
        }

        public static string GetUniqueStringFromCurrentMilliseconds()
        {
            string tmp = System.DateTime.Now.ToUniversalTime().ToString();
            return System.DateTime.Now.ToUniversalTime().ToString();//"yyyyMMddHHmmss"
            //Calendar cal = Calendar.getInstance(TimeZone.getTimeZone("UTC"));
            //return Long.toString(cal.getTimeInMillis());
        }

        public static void GetUniqueScreenshot(string filenameNoExtension)
        {
            //getScreenshot(filenameNoExtension + CommonMethods.getUniqueStringFromCurrentMilliseconds());
        }

        public static void GetScreenshot(string filenameNoExtension)
        {
            //WebDriver augmentedDriver = new Augmenter().augment(webDriver);
            //File screenshot = ((TakesScreenshot)augmentedDriver).
            //        getScreenshotAs(OutputType.FILE);
            //try
            //{
            //    Debug.WriteLine(WikiPageText.getString("AnyPage.ErrorImagePath") + filenameNoExtension + ".png");
            //    FileUtils.copyFile(screenshot, new File(WikiPageText.getString("AnyPage.ErrorImagePath") + filenameNoExtension + ".png"));
            //}
            //catch (IOException e)
            //{
            //    Debug.WriteLine(e.StackTrace);
            //}
        }
        #endregion

        //public static void CreateLanguageLinkDataTable()
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
        //    {
        //        using (SQLiteCommand cmd = new SQLiteCommand())
        //        {
        //            cmd.Connection = conn;
        //            conn.Open();

        //            SQLiteHelper sh = new system.data.sqlitehelper.SQLiteHelper(cmd);
        //            SQLiteTable tb = new SQLiteTable("LanguageLinkData");

        //            tb.Columns.Add(new SQLiteColumn("id", true));
        //            tb.Columns.Add(new SQLiteColumn("pageid"));
        //            tb.Columns.Add(new SQLiteColumn("class"));
        //            tb.Columns.Add(new SQLiteColumn("lang"));
        //            tb.Columns.Add(new SQLiteColumn("dir"));
        //            tb.Columns.Add(new SQLiteColumn("dataconverthans"));
        //            tb.Columns.Add(new SQLiteColumn("title"));
        //            tb.Columns.Add(new SQLiteColumn("href"));
        //            tb.Columns.Add(new SQLiteColumn("text"));

        //            sh.CreateTable(tb);

        //            conn.Close();
        //        }
        //    }
        //}

        //public static void LoadLanguageLinkData(ReadOnlyCollection<IWebElement> weListPrimary)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
        //    {
        //        using (SQLiteCommand cmd = new SQLiteCommand())
        //        {
        //            cmd.Connection = conn;
        //            conn.Open();

        //            SQLiteHelper sh = new SQLiteHelper(cmd);
        //            SQLiteTable tb = new SQLiteTable("LanguageLinkData");

        //            //Debug.WriteLine(sh.ExecuteScalar("select Title from ResultLanguageLinks;"));
        //            Debug.WriteLine("============================================");
        //            foreach (IWebElement we in weListPrimary)
        //            {
        //                var dic = new Dictionary<string, object>();
        //                dic["class"] = we.GetAttribute("class");
        //                dic["lang"] = we.GetAttribute("lang");
        //                dic["dir"] = we.GetAttribute("dir");
        //                dic["dataconverthans"] = we.GetAttribute("data-convert-hans");
        //                dic["title"] = we.GetAttribute("title");
        //                dic["href"] = we.GetAttribute("href");
        //                dic["Text"] = we.Text;
        //                sh.Insert("LanguageLinkData", dic);

        //                Debug.WriteLine("id=" + we.GetAttribute("id"));
        //                Debug.WriteLine("class=" + we.GetAttribute("class"));
        //                Debug.WriteLine("lang=" + we.GetAttribute("lang"));
        //                Debug.WriteLine("dir=" + we.GetAttribute("dir"));
        //                Debug.WriteLine("dataconverthans=" + we.GetAttribute("data-convert-hans"));
        //                Debug.WriteLine("title=" + we.GetAttribute("title"));
        //                Debug.WriteLine("href=" + we.GetAttribute("href"));
        //                Debug.WriteLine("Text=" + we.Text);
        //                Debug.WriteLine("============================================");
        //            }

        //            conn.Close();
        //        }
        //    }
        //}

    }
}