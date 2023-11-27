using FluentAssertions;
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
    public class ContactUsStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        FooterMenuPage footerMenuPage = new FooterMenuPage();
        [Given(@"I click on contact Us on the footer")]
        public void GivenIClickOnContactUsOnTheFooter()
        {
            footerMenuPage.ClickContactUs();
        }

        [When(@"the contact us form is displayed")]
        public void WhenTheContactUsFormIsDisplayed()
        {
           footerMenuPage.ContactUsIsDisplayed();
        }

        [When(@"I enter my first name")]
        public void WhenIEnterMyFirstName()
        {
           footerMenuPage.EnterFirstName();
        }

        [When(@"I enter my last name")]
        public void WhenIEnterMyLastName()
        {
            footerMenuPage.EnterLastName();
        }

        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            footerMenuPage.EnterEmail();
        }

        [When(@"I enter my messages")]
        public void WhenIEnterMyMessages()
        {
           footerMenuPage.EnterMyMessage();
        }

        [When(@"I click on send message")]
        public void WhenIClickOnSendMessage()
        {
            Thread.Sleep(1000);
            footerMenuPage.ClickSendButten();
        }

        [Then(@"I should see a message displayed ""([^""]*)""")]
        public void ThenIShouldSeeAMessageDisplayed(string message)
        {
            Thread.Sleep(1000);
            Assert.IsTrue(footerMenuPage.AMessageIsDisplayed());
            Assert.AreEqual(message, footerMenuPage.GetTextMessage());
        }

        
       
        
    }
}
