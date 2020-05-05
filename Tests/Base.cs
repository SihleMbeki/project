using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Tests;

namespace Tests
{

    public class Base
    {
        public static csvUtil report;
        public Base()
        {
            report = new csvUtil();
        }
        public static IWebDriver driver;
        public void SetUp()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);


        }

        public void TearDown()
        {
            driver.Quit();
           
        }
        public void Complete(){
             report.testComplete();
        }
        public static void launchSite(String url)
        {
            
            try
            {
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static bool ClickElement(By selector)
        {
            try
            {
                IWebElement element = driver.FindElement(LocateElement(selector));
                element.Click();
                return true;
            }
            catch (Exception e)
            {
                report.StepFailed(e.ToString(), "Failed");
                return false;
            }
        }
        public void pause(int waitTime)
        {
            Thread.Sleep(waitTime);
        }
        public bool ClickElementJS(By selector)
        {
            try
            {
                IWebElement element = driver.FindElement(LocateElement(selector));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click()", element);
                return true;
            }
            catch(Exception e)
            {
                report.StepFailed(e.ToString(), "Failed");
                return false;
            }
        }
        public bool EnterText(By selector, string text)
        {
            try
            {
                IWebElement element = driver.FindElement(LocateElement(selector));
                element.Clear();
                element.SendKeys(text);
                return true;
            }
            catch(Exception e)
            {
                report.StepFailed(e.ToString(), "Failed");
                return false;
            }
        }

        public static By LocateElement(By selector)
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(drv => drv.FindElement(selector));
                wait.Until(drv => drv.FindElement(selector).Displayed);
                wait.Until(drv => drv.FindElement(selector).Enabled);

                return selector;
            }
            catch (Exception e)
            {
                report.StepFailed(e.ToString(), "Failed");
                throw;
            }

        }
        public static bool WaitForElementByXPath(By selector, int seconds)
        {
            try
            {
                if (!driver.FindElement(selector).Displayed)
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(drv => drv.FindElement(selector));
                    wait.Until(drv => drv.FindElement(selector).Displayed);
                    wait.Until(drv => drv.FindElement(selector).Enabled);
                }
            }
            catch (Exception e)
            {
                report.StepFailed(e.ToString(), "Failed");
                return false;
            }
            return true;
        }
    }
}