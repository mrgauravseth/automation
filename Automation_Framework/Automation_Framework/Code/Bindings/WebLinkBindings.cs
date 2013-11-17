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
    class WebLinkBindings
    {
        private static readonly ILog debugLog = LogManager.GetLogger(typeof(GeneralBindings));
        private static readonly ILog resultsLog = LogManager.GetLogger("ResultsFile");


        [When(@"I click on the Link '(.*)' searched by '(.*)'")]
        public void ClickLink(string element, string elementtype)
        {
            debugLog.DebugFormat("ClickLink(), Clicking the Link");
            WebBrowser.Current.WaitForPageToLoad();
            IWebElement query = WebBrowser.Current.FindElement(By.LinkText(element));
            query.Click();
            WebBrowser.Current.WaitForPageToLoad();
            GeneralBindings.LogResult(true, "Link is clicked", element);
        }

    
    }
}
