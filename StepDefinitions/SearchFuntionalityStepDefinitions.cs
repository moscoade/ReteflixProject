using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class SearchFuntionalityStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        AutomationPage automationPage = new AutomationPage();

        [When(@"I click on search icon on the header menu")]
        public void WhenIClickOnSearchIconOnTheHeaderMenu()
        {
            automationPage.ClickSearchIcon();
        }

        [When(@"I ender a movie name in the search box")]
        public void WhenIEnderAMovieNameInTheSearchBox()
        {
            automationPage.ClickSearchBox();
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            automationPage.ClickSearchButton();
        }

        [Then(@"my movie should be displayed")]
        public void ThenMyMovieShouldBeDisplayed()
        {
            automationPage.MyMovieIsDisplayed().Should().BeTrue();
        }
    }
}
