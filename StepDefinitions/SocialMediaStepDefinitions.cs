using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class SocialMediaStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        FooterMenuPage footerMenuPage = new FooterMenuPage();
        [When(@"I click on facebook icon on the footer")]
        public void WhenIClickOnFacebookIconOnTheFooter()
        {
            footerMenuPage.ClickOnFacebookIcon();
        }


        [Then(@"I should be redirected to eagle's eye facebook page")]
        public void ThenIShouldBeRedirectedToEaglesEyeFacebookPage()
        {
            Thread.Sleep(2000);
            footerMenuPage.FacebookpageIsDisplayed();
        }

        [When(@"I click on Instagram icon on the footer")]
        public void WhenIClickOnInstagramIconOnTheFooter()
        {
           footerMenuPage.ClickOnInstagramIcon();
        }

        [Then(@"I should be redirected to eagle's eye instagram page")]
        public void ThenIShouldBeRedirectedToEaglesEyeInstagramPage()
        {
            Thread.Sleep(2000);
            footerMenuPage.InstagramIsDisplayed();
        }

        [When(@"I click on linkedIn icon on the footer")]
        public void WhenIClickOnLinkedInIconOnTheFooter()
        {
          footerMenuPage.ClickOnLinkedInIcon();
        }

        [Then(@"I should be redirected to eagle's eye LinkefIn page")]
        public void ThenIShouldBeRedirectedToEaglesEyeLinkefInPage()
        {
            Thread.Sleep(2000);
            footerMenuPage.LinkedInpageIsDisplayed();
        }

        [When(@"I click on Twitter icon on the footer")]
        public void WhenIClickOnTwitterIconOnTheFooter()
        {
            footerMenuPage.ClickOnTwitterIcon();
        }

        [Then(@"I should be redirected to eagle's eye Twitter page")]
        public void ThenIShouldBeRedirectedToEaglesEyeTwitterPage()
        {
            Thread.Sleep(2000);
           footerMenuPage.TwitterPageIsDisplayed();
        }

        [When(@"I click on Youtube icon on the footer")]
        public void WhenIClickOnYoutubeIconOnTheFooter()
        {
            footerMenuPage.ClickOnYoutubeIcon();
        }

       
        [Then(@"I should be redirected to eagle's eye Youtube page")]
        public void ThenIShouldBeRedirectedToEaglesEyeYoutubePage()
        {
            Thread.Sleep(2000);
            footerMenuPage.YoutubePageIsDisplayed();
        }
    }
}
