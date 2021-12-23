using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumLearning
{
    public class Tests
    {
        public IWebDriver driver ;
        [OneTimeSetUp]

       
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.github.com");
        }

        

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Name("user_email")).SendKeys("Hello");
        }


        [OneTimeTearDown]
        public void close()
        {
            driver.Close();
        }
    }
}