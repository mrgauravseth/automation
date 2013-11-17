using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using log4net;
using log4net.Config;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Automation_Framework.Code
{
    [Binding]
    public class WebBrowser
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebBrowser));
       // [Given(@"I am on the Browser '(.*)'")]
        
        public static IWebDriver Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                {
                  //  Select IE browser
                   ScenarioContext.Current["browser"] = new InternetExplorerDriver();

                    //Select Firefox browser
                    //FirefoxProfile profile = new FirefoxProfile();
                    //Proxy prx = new Proxy();
                    //prx.IsAutoDetect = true;
                    //profile.SetProxyPreferences(prx);
                    //ScenarioContext.Current["browser"] = new FirefoxDriver(profile);
                    // ScenarioContext.Current["browser"] = new FirefoxDriver();

                   // //Select Chrome browser
                   //ScenarioContext.Current["browser"] = new ChromeDriver();
                }
                return (IWebDriver)ScenarioContext.Current["browser"];
            }
        }

        public static void OpenSite(string targeturl)
        {
            debugLog.DebugFormat("Opening URL {0}", targeturl);
            WebBrowser.Current.Navigate().GoToUrl(targeturl);
            WebBrowser.Current.Manage().Window.Maximize();
            WebBrowser.Current.WaitForPageToLoad();
          
        }

          [TearDown]
        public static void Close()
        {
            if (ScenarioContext.Current.ContainsKey("browser"))
            {
                Current.Quit();
                Current.Dispose();
            }
        }
    }
}