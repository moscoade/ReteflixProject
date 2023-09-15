using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class TearmAndConditionsStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        AutomationPage automationPage = new AutomationPage();
        [When(@"I click on Tearms and Conditions on the footer")]
        public void WhenIClickOnTearmsAndConditionsOnTheFooter()
        {
           automationPage.ClickOnTearmsAndConditions();
        }

        [Then(@"Tearms and conditions page should be displayed")]
        public void ThenTearmsAndConditionsPageShouldBeDisplayed()
        {
            automationPage.TearmAmdConditionsIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }

    }
}
