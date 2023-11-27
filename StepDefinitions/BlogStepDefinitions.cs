using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class BlogStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        HeaderMenuPage headerMenuPage = new HeaderMenuPage();

        [When(@"I click on blog on the menu")]
        public void WhenIClickOnBlogOnTheMenu()
        {
            headerMenuPage.ClickBlogMenu();
        }

        [Then(@"blogs page should be displayed")]
        public void ThenBlogsPageShouldBeDisplayed()
        {
            headerMenuPage.blogsIsDisplayed().Should().BeTrue();
            
        }
       

    }
}
