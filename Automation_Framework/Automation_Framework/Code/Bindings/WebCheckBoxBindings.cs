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
    class WebCheckBoxBindings
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(GeneralBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        [When(@"I turn the CheckBox '(.*)' searched by '(.*)' to '(.*)'")]
        public void CheckBox(string locator,string identifyBy,string checkFlag)
        {
            debugLog.DebugFormat("CheckBox()");
            WebCheckBox CheckBox = new WebCheckBox();
            switch (identifyBy)
            {
                case "NAME":
                    CheckBox.SelectCheckBoxByName(locator, checkFlag);
                    break;
                case "CSS":
                    CheckBox.SelectCheckBoxByCSS(locator, checkFlag);
                    break;
                case "XPATH":
                    CheckBox.SelectCheckBoxByXpath(locator, checkFlag);
                    break;
                case "ID":
                    CheckBox.SelectCheckBoxByID(locator, checkFlag);
                    break;
                default:
                    break;
            }
            GeneralBindings.LogResult(true, "CheckBox has been Selected ->", locator);

        }

    
    }
}
