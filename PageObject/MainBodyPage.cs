using OpenQA.Selenium;
using Reteflix.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reteflix.PageObject
{
    class MainBodyPage
    {
        public IWebDriver driver;

        private By play = By.XPath("//*[@class='mejs-overlay-button']");
        private By comment = By.XPath("//*[@id='comment']");
        private By authName = By.XPath("//*[@name='author']");
        private By authEmail = By.XPath("//*[@name='email']");
        private By authWedsite = By.XPath("//*[@name='url']");
        private By tickBox = By.XPath("//*[@class='checkmark']");
        private By postComment = By.XPath("//*[@class='iq-button btn btn-hover  ']");
        
        public MainBodyPage()
        {
            driver = WebHook.driver;
        }
        /*
        public bool CommentPostedIsDisplayed()
        {
            return driver.Equals("Nice Blog Tolu");

        }
        */
        public void ClickOnPostComment()
        {
            driver.FindElement(postComment).Click();
        }
        public void ClickBoxToSaveName()
        {
            driver.FindElement(tickBox).Click();
        }
        public void EnterAuthorWebsite()
        {
            driver.FindElement(authWedsite).SendKeys("www.retetube.reteicons.com");
        }
        public void EnterAuthorEmail()
        {

            Random randomgenerator = new Random();
            int randomInt = randomgenerator.Next(1000);
            driver.FindElement(authEmail).SendKeys("yefeme5018" + randomInt + "@vreaa.com");
            Thread.Sleep(1000);

        }
        public void EnterAuthorName()
        {
            driver.FindElement(authName).SendKeys("Tester");
        }
        public void EnterCommentOnBlog()
        {
            driver.FindElement(comment).SendKeys("Nice Blog Tolu");
        }
        public void ClickRandomBlogPost()
        {
            Random random = new Random();

            int itemCount = 1;

            for (int i = 0; i < itemCount; i++)
            {
                // Generate a random integer between a specified range

                int randomIndex = random.Next(1, 6); // Generate between 7 (lower boundary) and 12 (upper boundary)
                driver.FindElement(By.XPath("(//a[@class='button-link btn'])[" + randomIndex + "]")).Click();
            }

        }

        public bool MovieIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/movie/");
        }
        public void ClickPlayButton()
        {
            driver.FindElement(play).Click();
        }
        public void ClickRandomMovieTeaser()
        {
            Random random = new Random();

            int itemCount = 1;

            for (int i = 0; i < itemCount; i++)
            {
                // Generate a random integer between a specified range

                int randomIndex = random.Next(7, 12); // Generate between 7 (lower boundary) and 12 (upper boundary)
                driver.FindElement(By.XPath("//*[@id=\"main\"]/div/div/div/div/section[2]/div/div/div/div[1]/div/div/ul/div/div/li[" + randomIndex + "]/div/div[2]/div[2]/a")).Click();
            }

        }
    }
}
