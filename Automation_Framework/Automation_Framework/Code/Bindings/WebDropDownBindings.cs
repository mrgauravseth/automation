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
    class WebDropDownBindings
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(WebDropDownBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");
        
        [When(@"I select drop down value '(.*)' from the DropDown Box '(.*)' searched by '(.*)'")]
        public void SelectDropDown(string value, string locator, string type)
        {
            debugLog.DebugFormat("SelectDropDown()");
            WebBrowser.Current.WaitForPageToLoad();
            WebDropDown DropDown=new WebDropDown();

            switch (type)
            {
                case "NAME":
                    DropDown.SelectDropDownByName(locator,value);
                    break;
                case "CSS":
                    DropDown.SelectDropDownByCSS(locator,value);
                    break;
                case "XPATH":
                    DropDown.SelectDropDownByXpath(locator,value);
                    break;
                case "ID":
                    DropDown.SelectDropDownByID(locator,value);
                    break;
                default:
                    break;
            }
            GeneralBindings.LogResult(true, "Button has been Clicked Successfully->", locator);
        }


    }
}
