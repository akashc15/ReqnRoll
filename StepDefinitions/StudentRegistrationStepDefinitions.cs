using Reqnroll;
using ReqnrollProject.Utillites;


using System;

namespace ReqnrollProject1.StepDefinitions

{

    [Binding]

    public class StudentRegistrationStepDefinitions

    {

        private readonly Pages.StudentRegistrationPage srp;

        public StudentRegistrationStepDefinitions(DriverContext context)

        {

            srp = new Pages.StudentRegistrationPage(context.Driver);

        }

        [Given("User is on the student registration page")]

        public void GivenUserIsOnTheStudentRegistrationPage()

        {

            srp.OpenRegistrationForm();

        }

        [When("User enters the Name {string}")]

        public void WhenUserEntersTheName(string name)

        {

            srp.EnterName(name);

        }

        [When("User enters the Email {string}")]

        public void WhenUserEntersTheEmail(string email)

        {

            srp.EnterEmail(email);

        }

        [When("User selects the Gender {string}")]

        public void WhenUserSelectsTheGender(string gender)

        {

            srp.SelectGender(gender);

        }

        [When("User enters the Mobile {string}")]

        public void WhenUserEntersTheMobile(string mobile)

        {

            srp.EnterMobile(mobile);

        }

        [When("User enters the Date of Birth {string}")]

        public void WhenUserEntersTheDateOfBirth(string dob)

        {

            srp.EnterDateOfBirth(dob);

        }

        [When("User enters the Subjects {string}")]

        public void WhenUserEntersTheSubjects(string subject)

        {

            srp.EnterSubject(subject);

        }

        [When("User selects the Hobbies {string}")]

        public void WhenUserSelectsTheHobbies(string hobbies)

        {

            srp.SelectHobbies(hobbies);

        }

        [When("User enters the Current Address {string}")]

        public void WhenUserEntersTheCurrentAddress(string address)

        {

            srp.EnterAddress(address);

        }

        [When("User selects the State {string}")]

        public void WhenUserSelectsTheState(string state)

        {

            srp.SelectState(state);

        }

        [When("User selects the City {string}")]

        public void WhenUserSelectsTheCity(string city)

        {

            srp.SelectCity(city);

        }

        [Then("The form is submitted successfully")]

        public void ThenTheFormIsSubmittedSuccessfully()

        {

            srp.SubmitForm();

        }

    }

}

