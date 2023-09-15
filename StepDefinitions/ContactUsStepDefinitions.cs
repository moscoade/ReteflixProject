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
        AutomationPage automationPage = new AutomationPage();
        [Given(@"I click on contact Us on the footer")]
        public void GivenIClickOnContactUsOnTheFooter()
        {
            automationPage.ClickContactUs();
        }

        [When(@"the contact us form is displayed")]
        public void WhenTheContactUsFormIsDisplayed()
        {
           automationPage.ContactUsIsDisplayed();
        }

        [When(@"I enter my first name")]
        public void WhenIEnterMyFirstName()
        {
           automationPage.EnterFirstName();
        }

        [When(@"I enter my last name")]
        public void WhenIEnterMyLastName()
        {
            automationPage.EnterLastName();
        }

        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            automationPage.EnterEmail();
        }

        [When(@"I enter my messages")]
        public void WhenIEnterMyMessages()
        {
           automationPage.EnterMyMessage();
        }

        [When(@"I click on send message")]
        public void WhenIClickOnSendMessage()
        {
            Thread.Sleep(1000);
            automationPage.ClickSendButten();
        }

        [Then(@"I should see a message displayed ""([^""]*)""")]
        public void ThenIShouldSeeAMessageDisplayed(string message)
        {
            Thread.Sleep(1000);
            Assert.IsTrue(automationPage.AMessageIsDisplayed());
            Assert.AreEqual(message, automationPage.GetTextMessage());
        }

        
       
        
    }
}
