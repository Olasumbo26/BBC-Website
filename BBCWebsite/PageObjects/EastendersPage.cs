using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBCWebsite.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCWebsite.PageObjects
{
    class EastendersPage
    {
        public EastendersPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }
        [FindsBy(How = How.Id, Using = "orb-search-button")]
        private IWebElement SearchTextBox { get; set; }

        public void ClickSearchTextBox()
        {
            SearchTextBox.Click();
        }


        [FindsBy(How = How.Id, Using = "se-searchbox-input-field")]
        private IWebElement SearchField { get; set; }

        public void Entereastenders(string eastenderstext)
        {
            SearchField.SendKeys(eastenderstext);
        }
        [FindsBy(How = How.ClassName, Using = "se-searchbox__submit")]
        private IWebElement searchbutton { get; set; }

        public void ClickSearchButton()
        {
            searchbutton.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#search-result-0 > picture > img")]
        private IWebElement DisplayImage { get; set; }

        public void ClickDisplayImage()
        {
            DisplayImage.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "div.\\31 \\/2\\@gel1b:nth-child(2) > div:nth-child(1) > div:nth-child(3) > p:nth-child(1) > a:nth-child(1)")]
        private IWebElement UpcomingEpisodes { get; set; }

        public bool UpcomingEpisodesIsDisplayed()
        {

            {
                return UpcomingEpisodes.Displayed;
            }





        }
    }
}