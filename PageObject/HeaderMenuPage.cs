using OpenQA.Selenium;
using Reteflix.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reteflix.PageObject
{
    class HeaderMenuPage
    {
        public IWebDriver driver;

        private By cookies = By.XPath("//*[text()='Accept']");
        private By bio = By.XPath("(//*[text()='Biography'])[1]");
        private By gall = By.XPath("(//*[text()='Gallery'])[1]");
        private By awds = By.XPath("(//*[text()='Awards'])[1]");
        private By blog = By.XPath("(//a[text()='Blog'])[1]");        
        private By aboutUs = By.XPath("(//a[text()='About us'])[1]");
        private By searchIcon = By.XPath("(//*[@class='fa fa-search'])[1]");
        private By searchBox = By.XPath("(//*[@id='searchInput'])[1]");
        private By searchBtn = By.XPath("(//*[@class='fa fa-search'])[2]");
        public HeaderMenuPage()
        {
            driver = WebHook.driver;
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
        public void ClickAboutUsonMenu()
        {
            driver.FindElement(aboutUs).Click();
        }
        public bool AboutUsIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/about-us-3/");
        }

        
        public void ClickBlogMenu()
        {
            driver.FindElement(blog).Click();
        }
        public bool blogsIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/blog/");
        }
        
        public void ClickAwardsMenu()
        {
            driver.FindElement(awds).Click();
        }
        public bool AwardsIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/elementor-21538/");
        }
        public void ClickGallery()
        {
            driver.FindElement(gall).Click();
        }
        public bool GalleryIsDisplayed()
        {
            return driver.Url.Contains("https://reteflix.reteicons.com/gallery-002/");
        }
        public void AcceptCookiesPolicy()
        {
            driver.FindElement(cookies).Click();
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
