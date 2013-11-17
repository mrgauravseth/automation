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
using GUI;

namespace Automation_Framework.Code.Bindings
{
    [Binding]
    class WebTextBindings
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebTextBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        [When(@"I enter text '(.*)' in the TextBox '(.*)' searched by '(.*)'")]
        public void EnterText(string keyword, string locator, string type)
        {
            debugLog.DebugFormat("EnterText()");
            string actualTextBoxValue;
            WebBrowser.Current.WaitForPageToLoad();
            WebText textbox = new WebText();
            switch (type)
            {
                case "NAME":
                    textbox.EnterTextByName(locator, keyword);
                    break;
                case "CSS":
                    textbox.EnterTextByCSS(locator,keyword);
                    break;
                case "XPATH":
                    textbox.EnterTextByXPath(locator,keyword);
                    break;
                case "ID":
                    textbox.EnterTextByID(locator,keyword);
                    break;
                default:
                    break;
            }
            actualTextBoxValue = textbox.GetTextBoxText(locator,type);
            debugLog.DebugFormat(actualTextBoxValue);
            Assert.AreEqual(keyword, actualTextBoxValue);
            GeneralBindings.CheckStringAndLogresult("EnterText()", keyword, actualTextBoxValue);
        }

    }
}