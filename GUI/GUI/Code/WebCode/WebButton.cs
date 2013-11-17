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
    public class WebButton : WebBase
    {

        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebButton));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        public void ClickButtonByName(string locator)
        {
            debugLog.DebugFormat("ClickButtonByName()", "Clicking the ClickButton");
            try
            {
                IWebElement query = WebBrowser.Current.FindElement(By.Name(locator));
                query.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("ClickButtonByName()", e.ToString());
            }

        }

        public void ClickButtonByXPath(string locator)
        {
            debugLog.DebugFormat("ClickButtonByXpath()", "Clicking the ClickButton");
            try
            {
                IWebElement button = WebBrowser.Current.FindElement(By.XPath(locator));
                button.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("ClickButtonByXpath()", e.ToString());
            }

        }

        
        public void ClickButtonbyCSS(string locator)
        {
            debugLog.DebugFormat("ClickButtonbyCSS()", "Clicking the ClickButton using the CSS");
            try
            {
                IWebElement button = WebBrowser.Current.FindElement(By.CssSelector(locator));
                button.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("ClickButtonByCSS()", e.ToString());
            
            }
        }

        public void ClickButtonByID(string elementname)
        {
            debugLog.DebugFormat("ClickButtonbyID()", "Clicking the ClickButton using the CSS");
            try
            {
                IWebElement button = WebBrowser.Current.FindElement(By.Id(elementname));
                button.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("ClickButtonByID()", e.ToString());
            }

        }

    }

}

