using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class TermAndConditionsStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        FooterMenuPage footerMenuPage= new FooterMenuPage();
        

        [When(@"I click on Terms and Conditions on the footer")]
        public void WhenIClickOnTermsAndConditionsOnTheFooter()
        {
            footerMenuPage.ClickOnTermsAndConditions();
        }

        [Then(@"Terms and conditions page should be displayed")]
        public void ThenTermsAndConditionsPageShouldBeDisplayed()
        {
            footerMenuPage.TermAmdConditionsIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }


    }
}
