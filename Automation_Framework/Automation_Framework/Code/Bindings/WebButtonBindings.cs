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
    class WebButtonBindings
    {

        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebButtonBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");


        [When(@"I click on the Button '(.*)' searched by '(.*)'")]
        public void ClickThisButton(string locator, string type)
        {
            debugLog.DebugFormat("ClickButton()");
            WebBrowser.Current.WaitForPageToLoad();
            WebButton button = new WebButton();
            switch (type)
            {
                case "NAME":
                    button.ClickButtonByName(locator);
                    break;
                case "CSS":
                    button.ClickButtonbyCSS(locator);
                    break;
                case "XPATH":
                    button.ClickButtonByXPath(locator);
                    break;
                case "ID":
                    button.ClickButtonByID(locator);
                    break;
                default:
                    break;
            }
                GeneralBindings.LogResult(true, "Button has been Clicked Successfully->", locator);
        }

    }
}