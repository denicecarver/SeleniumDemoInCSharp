using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;

using selenium.shared;
using System.Globalization;

namespace selenium.site.brainhq.brainpage.homepage
{
    [TestClass()]
    public class LoginTests
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

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                //MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 

        [TestMethod]
        public void LogsIntoBrainHQ()
        {
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //Excel.Range range;

            //string str;
            //int rCnt = 0;
            //int cCnt = 0;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open("C:\\Source\\SeleniumDemoInCSharp\\BrainHQAutomation\\bin\\Debug\\BHQT.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //range = xlWorkSheet.UsedRange;

            //for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
            //{
            //    for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
            //    {
            //        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
            //        MessageBox.Show(str);
            //    }
            //}

            //xlWorkBook.Close(true, null, null);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open("C:\\Source\\SeleniumDemoInCSharp\\BrainHQAutomation\\bin\\Debug\\BHQT.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //MessageBox.Show(xlWorkSheet.get_Range("A1", "A1").Value2.ToString());

            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            //Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            //if (xlApp == null)
            //{
            //    MessageBox.Show("Excel is not properly installed!!");
            //    return;
            //}


            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //xlWorkSheet.Cells[1, 1] = "******************************************#######################################";

            //xlWorkBook.SaveAs("C:\\Source\\SeleniumDemoInCSharp\\BrainHQAutomation\\bin\\Debug\\BHQT.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            //MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");


            //try
            //{
            //    System.Data.OleDb.OleDbConnection MyConnection;
            //    System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
            //    string sql = null;
            //    MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='BHQTEST.xlsx';Extended Properties=Excel 8.0;");
            //    MyConnection.Open();
            //    myCommand.Connection = MyConnection;
            //    sql = "Insert into ['testvalsid'] (id,name) values('5','e')";
            //    myCommand.CommandText = sql;
            //    myCommand.ExecuteNonQuery();
            //    MyConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            ///// Setup the excel
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open(@"C:\Source\SeleniumDemoInCSharp\BrainHQAutomation\bin\Debug\BHQTEST.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
            ////Object tmp = xlWorkSheet.get_Range("A1");

            //xlWorkSheet.get_Range("A1", "A1").set_Value("Test xxx");
            
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);


            Thread.Sleep(180000);
            homePage.LinkLoginDialog.Click();

            /// TODO: Until encrypted DO NOT PUSH!!!
            /// TODO: Make it obvious that these next 3 commands are happening in login dialog
            homePage.TextFieldLoginEmailAddress.SendKeys("denicecarver.sf@gmail.com");
            homePage.TextFieldLoginPassword.SendKeys(CommonMethods.DecryptString("pNpPkneL2uwo4v6wRqMJNQ=="));
            homePage.ButtonLogin.Click();

            /// TODO: This requires a new child page - the landing page
            Thread.Sleep(10000);
            homePage.TabProgressPage.Click();
            homePage.TabPercentilePerformanceSummaryPage.Click();
            Thread.Sleep(500);

            // Percentile breakdown
            Debug.WriteLine("Percentile Breakdown:");
            int[] percentiles = homePage.getPercentiles();
            foreach (int perc in percentiles)
            {
                Debug.WriteLine(perc);
            }
            Thread.Sleep(500);

            // Improvement Breakdown
            Debug.WriteLine("Improvement Breakdown:");
            decimal[] improvements = homePage.getImprovements();
            foreach (decimal imp in improvements)
            {
                Debug.WriteLine(imp);
            }
            Debug.WriteLine("Overall Percentile Score: " + homePage.TextOverallPercentile.Text.Substring(0, 2));
            Debug.WriteLine("By Age Percentile Score: " + homePage.TextByAgePercentile.Text.Substring(0, 2));
            homePage.TabLevelsPerformanceSummaryPage.Click();
            Thread.Sleep(500);

            // Level count breakdown
            Debug.WriteLine("Level Count Breakdown:");
            int[] levels = homePage.getLevelCounts();
            foreach (int lvl in levels)
            {
                Debug.WriteLine(lvl);
            }
            homePage.TabStarsPerformanceSummaryPage.Click();
            Thread.Sleep(500);

            // Star count breakdown
            Debug.WriteLine("Star Count Breakdown:");
            int[] stars = homePage.getStarCounts();
            foreach (int star in stars)
            {
                Debug.WriteLine(star);
            }
            homePage.TabAQPerformanceSummaryPage.Click();
            Thread.Sleep(500);
            var brainAQScore = Decimal.Parse(homePage.TextBrainAQScore.Text, CultureInfo.CurrentCulture);

            Debug.WriteLine("BrainAQ: ");
            Debug.WriteLine(brainAQScore);
            Char[] splits = new Char[] {' ', '(', '%'};
            string[] output = homePage.TextBrainAQDeltaScores.Text.Split(splits);
            Boolean firstTimeIn = true;
            foreach (string outs in output)
            {
                Decimal mine;
                if (Decimal.TryParse(outs, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out mine)) {
                    if (firstTimeIn)
                    {
                        Debug.WriteLine("Improvement AQ: " + mine);
                        firstTimeIn = false;
                    }
                    else
                    {
                        Debug.WriteLine("Improvement change: " + mine);
                    }
                }
            }
        }

    }
}
