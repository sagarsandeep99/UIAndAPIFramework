using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject_Wipfli.ActionClasses;
using SpecFlowProject_Wipfli.DataLibraries.DataVariables;
using SpecFlowProject_Wipfli.Drivers;
using SpecFlowProject_Wipfli.PageObjectModel;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject_Wipfli.StepDefinitions.UI
{
    [Binding]
    public class LoginToContactListAppFromExternalDataStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private WebDriver driver;

        LoginToContactListAppFromExternalDataStepDefinitions(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given(@"user1 launches the browser")]
        public void GivenUserLaunchesTheBrowser(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            driver = _scenarioContext.Get<WebDriverLibrary>("WebDriverLibrary").SetupDriver(data.Browsers);
        }

        [Given(@"user1 naivagtes to CLA portal ""([^""]*)""")]
        public void GivenUserNaivagtesToCLAPortal(string url)
        {
            driver.Url = url;   
        }

        [Given(@"user1 enters username and password in CLA")]
        public void GivenUserEntersUsernameAndPasswordInCLA()
        {
            ContactListAppLoginPage _contactListAppLoginPage = new ContactListAppLoginPage(_scenarioContext);
            _contactListAppLoginPage.ContactListAppLoginProcess(StoreDataValuesToVariables.UserName, StoreDataValuesToVariables.Password);
        }

        [When(@"user1 logs in to Contact List app")]
        public void WhenUserLogsInToContactListApp()
        {
            Thread.Sleep(3000);
            ContactListAppLoginPage _CLALoginPage = new ContactListAppLoginPage(_scenarioContext);
            _CLALoginPage.ClickOnCLAloginButton();
        }

        [Then(@"user1 should be logged in and and navigate to Home Page of CLA")]
        public void ThenUserShouldBeLoggedInAndAndNavigateToHomePageOfCLA()
        {
            Thread.Sleep(3000);
            ContactListAppHomePage _CLAhomePage = new ContactListAppHomePage(_scenarioContext);
            UIActions _uiActions = new UIActions(_scenarioContext);
            var actualResult = _uiActions.GetText(_CLAhomePage._ContactListlabel);
            Assert.AreEqual("Contact List", actualResult, "Home Page is not loaded, login might failed");
        }
    }
}
