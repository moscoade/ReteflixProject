using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class PrivacyPolicyStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        AutomationPage automationPage = new AutomationPage();
        [When(@"I click on Privacy Policy on the footer")]
        public void WhenIClickOnPrivacyPolicyOnTheFooter()
        {
            automationPage.ClickOnPrivacyPolicy();
        }

        [Then(@"Privacy policy page should be displayed")]
        public void ThenPrivacyPolicyPageShouldBeDisplayed()
        {
            automationPage.PrivacyPolicyIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }

        
    }
}
