//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ReqnrollProject.Pages
//{
//    internal class FormPage
//    {
//        // locators and the methods or the tests to be performed on the page

//        //  private IWebDriver driver;

//        private readonly IWebDriver _driver;


//        public FormPage(IWebDriver driver)
//        {
//            _driver = driver;
//        }


//        // locators on the login page


//        By name = By.XPath("//input[@id='name']");
//        By email = By.XPath("//input[@id='email']");
//        By gender = By.XPath("//input[@id='gender']");
//        By mobile = By.XPath("//input[@id='mobile']");
//        By Login = By.XPath("//input[@value='Login']");
//        // laucnh browser

//        public void launchbrowser()
//        {

//            _driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/selenium_automation_practice.php");
//        }


//        // enter username and password

//        public void enterusernamepass(String nam, String emai , String mobil )
//        {

//            _driver.FindElement(name).SendKeys(nam);
//            _driver.FindElement(email).SendKeys(emai);
//            _driver.FindElement(mobile).SendKeys(mobil);
//           }


//        // submit method

//        public void submit()
//        {
//            _driver.FindElement(gender).Click();
           
//            _driver.FindElement(Login).Click();
//        }

//        // home page is displayed

//        public void homepagedisplay()
//        {

//            Thread.Sleep(3000);
//            IWebElement homepage = _driver.FindElement(homepagedisplayed);

//            if (homepage.Displayed)
//            {
//                Console.WriteLine("Home page is displayed");
//            }
//            else
//            {

//                Console.WriteLine("Home page is not displayed");
//            }


//        }


//    }
//}