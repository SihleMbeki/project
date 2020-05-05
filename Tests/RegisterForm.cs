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
            if (WaitForElementByXPath(By.XPath("//a[@ng-href='#/register']"), 10))
            {
                report.stepPassed("Home page loaded", "Passed");
            }
            if (WaitForElementByXPath(By.XPath("//a[@ng-href='#/register']"), 10))
            {
                report.stepPassed("Home page loaded", "Passed");
            }

            if (ClickElement(By.XPath("//a[@ng-href='#/register']")))
            {
                report.stepPassed("Clicked Register", "Passed");
            }
            //int handle=driver.WindowHandles.IndexOf("1").;
            foreach (var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);

            }
            int w = driver.WindowHandles.Count;
            // driver.WindowHandles.

            //   String first_window = iterate.next();


        }
    }
}