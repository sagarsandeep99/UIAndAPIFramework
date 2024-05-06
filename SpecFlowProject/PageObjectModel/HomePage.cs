using OpenQA.Selenium;
using SpecFlowProject_Wipfli.ActionClasses;

namespace SpecFlowProject_Wipfli.PageObjectModel
{
    internal class HomePage
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly UIActions _uiActions;
        public HomePage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            //_uiActions = new UIActions(_scenarioContext);
        }

        public readonly By _inboxLink = By.XPath("//a[text()='Inbox']");
    }
}
