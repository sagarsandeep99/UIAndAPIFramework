using OpenQA.Selenium;
using SpecFlowProject_Wipfli.ActionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_Wipfli.PageObjectModel
{
    internal class ContactListAppHomePage
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly UIActions _uiActions;
        public ContactListAppHomePage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            //_uiActions = new UIActions(_scenarioContext);
        }

        public readonly By _ContactListlabel = By.XPath("//h1[text()='Contact List']");
    }
}
