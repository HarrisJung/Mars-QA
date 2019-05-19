using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddSharedSkill
    {
        [Given(@"I clicked on the button Share Skill under Profile page")]
        public void GivenIClickedOnTheButtonShareSkillUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click the button Share Skill
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")).Click();
        }

        [When(@"I add a new shared skill")]
        public void WhenIAddANewSharedSkill()
        {
            //Add Title
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")).SendKeys("Test Analyst");
            //Type Description
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("I want to skill trade");
            //Click on Category
            IWebElement Category = Driver.driver.FindElements(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option"))[6];
            Category.Click();
            IWebElement Category2 = Driver.driver.FindElements(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option"))[4];
            Category2.Click();
            //Add Tag
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")).SendKeys("#Selenium");
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")).SendKeys(Keys.Enter);

            //Choose Service Type
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")).Click();
            //Choose Location Type
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")).Click();
            //Choose Available Days - Start date
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(1) > div:nth-child(2) > input[type='date']")).SendKeys("2019-05-30");
            //Choose Available Days - End date
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(1) > div:nth-child(4) > input[type='date']")).SendKeys("2019-08-13");

            //Choose Available Time - 10:00am to 16:00pm on Mon - Thu
            for (int i = 3; i < 7; i++)
            {
                Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[" + i + "]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(2) > input[type='time']")).SendKeys(Keys.ArrowUp);
                Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(2) > input[type='time']")).SendKeys(Keys.Tab);
                Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(2) > input[type='time']")).SendKeys("1000");
                Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(3) > input[type='time']")).SendKeys(Keys.ArrowDown);
                Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(3) > input[type='time']")).SendKeys(Keys.Tab);
                Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(" + i + ") > div:nth-child(3) > input[type='time']")).SendKeys("0400");
            }
            //Click on Skill trade
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")).Click();
            //Add Skill-Exchange
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")).SendKeys("#JIRA");
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")).SendKeys(Keys.Enter);
            //Upload Work Samples
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")).Click();
            Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.SendWait(@"C:\Users\HarrisVicky\Desktop\fortesting.txt");
            System.Windows.Forms.SendKeys.SendWait("{Enter}");
            //Choose Active
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")).Click();
            //Click the button Save
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")).Click();



        }

        [Then(@"the lists of shared skill you have been posting should be displayed on my listings")]
        public void ThenTheListsOfSharedSkillYouHaveBeenPostingShouldBeDisplayedOnMyListings()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/section[1]/div/a[3]")).Click();
            Thread.Sleep(1000);
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a shared skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Test Analyst";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr/td[3]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a shared skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SharedSkillAdded");
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
