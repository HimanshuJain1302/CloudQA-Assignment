using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationPracticeFormTests
{
    [TestFixture]
    public class FormFieldTests
    {
        private IWebDriver? driver;
        private readonly string baseUrl = "https://app.cloudqa.io/home/AutomationPracticeForm";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
            driver = null;
        }


        [Test]
public void FullFormSubmission_ShouldDisplayInputValues()
{
    driver!.Navigate().GoToUrl(baseUrl);


    var firstName = driver.FindElement(By.Id("fname"));
    const string firstNameValue = "Alice";
    firstName.Clear();
    firstName.SendKeys(firstNameValue);


    var dob = driver.FindElement(By.Id("dob"));
    dob.Clear();
    dob.SendKeys("2020-10-30");  

    var mobile = driver.FindElement(By.Id("mobile"));
    const string mobileNumber = "1234567890";  
    mobile.Clear();
    mobile.SendKeys(mobileNumber);


    var agreeCheckbox = driver.FindElement(By.Id("Agree"));
    if (!agreeCheckbox.Selected)
        agreeCheckbox.Click();


    var submitButton = driver.FindElement(By.CssSelector("button[type='submit']"));
    submitButton.Click();

    System.Threading.Thread.Sleep(2000); 


    string pageSource = driver.PageSource;

    Assert.That(pageSource.Contains(firstNameValue), $"First Name '{firstNameValue}' not found after submission.");
    Assert.That(pageSource.Contains("2020-10-30"), "Date of Birth not visible after submission.");
    Assert.That(pageSource.Contains(mobileNumber), $"Mobile number '{mobileNumber}' not found after submission.");
}
    }
}