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
        HeaderMenuPage headerMenuPage = new HeaderMenuPage();
        

        [When(@"I click on gallery on the menu")]
        public void WhenIClickOnGalleryOnTheMenu()
        {
            headerMenuPage.ClickGallery(); 
        }

        [Then(@"Gallery page should be displayed")]
        public void ThenGalleryPageShouldBeDisplayed()
        {
            headerMenuPage.GalleryIsDisplayed().Should().BeTrue();
            Thread.Sleep(1000);
        }
    }
}
