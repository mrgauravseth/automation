using NUnit.Framework;
using System;
using Selenium;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using log4net;
using log4net.Config;
using System.IO;

namespace Automation_Framework.Code
{
    [Binding]
    class GeneralBindings
    {
        string SCREENSHOT_PATH = System.AppDomain.CurrentDomain.BaseDirectory + @"\Screens";
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(GeneralBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        public enum SearchElementBy
        {
            ID,
            NAME,
            TEXT,
            XPATH,
            CSS,
            CLASS,
            DOM,
        };

               static GeneralBindings()
               {
                   XmlConfigurator.Configure(new System.IO.FileInfo(@"..\..\Config\log.xml"));
               }

               public static void LogResult(bool passed, string message, string element)
               {
                   resultsLog.InfoFormat((passed ? "Pass" : "Fail") + ", {0}, {1}", message,element);
               }

               [BeforeFeature]
               public static void PrintFeatureTitle()
               {
                   debugLog.Debug("Feature title: " + FeatureContext.Current.FeatureInfo.Title);
                   resultsLog.DebugFormat("-----Feature------->{0}", FeatureContext.Current.FeatureInfo.Title);
               }

               [BeforeScenario]
               public static void PrintScenarioTitle()
               {
                   debugLog.Debug("Scenario title: " + ScenarioContext.Current.ScenarioInfo.Title);
                   resultsLog.DebugFormat("-----Scenario-------->{0}", ScenarioContext.Current.ScenarioInfo.Title);
               }


               [BeforeStep]
               public static void SleepBeforeStep()
               {
                   System.Threading.Thread.Sleep(1000);
               }

               [When(@"user waits '(.*)' second.?")]
               [Then(@"user waits '(.*)' second.?")]
               public static void UserWaitsSeconds(int wait)
               {
                   debugLog.DebugFormat("UserWaits(wait={0})", wait);
                   while (wait > 0)
                   {
                       wait--;
                       System.Threading.Thread.Sleep(1000);
                   }
               }

               [Given(@"user blinks")]
               [When(@"user blinks")]
               [Then(@"user blinks")]
               public static void UserBlinks()
               {
                   debugLog.Debug("UserBlinks()");

                   System.Threading.Thread.Sleep(1000);
               }

               [When(@"user waits '(.*)' millisecond.?")]
               [Then(@"user waits '(.*)' millisecond.?")]
               public static void UserWaitsMilliseconds(int wait)
               {
                   debugLog.DebugFormat("UserWaitsMilliseconds(wait={0})", wait);
                   System.Threading.Thread.Sleep(wait);
               }

               [When(@"user takes Screenshot")]
               public static void Screenshots()
               {
                   SaveScreenShot(ScenarioContext.Current.ScenarioInfo.Title);
               }

               private static void SaveScreenShot(string screenshotFirstName)
               {
                   debugLog.DebugFormat("SaveScreenShot()");
                  // var folderLocation = Environment.CurrentDirectory.Replace("Debug", "\\ScreenShot\\");
                   string folderLocation = @"C:\Logs\Screenshots\";
                   try
                   {
                       if (!Directory.Exists(folderLocation))
                       {
                           Directory.CreateDirectory(folderLocation);
                       }
                   }
                   catch (DirectoryNotFoundException e)
                   {
                       Assert.Fail("Screenshot directory not present");
                   }
                   var screenshot = ((ITakesScreenshot)WebBrowser.Current).GetScreenshot();
                   var filename = new StringBuilder(folderLocation);
                   filename.Append(screenshotFirstName);
                   filename.Append(DateTime.Now.ToString("dd-MM-yyyy HH_mm_ss"));
                   filename.Append(".png");
                   debugLog.DebugFormat("the value is {0}",filename);
                   screenshot.SaveAsFile(filename.ToString(), System.Drawing.Imaging.ImageFormat.Png);
               }

               [Given(@"I am on the site '(.*)'")]
               [When(@"I am on the site '(.*)'")]
               [Then(@"I am on the site '(.*)'")]
               public void OpenThisURL(string urltotarget)
               {
                   debugLog.DebugFormat("OpenThisURL()");
                   //Check that the Title is what we are expecting
                   WebBrowser.OpenSite(urltotarget);
                   GeneralBindings.LogResult(true, "Opening URL ->", urltotarget);

               }

               [Then(@"I should see the site title as '(.*)'")]
               public void CheckSiteTitle(string title)
               {
                   debugLog.DebugFormat("CheckSiteTitle()");
                   WebBrowser.Current.WaitForPageToLoad();
                   Assert.AreEqual(title, WebBrowser.Current.Title);
                   GeneralBindings.LogResult(true, "Site Title is found ->  ", title);
               }

             
               [Then(@"i close the Site")]
               public void CloseWebSite()
               {
                   debugLog.DebugFormat("CloseWebSite()");
                   WebBrowser.Current.Quit();
                   WebBrowser.Current.Dispose();
                   GeneralBindings.LogResult(true, "Site has been closed successfully", "");
               }

               public static void CheckStringAndLogresult(string Message, string expected, string actual)
               {
                   if (expected.Equals(actual))
                   {
                       GeneralBindings.LogResult(true, Message, actual);
                   }
                   else
                   {
                       GeneralBindings.LogResult(false, Message, actual);
                       Assert.Fail(string.Format("{0} expectedValue={1} actualValue={2}", Message,expected, actual));
                   }
               }

               public static void CheckBooleanAndLogResult(string mainMessage, string subMessage, bool expected, bool actual)
               {
                   if (expected==actual)
                   {
                       GeneralBindings.LogResult(true, mainMessage,Convert.ToString(actual));
                   }
                   else
                   {
                       GeneralBindings.LogResult(false, mainMessage, Convert.ToString(actual));
                       Assert.Fail(string.Format("{0} {1} expectedValue={2} actualValue={3}", mainMessage, subMessage, expected, actual));
                   }
               }



    }
    
}