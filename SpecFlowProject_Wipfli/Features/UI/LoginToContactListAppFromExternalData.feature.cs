﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowProject_Wipfli.Features.UI
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LoginToContactListAppFromExternalData")]
    public partial class LoginToContactListAppFromExternalDataFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LoginToContactListAppFromExternalData.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/UI", "LoginToContactListAppFromExternalData", "Read data from external source documents", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login to Contact List Application(CLA) by reading data from excel file")]
        [NUnit.Framework.CategoryAttribute("UiTests")]
        [NUnit.Framework.TestCaseAttribute("chrome", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        [NUnit.Framework.TestCaseAttribute("firefox", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        [NUnit.Framework.TestCaseAttribute("edge", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        public void LoginToContactListApplicationCLAByReadingDataFromExcelFile(string browser, string appURL, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UiTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Browser", browser);
            argumentsOfScenario.Add("AppURL", appURL);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login to Contact List Application(CLA) by reading data from excel file", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Browsers"});
                table3.AddRow(new string[] {
                            string.Format("{0}", browser)});
#line 7
 testRunner.Given("user1 launches the browser_createUserRequest", ((string)(null)), table3, "Given ");
#line hidden
#line 10
 testRunner.And(string.Format("user1 naivagtes to CLA portal {0}", appURL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("user1 enters username and password in CLA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.When("user1 logs in to Contact List app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("user1 should be logged in and and navigate to Home Page of CLA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login to Contact List Application(CLA) by reading data from csv file")]
        [NUnit.Framework.CategoryAttribute("UiTests")]
        [NUnit.Framework.TestCaseAttribute("chrome", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        [NUnit.Framework.TestCaseAttribute("firefox", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        [NUnit.Framework.TestCaseAttribute("edge", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        public void LoginToContactListApplicationCLAByReadingDataFromCsvFile(string browser, string appURL, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UiTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Browser", browser);
            argumentsOfScenario.Add("AppURL", appURL);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login to Contact List Application(CLA) by reading data from csv file", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Browsers"});
                table4.AddRow(new string[] {
                            string.Format("{0}", browser)});
#line 26
 testRunner.Given("user1 launches the browser", ((string)(null)), table4, "Given ");
#line hidden
#line 29
 testRunner.And(string.Format("user1 naivagtes to CLA portal {0}", appURL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("user1 enters username and password in CLA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.When("user1 logs in to Contact List app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("user1 should be logged in and and navigate to Home Page of CLA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login to Contact List Application(CLA) by reading data from xml file")]
        [NUnit.Framework.CategoryAttribute("UiTests")]
        [NUnit.Framework.TestCaseAttribute("chrome", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        [NUnit.Framework.TestCaseAttribute("firefox", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        [NUnit.Framework.TestCaseAttribute("edge", "\"https://thinking-tester-contact-list.herokuapp.com/\"", null)]
        public void LoginToContactListApplicationCLAByReadingDataFromXmlFile(string browser, string appURL, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UiTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Browser", browser);
            argumentsOfScenario.Add("AppURL", appURL);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login to Contact List Application(CLA) by reading data from xml file", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Browsers"});
                table5.AddRow(new string[] {
                            string.Format("{0}", browser)});
#line 45
 testRunner.Given("user1 launches the browser", ((string)(null)), table5, "Given ");
#line hidden
#line 48
 testRunner.And(string.Format("user1 naivagtes to CLA portal {0}", appURL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("user1 enters username and password in CLA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.When("user1 logs in to Contact List app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then("user1 should be logged in and and navigate to Home Page of CLA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
