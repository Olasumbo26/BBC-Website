using System;
using System.Threading;
using BBCWebsite.PageObjects;
using BBCWebsite.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BBCWebsite.StepDefinitions
{
    [Binding]
    public class EastendersSteps
    {
        //declare pageobject page below
        EastendersPage Search;

        //create constructor which is the name of the class steps
        public EastendersSteps()
        {
            //Instantiate the page object below and we call the Login
            Search = new EastendersPage();
        }



        [Given(@"I Navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            //for this step to navigate, we need a driver to navigate it and maximize
            Hooks.Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
            Hooks.Driver.Manage().Window.Maximize();
        }
        [When(@"I click on search text box")]
        public void WhenIClickOnSearchTextBox()
        {
            Search.ClickSearchTextBox();
        }


        [When(@"I Enter Eastenders into the search text box")]
        public void WhenIEnterEastendersIntoTheSearchTextBox()
        {
            Search.Entereastenders("Eastenders");
        }
        
        [When(@"I Click on search button")]
        public void WhenIClickOnSearchButton()
        {
            Search.ClickSearchButton();
        }
        
        [When(@"I Click on Eastenders display image")]
        public void WhenIClickOnEastendersDisplayImage()
        {
            Search.ClickDisplayImage();
        }
        
        [Then(@"I should be able to find next episode")]
        public void ThenIShouldBeAbleToFindNextEpisode()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(Search.UpcomingEpisodesIsDisplayed());
        }
    }
}
