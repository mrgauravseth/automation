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
using Automation_Framework.Code;
using log4net;
using log4net.Config;
using GUI;
namespace Automation_Framework.Code.Bindings
{
    [Binding]
    class WebRadioButtonBindings
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebRadioButtonBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        [When(@"user selects Radio Button Value '(.*)' from RadioButtonGroup '(.*)' searched by '(.*)'")]
        public void SelectRadioButton(string value, string locator, string type)
        {
            debugLog.DebugFormat("SelectRadioButton()");
            WebBrowser.Current.WaitForPageToLoad();
            WebRadioButton RadioButton = new WebRadioButton();
            switch (type)
            {
                case "NAME":
                    RadioButton.SelectRadioButtonByName(locator);
                    break;
                case "CSS":
                    RadioButton.SelectRadioButtonByCSS(locator);
                    break;
                case "XPATH":
                    RadioButton.SelectRadioButtonByXpath(locator);
                    break;
                case "ID":
                    RadioButton.SelectRadioButtonByID(locator);
                    break;
                default:
                    break;
            }
            GeneralBindings.LogResult(true, "Button has been Clicked Successfully->", locator);
        }


    }
}