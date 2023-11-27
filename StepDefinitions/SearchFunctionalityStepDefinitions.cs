using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class SearchFunctionalityStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        HeaderMenuPage headerMenuPage = new HeaderMenuPage();

        [When(@"I click on search icon on the header menu")]
        public void WhenIClickOnSearchIconOnTheHeaderMenu()
        {
            headerMenuPage.ClickSearchIcon();
        }

        [When(@"I ender a movie name in the search box")]
        public void WhenIEnderAMovieNameInTheSearchBox()
        {
            headerMenuPage.ClickSearchBox();
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            headerMenuPage.ClickSearchButton();
        }

        [Then(@"my movie should be displayed")]
        public void ThenMyMovieShouldBeDisplayed()
        {
            headerMenuPage.MyMovieIsDisplayed().Should().BeTrue();
        }
    }
}
