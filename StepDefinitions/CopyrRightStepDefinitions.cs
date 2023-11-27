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
        FooterMenuPage footerMenuPage = new FooterMenuPage();

        [When(@"I click on copyright on the footer")]
        public void WhenIClickOnCopyrightOnTheFooter()
        {
            footerMenuPage.ClickOnCopyright();
        }

        [Then(@"Copyright page should be displayed")]
        public void ThenCopyrightPageShouldBeDisplayed()
        {
            footerMenuPage.CopyrightIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }

    }
}
