using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class FAQStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        FooterMenuPage footerMenuPage = new FooterMenuPage();

        [When(@"I click on FAQ on the footer")]
        public void WhenIClickOnFAQOnTheFooter()
        {
            footerMenuPage.ClickFAQonFooter();
        }

        [Then(@"FAQ page should be displayed")]
        public void ThenFAQPageShouldBeDisplayed()
        {
            footerMenuPage.FAQsIsDisplayed().Should().BeTrue();
        }
    }
}
