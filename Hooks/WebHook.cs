using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Reteflix.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            
        }

       

        [AfterScenario]
        public void AfterScenario()
        {
          driver.Quit();
          driver.Dispose();
        }
    }
}