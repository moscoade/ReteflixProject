using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class AboutUsStepDefinitions
    {

        public IWebDriver driver = WebHook.driver;
        HeaderMenuPage headerMenuPage = new HeaderMenuPage();

        [When(@"I click on About Us on the menu")]
        public void WhenIClickOnAboutUsOnTheMenu()
        {
           headerMenuPage.ClickAboutUsonMenu();
        }

        [Then(@"About Us page should be displayed")]
        public void ThenAboutUsPageShouldBeDisplayed()
        {
            headerMenuPage.AboutUsIsDisplayed().Should().BeTrue();
        }
    }
}
