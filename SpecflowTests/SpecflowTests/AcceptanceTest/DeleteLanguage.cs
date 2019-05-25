using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class DeleteLanguage
    {
        [Given(@"the language which I have added should be displayed on my listings under Profile page")]
        public void GivenTheLanguageWhichIHaveAddedShouldBeDisplayedOnMyListingsUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1000);
            //Click Langues Tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

        }

        [When(@"I click the X icon on my listings")]
        public void WhenIClickTheXIconOnMyListings()
        {
            Thread.Sleep(1000);
            for (int i = 1; i <= 100; i++)
            {
                string ExpectedName = "English";
                string ActualName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedName == ActualName)
                {
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();
                    Console.WriteLine("Deleted " + ActualName);
                    break;
                }
                else
                {
                    Console.WriteLine("There is no language name on the list");
                }
            }

        }

        [Then(@"that language should be deleted from my listings")]
        public void ThenThatLanguageShouldBeDeletedFromMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete languages on Language Tab");

                Thread.Sleep(1000);
                string ExpectedValue = "";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Delete languages on Language Tab");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "DataDeleted");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}
