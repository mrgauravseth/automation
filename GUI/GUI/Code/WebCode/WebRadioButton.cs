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
    public class WebRadioButton :WebBase
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebBase));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");
        
        public void SelectRadioButtonByCSS(string locator)
        {
            debugLog.DebugFormat("SelectRadioButton()");
            try
            {
                IWebElement Radiobutton = WebBrowser.Current.FindElement(By.CssSelector(locator));
                Radiobutton.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectByCSS()", e.ToString()); 
            }
        }

        public void SelectRadioButtonByXpath(string locator)
        {
            debugLog.DebugFormat("SelectRadioButtonByXpath()");
            try
            {
                IWebElement Radiobutton = WebBrowser.Current.FindElement(By.XPath(locator));
                Radiobutton.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectRadioButtonByXpath()", e.ToString());
            }

        }
        
        public void SelectRadioButtonByName(string locator)
        {
            debugLog.DebugFormat("SelectRadioButtonByName()");
            try
            {
                IWebElement Radiobutton = WebBrowser.Current.FindElement(By.Name(locator));
                Radiobutton.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectRadioButtonByName()", e.ToString());
            }
        }

        public void SelectRadioButtonByID(string locator)
        {
            debugLog.DebugFormat("SelectRadioButtonByID()");
            try
            {
                IWebElement Radiobutton = WebBrowser.Current.FindElement(By.Id(locator));
                Radiobutton.Click();
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectRadioButtonByID()", e.ToString());
            }
            }
        }
        
    }

