using System;

using Reqnroll;
using ReqnrollProject.Pages;
using ReqnrollProject.Utillites;


namespace ReqnrollProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage lp;

        public LoginStepDefinitions(DriverContext context)
        {
            lp = new LoginPage(context.Driver);
        }


        [Given("User is on the orangehrm login page")]
        public void GivenUserIsOnTheOrangehrmLoginPage()
        {
            Log.Info("Opening the Browser");
            lp.launchbrowser();
            Thread.Sleep(2000);
        }

        [When("User enters the username {string} and password {string} in the text fields")]
        public void WhenUserEntersTheUsernameAndPasswordInTheTextFields(string username, string password)
        {
            Log.Info("Entering the username nd password");
            lp.enterusernamepass(username, password);
        }


        [When("User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            Log.Info("CLicked");
            lp.submit();
        }

        [Then("User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Log.Info("displayed");
            lp.homepagedisplay();
        }


        [When("User enters the {string} and {string} in the input fields")]
        public void WhenUserEntersTheAndInTheInputFields(string admin, string p1)
        {
            Console.WriteLine("User enters the username and the password");

        }


        [Then("User selected city and country information")]
        public void ThenUserSelectedCityAndCountryInformation(DataTable dataTable)
        {



            foreach (var row in dataTable.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + "," + country);
            }
        }
    }
}










