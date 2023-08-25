using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit;

namespace PermutationProject.E2ETests
{
    public class E2ETests : IDisposable
    {
        private readonly IWebDriver _driver;

        public E2ETests()
        {
            // Arrange
            _driver = new ChromeDriver(); // Use the appropriate driver for your browser
        }

        [Fact]
        public void Test_PermutationPage_Example1()
        {
            // Arrange
            _driver.Navigate().GoToUrl("https://localhost:7164"); // Update URL as needed

            // Act
            var input = _driver.FindElement(By.Id("numbers"));
            input.SendKeys("1,2,3");

            var submitButton = _driver.FindElement(By.Id("submit"));
            submitButton.Click();

            // Assert
            var result = _driver.FindElement(By.Id("result"));
            Assert.Equals("1,3,2", result.Text);
        }

        // Add more E2E tests for different scenarios

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}