using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class GalleryStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        AutomationPage automationPage = new AutomationPage();

        [When(@"I click on gallery on the menu")]
        public void WhenIClickOnGalleryOnTheMenu()
        {
            automationPage.ClickGallery(); 
        }

        [Then(@"Gallery page should be displayed")]
        public void ThenGalleryPageShouldBeDisplayed()
        {
            automationPage.GalleryIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }
    }
}
