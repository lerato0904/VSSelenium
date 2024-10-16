using UIAutomation.Tests;

namespace UIAutomation.StepDefinitions
{
    [Binding]
    internal class CreateAccountStepDefition : RegisterUser
    {
        public CreateAccount _createAccount;

        public CreateAccountStepDefition()
        {
            _createAccount = new CreateAccount();
        }

        [When(@"Confirm User is successfully signed up")]
        public void WhenConfirmUserIsSuccessfullySignedUp()
        {
            ConfirmuserIsSignedUp();
        }

        [When(@"Select gender")]
        public void WhenSelectGender()
        {
            _createAccount.SelectGender();
        }

        [When(@"Enter password")]
        public void WhenEnterPassword()
        {
           _createAccount.EnterUserPassword();
        }

        [When(@"Enter day of birth")]
        public void WhenEnterDayOfBirth()
        {
            _createAccount.EnterDayOfBirth();
        }

        [When(@"Enter month of birth")]
        public void WhenEnterMonthOfBirth()
        {
            _createAccount.EnterMonthOfBirth();
        }

        [When(@"Enter year of birth")]
        public void WhenEnterYearOfBirth()
        {
            _createAccount.EnterYearOfBirth();
        }

        [When(@"Enter first name")]
        public void WhenEnterFirstName()
        {
            _createAccount.EnterFirstName();
        }

        [When(@"Enter last name")]
        public void WhenEnterLastName()
        {
            _createAccount.EnterLastName();
        }

        [When(@"Enter Company")]
        public void WhenEnterCompany()
        {
           _createAccount.EnterCompany();
        }

        [When(@"Enter Address")]
        public void WhenEnterAddress()
        {
            _createAccount.EnterAddress();
        }

        [When(@"Select Country")]
        public void WhenSelectCountry()
        {
            _createAccount.SelectCountry();
        }

        [When(@"Enter State")]
        public void WhenEnterState()
        {
            _createAccount.EnterState();
        }

        [When(@"Enter City")]
        public void WhenEnterCity()
        {
            _createAccount.EnterCity();
        }

        [When(@"Enter Zip code")]
        public void WhenEnterZipCode()
        {
            _createAccount.EnterZipCode();
        }

        [When(@"Enter cellphone number")]
        public void WhenEnterCellphoneNumber()
        {
            _createAccount.EnterCellPhoneNumber();
        }

        [When(@"Click on the CreateAccount button")]
        public void WhenClickOnTheCreateAccountButton()
        {
            _createAccount.ClickOnCreateAccountButton();
        }

    }
}
