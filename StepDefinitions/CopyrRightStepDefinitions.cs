using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class CopyrRightStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        AutomationPage automationPage = new AutomationPage();

        [When(@"I click on copyright on the footer")]
        public void WhenIClickOnCopyrightOnTheFooter()
        {
            automationPage.ClickOnCopyright();
        }

        [Then(@"Copyright page should be displayed")]
        public void ThenCopyrightPageShouldBeDisplayed()
        {
            automationPage.CopyrightIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }

    }
}
