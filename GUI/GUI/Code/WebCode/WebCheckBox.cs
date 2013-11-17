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
    public class WebCheckBox : WebBase
    {

        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebCheckBox));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        public void SelectCheckBoxByCSS(string locator, string checkFlag)
        {
            debugLog.DebugFormat("SelectCheckBoxByCSS()");
            try
            {
                IWebElement checkBox = WebBrowser.Current.FindElement(By.CssSelector(locator));
                if (checkFlag.Equals("ON"))
                {
                    if (!checkBox.Selected)
                    {
                        debugLog.InfoFormat("This is to check if checkbox is selected or not ---------->", checkBox.Selected);
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned on", locator);
                    }
                }
                else if (checkFlag.Equals("OFF"))
                {
                    if (checkBox.Selected)
                    {
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned off", locator);
                    }
                }
                else
                {
                    debugLog.ErrorFormat("Please Specify if the CheckBox has to be turned Off or ON");
                    Assert.Fail("Please Specify if the CheckBox {0} has to be turned Off or ON", locator);
                }
             }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectCheckBoxByCSS()", e.ToString());
            }
        }


        public void SelectCheckBoxByName(string locator, string checkFlag)
        {
            debugLog.DebugFormat("SelectCheckBoxByName()");
            try
            {
                IWebElement checkBox = WebBrowser.Current.FindElement(By.Name(locator));
                if (checkFlag.Equals(ONOROFF.ON))
                {
                    if (!checkBox.Selected)
                    {
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned on", locator);
                    }
                }
                else if (checkFlag.Equals(ONOROFF.OFF))
                {
                    if (checkBox.Selected)
                    {
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned off", locator);
                    }
                }
                else
                {
                    debugLog.ErrorFormat("Please Specify if the CheckBox has to be turned Off or ON");
                    Assert.Fail("Please Specify if the CheckBox {0} has to be turned Off or ON", locator);
                }
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectCheckBoxByName()", e.ToString());
            }
        }

        public void SelectCheckBoxByXpath(string locator, string checkFlag)
        {
            debugLog.DebugFormat("SelectCheckBoxByXpath()");
            try
            {
                IWebElement checkBox = WebBrowser.Current.FindElement(By.Name(locator));
                if (checkFlag.Equals(ONOROFF.ON))
                {
                    if (!checkBox.Selected)
                    {
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned on", locator);
                    }
                }
                else if (checkFlag.Equals(ONOROFF.OFF))
                {
                    if (checkBox.Selected)
                    {
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned off", locator);
                    }
                }
                else
                {
                    debugLog.ErrorFormat("Please Specify if the CheckBox has to be turned Off or ON");
                    Assert.Fail("Please Specify if the CheckBox {0} has to be turned Off or ON", locator);
                }
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectCheckBoxByXpath()", e.ToString());
            }
        }

        public void SelectCheckBoxByID(string locator, string checkFlag)
        {
            debugLog.DebugFormat("SelectCheckBoxByID()");
            try
            {
                IWebElement checkBox = WebBrowser.Current.FindElement(By.Name(locator));
                if (checkFlag.Equals(ONOROFF.ON))
                {
                    if (!checkBox.Selected)
                    {
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned on", locator);
                    }
                }
                else if (checkFlag.Equals(ONOROFF.OFF))
                {
                    if (checkBox.Selected)
                    {
                        checkBox.Click();
                        debugLog.InfoFormat("CheckBox has been turned off", locator);
                    }
                }
                else
                {
                    debugLog.ErrorFormat("Please Specify if the CheckBox has to be turned Off or ON");
                    Assert.Fail("Please Specify if the CheckBox {0} has to be turned Off or ON", locator);
                }
            }
            catch (Exception e)
            {
                debugLog.ErrorFormat("SelectCheckBoxByID()", e.ToString());
            }
        }
    }
}
