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
    class WebImageBindings
    {

        private static readonly ILog debugLog = LogManager.GetLogger(typeof(GeneralBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");

        
        [When(@"I click on the Image Button '(.*)' searched by '(.*)'")]
        public void ClickImageButton(string element, string elementtype)
        {
            debugLog.DebugFormat("ClickImageButton()", "Clicking the Image Button");
            if (elementtype.ToUpper().Equals("NAME"))
            {
                IWebElement query = WebBrowser.Current.FindElement(By.Name(element));
                query.GetAttribute("src");
                if (query.Enabled)
                {
                    GeneralBindings.LogResult(true, "Found and enabled Image Button", element);
                }
                else
                {
                    Assert.Fail("Button either not found or not enabled ->", query);
                }
                query.Click();
            }

            GeneralBindings.LogResult(true, "Button Image has been Clicked Successfully", element);

        }
    
    }
}
