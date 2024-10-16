using UIAutomation.Tests;

namespace UIAutomation.StepDefinitions
{
    [Binding]
    internal class CreateAccountStepDefition : RegisterUser
    {
        [When(@"Confirm User is successfully signed up")]
        public void WhenConfirmUserIsSuccessfullySignedUp()
        {
            ConfirmuserIsSignedUp();
        }
    }
}
