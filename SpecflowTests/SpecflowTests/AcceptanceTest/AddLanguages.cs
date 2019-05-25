using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using System.Windows.Forms;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    //Please add : Utils.Start behind of class name like that public class AddSharedSkill : Utils.Start before running
    public class AddLanguages
    {

        [Given(@"I clicked on the Langauge tab under Profile page")]
        public void GivenIClickedOnTheLangaugeTabUnderProfilePage()
        {

            //Wait
            Thread.Sleep(1500);
            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

        }

        [When(@"I add new languages (.*)")]
        public void WhenIAddNewLanguages(string language)
        {

            //IWebElement btn = Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            //if (btn.Displayed == true)
            //{
                //Click on Add New button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

                //Add Language
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(language);

                //Click on Language Level
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

                //Choose the language level
                IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
                Lang.Click();

                //Click on Add button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        //}
            //else
            //{
            //    Console.WriteLine("Full of list");
            //}

    WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromMinutes(10));
            //Driver.driver.FindElement(By.ClassName("ns-box ns-growl ns-effect-jelly ns-type-error ns-show"));
            if (Driver.driver.FindElement(By.ClassName("ns-box-inner")).Displayed)
            {
                Console.WriteLine("Duplcated Data");
                //driver.Quit();
            }
            else
            {
                Console.WriteLine("Added successfully");


            }



            //Never mind this code it is just for testing something :)

            //if (!isDisplayed)
            //{
            //    Console.WriteLine("Full of list");
            //}
            //else
            //{
            //    //Click on Add New button
            //    Thread.Sleep(1000);
            //    addNewBtn.Click();
            //    Thread.Sleep(3000);
            //    //Add Language
            //    addLang.SendKeys(language);

            //    //Click on Language Level
            //    dropdown.Click();

            //    //Choose the language level
            //    Lang.Click();

            //    //Click on Add button
            //    saveBtn.Click();
            //    Thread.Sleep(200);

            //    for (int i = 1; i <= 10; i++)
            //    {
            //        string ExpectedName = language;
            //        string ActualName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

            //        Thread.Sleep(500);

            //        //Duplicated Data
            //        if (ExpectedName != ActualName)
            //        {
            //            //Click on Add New button
            //            Thread.Sleep(5000);
            //            addNewBtn.Click();
            //            Thread.Sleep(3000);
            //            //Add Language
            //            addLang.SendKeys(language);

            //            //Click on Language Level
            //            dropdown.Click();

            //            //Choose the language level
            //            Lang.Click();

            //            //Click on Add button
            //            saveBtn.Click();
            //            Thread.Sleep(200);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Already exist data");
            //            break;
            //        }
            //    }

            //}


        }

        [Then(@"those languages (.*) should be displayed on my listings")]
        public void ThenThoseLanguagesShouldBeDisplayedOnMyListings(string language)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add languages");

                Thread.Sleep(1000);
                for (int i = 1; i <= 100; i++)
                {
                    string ExpectedName = language;
                    string ActualName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Thread.Sleep(500);
                    if (ExpectedName == ActualName)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguagesAdded");
                        break;
                    }
                    else
                    {

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
