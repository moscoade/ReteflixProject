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
        HeaderMenuPage headerMenuPage = new HeaderMenuPage();
       

        [Given(@"I navigate to reteflix website")]
        public void GivenINavigateToReteflixWebsite()
        {
            driver.Navigate().GoToUrl(@"https://reteflix.reteicons.com/"); 
        }

        [Given(@"I click to accept all cookies")]
        public void GivenIClickToAcceptAllCookies()
        {
            headerMenuPage.AcceptCookiesPolicy();

        }

        [When(@"I click on biography on the menu")]
        public void WhenIClickOnBiographyOnTheMenu()
        {
            headerMenuPage.ClickBiography();
        }

        [Then(@"Biography page should be displayed")]
        public void ThenBiographyPageShouldBeDisplayed()
        {
            headerMenuPage.BiographyIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }

       
    }
}
