using OpenQA.Selenium;
using Reteflix.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reteflix.PageObject
{
    class AutomationPage 
    {
        public IWebDriver driver;

        private By bio = By.XPath("(//*[text()='Biography'])[1]");
        private By gall = By.XPath("(//*[text()='Gallery'])[1]");
        private By contact = By.XPath("//*[text()='Contact Us']");
        private By firstName = By.XPath("//*[@name='name-1-first-name']");
        private By lastName = By.XPath("//*[@name='name-1-last-name']");
        private By email = By.XPath("//*[@type='email']");
        private By msg = By.XPath("//*[@class='forminator-textarea']");
        private By butt = By.XPath("//button[normalize-space()='Send Message']");
        private By msgDisplay = By.XPath("//*[@id=\"forminator-module-19994\"]/div[1]/p");
        private By copyright = By.XPath("//*[text()='Copyright']");
        private By privacy = By.XPath("//*[text()='Privacy Policy']");
        private By tAndC = By.XPath("//*[text()='Terms and Conditions']");
        private By facebook = By.XPath("//*[@class='fab fa-facebook']");
        private By insta = By.XPath("//*[@class='fab fa-instagram']");
        private By linkedIn = By.XPath("//*[@class='fab fa-linkedin']");
        private By youTube = By.XPath("//*[@class='fab fa-youtube']");
        private By twit = By.XPath("//*[@class='fab fa-twitter']");
        private By searchIcon = By.XPath("(//*[@class='fa fa-search'])[1]");
        private By searchBox = By.XPath("(//*[@id='searchInput'])[1]");
        private By searchBtn = By.XPath("(//*[@class='fa fa-search'])[2]");
        private By play = By.XPath("//*[@class='mejs-overlay-button']");
        public AutomationPage()
        {
            driver = WebHook.driver;
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


        public bool MyMovieIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/?s=BLACK+QUEEN&ajax_search=true");
        }
        public void ClickSearchButton()
        {
            driver.FindElement(searchBtn).Click();
        }
        public void ClickSearchBox()
        {
            driver.FindElement(searchBox).SendKeys("BLACK QUEEN");
        }
        public void ClickSearchIcon()
        {
            driver.FindElement(searchIcon).Click();
        }
        public bool TwitterPageIsDisplayed()
        {
            return driver.Url.Contains("https://twitter.com/i/flow/login?redirect_after_login=%2Ftolu_yesufu");
        }
        public void ClickOnTwitterIcon()
        {
            driver.FindElement(twit).Click();
        }

        public bool YoutubePageIsDisplayed()
        {
            return driver.Url.Contains("https://consent.youtube.com/m?continue=https%3A%2F%2Fwww.youtube.com%2F%40toluyesufu8208%3Fcbrd%3D1&gl=GB&m=0&pc=yt&cm=2&hl=en-GB&src=1");
        }
        
        public void ClickOnYoutubeIcon()
        {
            driver.FindElement(youTube).Click();
        }
        public bool LinkedInpageIsDisplayed()
        {
           return driver.Url.Contains("https://www.linkedin.com/checkpoint/challengesV2/AQFpzRDXywp4sAAAAYoKn8ZrQSIYDoKhWnqO9eiwj2Z9wwEBiy6FQbQ-m3vah0cSk3K0lvSeX26I7ggfpp8hPziNcTa5KVKBTA?original_referer=https%3A%2F%2Freteflix.reteicons.com%2F");
        }
        public void ClickOnLinkedInIcon()
        {
            driver.FindElement(linkedIn).Click();
        }
        public void ClickOnInstagramIcon()
        {
            driver.FindElement(insta).Click();
        }
        public bool InstagramIsDisplayed()
        {
            return driver.Url.Contains("https://www.instagram.com/tolulopeyesufu/?igshid=MzRlODBiNWFlZA%3D%3D");
        }
        public bool FacebookpageIsDisplayed()
        {
            return driver.Url.Contains("https://www.facebook.com/tolulope.yesufu");
        }
       
        public void ClickOnFacebookIcon()
        {
            driver.FindElement(facebook).Click();
        }
        public bool TearmAmdConditionsIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/terms-of-use/");
        }
        public void ClickOnTearmsAndConditions()
        {
            driver.FindElement(tAndC).Click();
        }
        public bool PrivacyPolicyIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/privacy-policy-2/");
        }
        public void ClickOnPrivacyPolicy()
        {
            driver.FindElement(privacy).Click();
        }
        public bool CopyrightIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/copyright-2/");
        }
        public void ClickOnCopyright()
        {
            driver.FindElement(copyright).Click();
        }

        public bool AMessageIsDisplayed()
        {
            return driver.FindElement(msgDisplay).Displayed;
        }

        public string GetTextMessage()
        {
            string message = "Message successfully sent.";

            return message;
        }
       
        public void ClickSendButten()
        {
            driver.FindElement(butt).Click();
        }
        public void EnterMyMessage()
        {
            driver.FindElement(msg).SendKeys("I'm interested in EAGLE'SEYE");
        }
        public void EnterEmail()
        {
            driver.FindElement(email).SendKeys("yefeme5018@vreaa.com");
        }
        public void EnterLastName()
        {
            driver.FindElement(lastName).SendKeys("Cannon");
        }
        public void EnterFirstName()
        {
            driver.FindElement(firstName).SendKeys("Molly");
        }
        public bool ContactUsIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/contact-us/");
        }
        public void ClickContactUs()
        {
            driver.FindElement(contact).Click();
        }

        public void ClickGallery()
        {
            driver.FindElement(gall).Click();
        }
        public bool GalleryIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/gallery-002/");
        }
        public void ClickBiography() 
        {
            driver.FindElement(bio).Click();
        }
        public bool BiographyIsDisplayed() 
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/biography-2-2/");
        }


    }
}
