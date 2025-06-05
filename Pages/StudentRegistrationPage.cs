using OpenQA.Selenium;
using ReqnrollProject.Utillites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.Pages
{
    internal class StudentRegistrationPage
    {
        public readonly IWebDriver _driver;

        public StudentRegistrationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Locators on the registration form
        By nameField = By.XPath("//input[@id='name']");
        By emailField = By.XPath("//input[@id='email']");
        By genderMale = By.XPath("(//input[@id='gender'])[1]");
        By genderFemale = By.XPath("(//input[@type='radio'])[2]");
        By genderOther = By.XPath("(//input[@type='radio'])[3]");
        By mobileField = By.XPath("//input[@id='mobile']");
        By dobField = By.XPath("//input[@id='dob']");
        By subjectsField = By.XPath("//input[@id='subjects']");
        By hobbiesSports = By.XPath("//label[text()='Sports']/preceding-sibling::input");
        By hobbiesMusic = By.XPath("//label[text()='Music']/preceding-sibling::input");
        By hobbiesReading = By.XPath("//label[text()='Reading']/preceding-sibling::input");
        By addressField = By.XPath("//textarea[@id='picture']");
        By stateDropdown = By.XPath("//select[@id='state']");
        By cityDropdown = By.XPath("//select[@id='city']");
        By submitButton = By.XPath("//input[@value='Login']");


        public void EnterName(string Name)
        {
            _driver.FindElement(nameField).SendKeys(Name);
        }

        public void EnterEmail(string Email)
        {
            _driver.FindElement(emailField).SendKeys(Email);
        }

        public void SelectGender(string gender)
        {
            if (gender.ToLower() == "male")
                _driver.FindElement(genderMale).Click();
            else if (gender.ToLower() == "female")
                _driver.FindElement(genderFemale).Click();
            else if (gender.ToLower() == "other")
                _driver.FindElement(genderOther).Click();
        }

        public void EnterMobile(string mobile)
        {
            _driver.FindElement(mobileField).SendKeys(mobile);
        }

        public void EnterDateOfBirth(string dob)
        {
            _driver.FindElement(dobField).SendKeys(dob);
        }

        public void EnterSubject(string subject)
        {
            _driver.FindElement(subjectsField).SendKeys(subject);
        }

        public void SelectHobbies(string hobbies)
        {
            string[] hobbyList = hobbies.Split(',');
            foreach (var hobby in hobbyList)
            {
                var trimmed = hobby.Trim().ToLower();
                if (trimmed == "sports")
                    _driver.FindElement(hobbiesSports).Click();
                else if (trimmed == "music")
                    _driver.FindElement(hobbiesMusic).Click();
                else if (trimmed == "reading")
                    _driver.FindElement(hobbiesReading).Click();
            }
        }

        public void EnterAddress(string address)
        {
            _driver.FindElement(addressField).SendKeys(address);
        }

        public void SelectState(string state)
        {
            _driver.FindElement(stateDropdown).SendKeys(state);
        }

        public void SelectCity(string city)
        {
            _driver.FindElement(cityDropdown).SendKeys(city);
        }

        public void SubmitForm()
        {
            _driver.FindElement(submitButton).Click();
        }


        internal void OpenRegistrationForm()
        {
            _driver.Navigate().GoToUrl(Config.Baseurl);
            Thread.Sleep(5000);
        }
    }
}


