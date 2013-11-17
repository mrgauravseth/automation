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
    public class WebImage : WebBase
    {

        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebImage));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        public void ClickImageButton(string element)
        {
            debugLog.DebugFormat("ClickImageButton()", "Clicking the Image Button");
                IWebElement query = WebBrowser.Current.FindElement(By.Name(element));
                query.GetAttribute("src");
                if (query.Enabled)
                {
                    debugLog.InfoFormat("Image Button is enabled and visible", element);
                }
                else
                {
                    Assert.Fail("Button either not found or not enabled ->", query);
                }
                query.Click();
        }
    }

    
 }

