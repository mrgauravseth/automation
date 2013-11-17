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


namespace Automation_Framework.Code
{
 
       public class Webdriver
    {
           IWebDriver driver=null;
        [SetUp]
        public void SetupTest(string browser)
        {
            IWebDriver driver;
            string Target = "http://google.com";
            const int STANDARD_TIMEOUT = 1;
            string SCREENSHOT_PATH = System.AppDomain.CurrentDomain.BaseDirectory + @"\Screenshots\";
            
            switch (browser)
            {
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    FirefoxProfile profile = new FirefoxProfile();
                    Proxy prx = new Proxy();
                    prx.IsAutoDetect = true;
                    profile.SetProxyPreferences(prx);
                    driver = new FirefoxDriver(profile);
                    driver.Manage().Window.Maximize();
                    SetImplicitTimeout(STANDARD_TIMEOUT);
                    driver.Navigate().GoToUrl(Target);
                    break;
           
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
            }
           
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
        public void SetImplicitTimeout(int sec)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(sec));

        }
      
        }
    }



