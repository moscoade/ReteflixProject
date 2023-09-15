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
        AutomationPage automationPage = new AutomationPage();
        [When(@"I click on any movie teaser play now thumbnail on the home page")]
        public void WhenIClickOnAnyMovieTeaserPlayNowThumbnailOnTheHomePage()
        {
            automationPage.ClickRandomMovieTeaser(); 
        }

        [When(@"I click on play")]
        public void WhenIClickOnPlay()
        {
            automationPage.ClickPlayButton(); 
        }

        [Then(@"I should be able to watch the movie")]
        public void ThenIShouldBeAbleToWatchTheMovie()
        {
            Thread.Sleep(4000);
            automationPage.MovieIsDisplayed().Should().BeTrue();    
        }
    }
}
