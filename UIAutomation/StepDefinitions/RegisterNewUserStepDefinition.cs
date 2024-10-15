using Microsoft.VisualStudio.TestPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomation.Tests;

namespace UIAutomation.StepDefinitions
{
    [Binding]
    public sealed class RegisterNewUserStepDefinition
    {
        private RegisterUser _registerUser;

        // Constructor to initialize the Tests class
        public RegisterNewUserStepDefinition()
        {
            _registerUser = new RegisterUser();  // Create instance of Tests class
        }

        [Given("Automation exercise website is launched")]
        
        public void Launchpage() 
        {
            _registerUser.LaunchPage();
        }

    }
}
