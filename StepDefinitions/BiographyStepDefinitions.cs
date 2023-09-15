using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class BiographyStepDefinitions 
    {
        public IWebDriver driver = WebHook.driver;
        AutomationPage automationPage = new AutomationPage();

        [Given(@"I navigate to reteflix website")]
        public void GivenINavigateToReteflixWebsite()
        {
            driver.Navigate().GoToUrl(@"https://reteflix.reteicons.com/"); 
        }

        [When(@"I click on biography on the menu")]
        public void WhenIClickOnBiographyOnTheMenu()
        {
            automationPage.ClickBiography();
        }

        [Then(@"Biography page should be displayed")]
        public void ThenBiographyPageShouldBeDisplayed()
        {
            automationPage.BiographyIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }

       
    }
}
