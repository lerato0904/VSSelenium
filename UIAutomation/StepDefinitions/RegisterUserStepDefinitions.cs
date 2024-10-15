using System;
using TechTalk.SpecFlow;
using UIAutomation.Tests;

namespace UIAutomation.StepDefinitions
{
    [Binding]
    public class RegisterUserStepDefinitions
    {
        private RegisterUser _registerUser;

        // Constructor to initialize the Tests class
        public RegisterUserStepDefinitions()
        {
            _registerUser = new RegisterUser();  // Create instance of Tests class
        }

        [Given(@"\[Automation exercise URL]")]
        public void GivenAutomationExerciseURL()
        {
            _registerUser.LaunchPage();
        }
    }
}
