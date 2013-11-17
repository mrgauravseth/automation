using NUnit.Framework;
using System;
using Selenium;
using System.Web;
using System.Text;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using log4net;
using log4net.Config;


namespace GUI
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
        
        }

        public static void WaitForPageToLoad()
        {
            TimeSpan timeout = new TimeSpan(0, 0, 30);
            WebDriverWait wait = new WebDriverWait(Current, timeout);

            IJavaScriptExecutor javascript = Current as IJavaScriptExecutor;
            if (javascript == null)
                throw new ArgumentException("driver", "Driver must support javascript execution");

            wait.Until((d) =>
            {
                try
                {
                    string readyState = javascript.ExecuteScript("if (document.readyState) return document.readyState;").ToString();
                    return readyState.ToLower() == "complete";
                }
                catch (InvalidOperationException e)
                {
                    //Window is no longer available
                    return e.Message.ToLower().Contains("unable to get browser");
                }
                catch (WebDriverException e)
                {
                    //Browser is no longer available
                    return e.Message.ToLower().Contains("unable to connect");
                }
                catch (Exception)
                {
                    return false;
                }
            });
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