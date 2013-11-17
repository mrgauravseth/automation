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
    public class WebDropDown : WebBase
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebDropDown));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");


        public void SelectDropDownByName(string locator,string value)
        {
            debugLog.DebugFormat("SelectDropDownByName()");
            try
            {
                IWebElement DropDown = WebBrowser.Current.FindElement(By.Name(locator));
                DropDown.SendKeys(value);
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectByCSS()", e.ToString());
            }
        }

        public void SelectDropDownByXpath(string locator,string value)
        {
            debugLog.DebugFormat("SelectDropDownXpath()");
            try
            {
                IWebElement DropDown = WebBrowser.Current.FindElement(By.XPath(locator));
                DropDown.SendKeys(value);
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectDropDownXpath()", e.ToString());
            }
        }

        public void SelectDropDownByID(string locator,string value)
        {
            debugLog.DebugFormat("SelectDropDownID()");
            try
            {
                IWebElement DropDown = WebBrowser.Current.FindElement(By.Id(locator));
                DropDown.SendKeys(value);
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectDropDownID()", e.ToString());
            }
        }
        
        public void SelectDropDownByCSS(string locator,string value)
        {
            debugLog.DebugFormat("SelectDropDownByCSS()");
            try
            {
                IWebElement DropDown = WebBrowser.Current.FindElement(By.CssSelector(locator));
                DropDown.SendKeys(value);
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectDropDownByCSS()", e.ToString());
            }
        }





   
    }
}
