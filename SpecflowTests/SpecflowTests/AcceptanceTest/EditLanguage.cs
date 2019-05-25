using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class EditLanguage : Utils.Start
    {
        [Given(@"at least a language should be added on my listings")]
        public void GivenAtLeastALanguageShouldBeAddedOnMyListings()
        {
            //Wait
            Thread.Sleep(1500);

            for (int i = 1; i <= 100; i++)
            {
                string ExpectedName = "English";
                string ActualName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedName == ActualName)
                {
                    Console.WriteLine("Found target : " + ActualName);
                    break;
                }
                else
                {

                }
            }
        }

        [When(@"I edit a language")]
        public void WhenIEditALanguageEnglish()
        {
            for (int i = 1; i <= 100; i++)
            {
                string ExpectedName = "English";
                string ActualName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedName == ActualName)
                {
                    //Update Language
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]")).Click();
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).SendKeys(Keys.Control + "a");
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).SendKeys("Korean");
                    //Update Language Level
                    IWebElement Level = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option"))[3];
                    Level.Click();
                    //Click the button Update
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();
                    break;
                }
                else
                {

                }

            }
        }

        [Then(@"that updated language should be displayed on my listings")]
        public void ThenThatUpdatedLanguageEnglishShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Found English and change to Korean");

                Thread.Sleep(1000);
                for (int i = 1; i <= 100; i++)
                {
                    string ExpectedName = "Korean";
                    string ActualName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Thread.Sleep(500);
                    if (ExpectedName == ActualName)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Found English and change to Korean Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Updated");
                    }
                    else
                    {
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    }
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
    }
}
