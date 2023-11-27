using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class AwardsStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        HeaderMenuPage headerMenuPage = new HeaderMenuPage();


        [When(@"I click on awards on the menu")]
        public void WhenIClickOnAwardsOnTheMenu()
        {
            headerMenuPage.ClickAwardsMenu(); 
        }

        [Then(@"Awards page should be displayed")]
        public void ThenAwardsPageShouldBeDisplayed()
        {
            headerMenuPage.AwardsIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }
    }
}
