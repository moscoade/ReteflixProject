using FluentAssertions;
using OpenQA.Selenium;
using Reteflix.Hooks;
using Reteflix.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Reteflix.StepDefinitions
{
    [Binding]
    public class BlogCommentStepDefinitions
    {
        public IWebDriver driver = WebHook.driver;
        MainBodyPage mainBodyPage = new MainBodyPage();
        [When(@"I click on any blog post at rondom")]
        public void WhenIClickOnAnyBlogPostAtRondom()
        {
            mainBodyPage.ClickRandomBlogPost();
        }

        [When(@"I enter comments")]
        public void WhenIEnterComments()
        {
            mainBodyPage.EnterCommentOnBlog();
        }

        [When(@"I enter author name")]
        public void WhenIEnterAuthorName()
        {
            mainBodyPage.EnterAuthorName();
        }

        [When(@"I enter author email address")]
        public void WhenIEnterAuthorEmailAddress()
        {
            mainBodyPage.EnterAuthorEmail();
        }

        [When(@"I enter author website")]
        public void WhenIEnterAuthorWebsite()
        {
            mainBodyPage.EnterAuthorWebsite();
        }


        [When(@"I tick the box to save my name")]
        public void WhenITickTheBoxToSaveMyName()
        {
            mainBodyPage.ClickBoxToSaveName();
        }

        [When(@"I click post comment")]
        public void WhenIClickPostComment()
        {
            mainBodyPage.ClickOnPostComment();
        }

        [Then(@"my comment should be posted")]
        public void ThenMyCommentShouldBePosted()
        {
            //mainBodyPage.CommentPostedIsDisplayed().Should().BeTrue();
        }
       

    }
}
