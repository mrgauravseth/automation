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
    public class WebText : WebBase
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebText));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        public void EnterTextByName(string locator, string expectedvalue)
        {
            debugLog.DebugFormat("EnterTextByName()");
            try
            {
                string actualvalue;
                WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                IWebElement TextBox = WebBrowser.Current.FindElement(By.Name(locator));
                debugLog.Debug(TextBox.GetAttribute("value"));
                TextBox.Clear();
                System.Threading.Thread.Sleep(1000);
                TextBox.SendKeys(expectedvalue);
                debugLog.Debug(TextBox.GetAttribute("value"));
                actualvalue = TextBox.GetAttribute("value");
                Assert.AreEqual(expectedvalue, actualvalue);
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("EnterTextByName()", e.ToString());
            }
        }

      
        public void EnterTextByXPath(string locator, string expectedvalue)
        {
            debugLog.DebugFormat("EnterTextByXPath()");
            try
            {
                string actualvalue;
                WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                IWebElement TextBox = WebBrowser.Current.FindElement(By.XPath(locator));
                debugLog.Debug(TextBox.GetAttribute("value"));
                TextBox.Clear();
                System.Threading.Thread.Sleep(1000);
                TextBox.SendKeys(expectedvalue);
                debugLog.Debug(TextBox.GetAttribute("value"));
                actualvalue = TextBox.GetAttribute("value");
                Assert.AreEqual(expectedvalue, actualvalue);
            }

            catch (Exception e)
            {
                debugLog.ErrorFormat("EnterTextByXpath()", e.ToString());
            }
        }

        public void EnterTextByCSS(string locator, string expectedvalue)
        {
            debugLog.DebugFormat("EnterTextByCSS()");
            try
            {
                string actualvalue;
                WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                IWebElement TextBox = WebBrowser.Current.FindElement(By.CssSelector(locator));
                debugLog.Debug(TextBox.GetAttribute("value"));
                TextBox.Clear();
                TextBox.SendKeys(expectedvalue);
                System.Threading.Thread.Sleep(1000);
                debugLog.Debug(TextBox.GetAttribute("value"));
                actualvalue = TextBox.GetAttribute("value");
                Assert.AreEqual(expectedvalue, actualvalue);
            }

            catch (Exception e)
            {
                debugLog.ErrorFormat("EnterTextByCSS()", e.ToString());
            }
        }

        public void EnterTextByID(string locator, string expectedvalue)
        {
            debugLog.DebugFormat("EnterTextByID()");
            try
            {
                string actualvalue;
                WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                IWebElement TextBox = WebBrowser.Current.FindElement(By.Id(locator));
                debugLog.Debug(TextBox.GetAttribute("value"));
                TextBox.Clear();
                System.Threading.Thread.Sleep(1000);
                TextBox.SendKeys(expectedvalue);
                debugLog.Debug(TextBox.GetAttribute("value"));
                actualvalue = TextBox.GetAttribute("value");
                Assert.AreEqual(expectedvalue, actualvalue);
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("EnterTextByID()", e.ToString());
            }
        }


       public string GetTextBoxText(string locator, string identifier)
        {
            if (identifier.Equals("CSS"))
            {
                IWebElement textboxCSS = WebBrowser.Current.FindElement(By.CssSelector(locator));
                return textboxCSS.GetAttribute("value");
            }
            else if (identifier.Equals("ID"))
            {
                IWebElement textboxId = WebBrowser.Current.FindElement(By.Id(locator));
                return textboxId.GetAttribute("value");
            }
            else if (identifier.Equals("XPATH"))
            {
                IWebElement textboxXpath = WebBrowser.Current.FindElement(By.XPath(locator));
                return textboxXpath.GetAttribute("value");
            }
            else if (identifier.Equals("NAME"))
            {
                IWebElement textBoxByName = WebBrowser.Current.FindElement(By.Name(locator));
                return textBoxByName.GetAttribute("value");
            }
            else
            {
                return "";
            }
        }

       public void ClearText(string locator)
       {
           debugLog.DebugFormat("ClearText()");
           try
           {
               WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
               IWebElement TextBox = WebBrowser.Current.FindElement(By.CssSelector(locator));
               debugLog.Debug(TextBox.GetAttribute("value"));
               TextBox.Clear();
               Assert.AreEqual(TextBox.GetAttribute("value"), "");
           }
           catch (Exception e)
           {
               debugLog.ErrorFormat("ClearText()", e.ToString());
           }
       }

       public void ClickTextBox(string locator)
       {
           debugLog.DebugFormat("ClickTextBox()");
           try
           {
               WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
               IWebElement TextBox = WebBrowser.Current.FindElement(By.CssSelector(locator));
               debugLog.Debug(TextBox.GetAttribute("value"));
               TextBox.Click();
           }
           catch (Exception e)
           {
               debugLog.ErrorFormat("ClickTextBox()", e.ToString());
           }
       }


       public bool IsTextBoxDisplayed(string locator)
       {
           debugLog.DebugFormat("ClickTextBox()");
           try
           {
               WebBrowser.Current.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
               IWebElement TextBox = WebBrowser.Current.FindElement(By.CssSelector(locator));
               debugLog.Debug(TextBox.GetAttribute("value"));
               return TextBox.Displayed;
           }
           catch (Exception e)
           {
               debugLog.ErrorFormat("IsTextBoxDisplayed()", e.ToString());
               return false;
           }
       }



    }

}

