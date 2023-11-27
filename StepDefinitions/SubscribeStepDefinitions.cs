using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class SubscribeStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        FooterMenuPage footerMenuPage = new FooterMenuPage();
        [When(@"I click on subscribe button on the footer")]
        public void WhenIClickOnSubscribeButtonOnTheFooter()
        {
            footerMenuPage.ClickSubscribeButton();
        }

        [When(@"I enter my name")]
        public void WhenIEnterMyName()
        {
           footerMenuPage.EnterMyName();
        }

        [When(@"I click on subscribe")]
        public void WhenIClickOnSubscribe()
        {
            footerMenuPage.ClickOnSubscribe();
        }

        [Then(@"I should see subscription message displayed ""([^""]*)""")]
        public void ThenIShouldSeeSubscriptionMessageDisplayed(string Mssg)
        {
            //Thread.Sleep(1000);
            Assert.IsTrue(footerMenuPage.SubscriptionMssgDisplayed());
            Assert.AreEqual(Mssg, footerMenuPage.GetTheMessage());
        }

    }
}
