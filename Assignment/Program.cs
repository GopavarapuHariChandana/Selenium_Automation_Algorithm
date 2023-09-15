using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set ChromeDriver executable path
            string chromeDriverPath = @"C:\Users\HariChandana\Downloads\chromedriver-win64\chromedriver-win64\chromedriver.exe"; // Replace with your actual path
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--remote-allow-origins=*");
            IWebDriver driver = new ChromeDriver(chromeDriverPath, options);

            // Navigate to the webpage
            driver.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");

            try
            {
                // Find and interact with the elements on the webpage
                IWebElement firstNameField = driver.FindElement(By.Id("fname"));
                firstNameField.SendKeys("GOPAVARAPU");
                IWebElement lastNameField = driver.FindElement(By.Id("lname"));
                lastNameField.SendKeys("HARI CHANDANA");
                IWebElement mobileInput = driver.FindElement(By.Id("mobile"));
                mobileInput.SendKeys("9949334726");
                IWebElement dateOfBirth = driver.FindElement(By.Id("dob"));
                dateOfBirth.SendKeys("2003-06-04");
                IWebElement email = driver.FindElement(By.Id("email"));
                email.SendKeys("gharichandana9@gmail.com");

            }
            catch (Exception e)
            {
                // Handle any exceptions or errors that may occur during the interactions
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                // Close the browser
                
            }
        }
    }
}
