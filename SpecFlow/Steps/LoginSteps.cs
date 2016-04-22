using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace SpecFlow.Steps
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver;

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        
        [When(@"I press the Login link")]
        public void WhenIPressTheLoginLink()
        {
            driver.FindElement(By.Id("lst-ib")).SendKeys("Unicorns");
            
        }
        
        [Then(@"I should be taken to the login page")]
        public void ThenIShouldBeTakenToTheLoginPage()
        {
            driver.FindElement(By.Id("hdtb"));
            driver.Quit();
        }
    }
}
