using System;
using TechTalk.SpecFlow;
using UIAutomation.Tests;

namespace UIAutomation.StepDefinitions
{
    [Binding]
    public class SignUpUserStepDefinitions
    {
        private RegisterUser _registerUser;

        // Constructor to initialize the Tests class
        public SignUpUserStepDefinitions()
        {
            _registerUser = new RegisterUser();
        }

        [Given(@"\[Automation exercise URL]")]
        public void GivenAutomationExerciseURL()
        {
            _registerUser.NavigateToURL();
        }

        [When(@"\[Verify that home page is visible successfully]")]
        public void WhenVerifyThatHomePageIsVisibleSuccessfully()
        {
            _registerUser.VerifyHomePageIsVisible();
        }

        [When(@"Click on Signup / Login button")]
        public void WhenClickOnSignupLoginButton()
        {
            _registerUser.ClickOnSignUpButton();
        }

        [When(@"Enter signup username")]
        public void WhenEnterSignupUsername()
        {
            _registerUser.EnterSignUpUserName();
        }

        [When(@"Enter signup email address")]
        public void WhenEnterSignupEmailAddress()
        {
            _registerUser.EnterEmail();
        }


        [When(@"Click on Signup button")]
        public void WhenClickOnSignupButton()
        {
            _registerUser.ClickSignUpButton();
        }

        [Then(@"Confirm User is successfully signed up")]
        public void ThenConfirmUserIsSuccessfullySignedUp()
        {
            _registerUser.ConfirmuserIsSignedUp();
        }

    }
}
