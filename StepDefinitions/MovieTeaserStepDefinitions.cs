using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class MovieTeaserStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        MainBodyPage mainBodyPage = new MainBodyPage();

        [When(@"I click on any movie teaser play now thumbnail on the home page")]
        public void WhenIClickOnAnyMovieTeaserPlayNowThumbnailOnTheHomePage()
        {
            mainBodyPage.ClickRandomMovieTeaser(); 
        }

        [When(@"I click on play")]
        public void WhenIClickOnPlay()
        {
            mainBodyPage.ClickPlayButton(); 
        }

        [Then(@"I should be able to watch the movie")]
        public void ThenIShouldBeAbleToWatchTheMovie()
        {
            Thread.Sleep(4000);
            mainBodyPage.MovieIsDisplayed().Should().BeTrue();    
        }
    }
}
