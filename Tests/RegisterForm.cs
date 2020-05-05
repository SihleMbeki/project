using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Tests
{

    public class RegisterForm : Base
    {
        public RegisterForm()
        {
            executeTest();

        }

        public static void executeTest()
        {
              report.stepPassed("Register Test", "");
            if (WaitForElementByXPath(By.XPath("//a[@ng-href='#/register']"), 10))
            {
                report.stepPassed("Home page loaded", "Passed");
            }

            if (ClickElementJS(By.XPath("//a[@ng-href='#/register']")))
            {
                report.stepPassed("Clicked Register", "Passed");
            }

            pause(2000);
            //int handle=driver.WindowHandles.IndexOf("1").;
            // foreach (var handle in driver.WindowHandles)
            // {
            //     driver.SwitchTo().Window(handle);

            // }
            report.stepPassed("Register Page Loaded", "Passed");
            if (EnterText(By.XPath("//input[@id='UserName']"), "Masakhane"))
            {
                report.stepPassed("Entered username", "Passed");
            }
            if (EnterText(By.XPath("//input[@id='Email']"), "test@gmail.com"))
            {
                report.stepPassed("Entered email address", "Passed");
            }

            if (EnterText(By.XPath("//input[@id='Password']"), "@#$TEStingP73assword"))
            {
                report.stepPassed("Entered password", "Passed");
            }

            if (EnterText(By.XPath("//input[@id='ConfirmPassword']"), "@#$TEStingP73assword"))
            {
                report.stepPassed("Entered confirm password", "Passed");
            }

            if (ClickElement(By.XPath("(//div[@class='modal-buttonContainer']//button[text()='Next'])[1]")))
            {
                report.stepPassed("Clicked Next", "Passed");
            }

            if (WaitForElementByXPath(By.XPath("//input[@id='FirstName']"), 10))
            {
                report.stepPassed("Personal details section loaded", "Passed");
            }
            pause(2000);
            if (EnterText(By.XPath("//input[@id='FirstName']"), "Masakhane"))
            {
                report.stepPassed("Entered First Name", "Passed");
            }
            if (EnterText(By.XPath("//input[@id='LastName']"), "Mathe"))
            {
                report.stepPassed("Entered Last Name", "Passed");
            }
            //driver.FindElement(By.XPath("//select[@id='DateOfBirth_Day']")).SendKeys(Keys.Down);
            //  driver.FindElement(By.XPath("//select[@id='DateOfBirth_Day']")).SendKeys(Keys.Enter);

            if (selectDropDown("//select[@id='DateOfBirth_Day']", "//option[text()='17']"))
            {
                report.stepPassed("Day of the birth selected", "Passed");
            }

            if (selectDropDown("//select[@id='DateOfBirth_Month']", "//option[@value='10']"))
            {
                report.stepPassed("Month of the birth selected", "Passed");
            }

            if (selectDropDown("//select[@id='DateOfBirth_Year']", "//option[@value='2002']"))
            {
                report.stepPassed("Year of the birth selected", "Passed");
            }
            driver.FindElement(By.XPath("//select[@id='DateOfBirth_Year']")).SendKeys(Keys.Tab);
            if (ClickElement(By.XPath("(//button[@class='modal-button_next' and text()='Next'])[2]")))
            {
                report.stepPassed("Clicked Next", "Passed");
            }
            if (WaitForElementByXPath(By.XPath("//input[@id='ZipCode']"), 10))
            {
                report.stepPassed("loaded contact details section", "Passed");
            }

            if (EnterText(By.XPath("//input[@id='ZipCode']"), "47545"))
            {
                report.stepPassed("Entered zipcode", "Passed");
            }
            //input[@id='ZipCode']
             if (EnterText(By.XPath("//input[@id='Address1']"), "1 street london"))
            {
                report.stepPassed("Entered zipcode", "Passed");
            }
            //input[@id='Address1']
              if (EnterText(By.XPath("//input[@id='MobileTelephoneNumber']"), "02145789"))
            {
                report.stepPassed("Entered phone number", "Passed");
            }
            //input[@id='MobileTelephoneNumber']
             if (ClickElement(By.XPath("//label[@id='TermsAndConditionsAccepted_Label']")))
            {
                report.stepPassed("Selected terms and conditions", "Passed");
            }
            //input[@data-val-istrue='Please accept terms and conditions']
             if (ClickElement(By.XPath("//button[@id='register-submit-button']")))
            {
                report.stepPassed("Clicked register", "Passed");
            }
            pause(4000);
            //button[@id='register-submit-button']


            pause(2000);
            // driver.WindowHandles.

            //   String first_window = iterate.next();


        }

    }
}