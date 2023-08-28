using August2023.Pages;
using System;
using TechTalk.SpecFlow;

namespace August2023.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Given(@"I navigate to Time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time record")]
        public void WhenICreateANewTimeRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            
        }
    }
}
