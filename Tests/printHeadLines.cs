using System.Collections.Generic;
using OpenQA.Selenium;

namespace Tests
{

    public class printHeadLines : Base
    {
        public printHeadLines()
        {
            executeTest();

        }

        public static void executeTest()
        {
            if (WaitForElementByXPath(By.XPath("//a[text()='Headlines']"), 10))
            {
                report.stepPassed("Headline loaded", "Passed");
            }

           IList<IWebElement>  list=driver.FindElements(By.XPath("//h3//parent::article/h3/a"));
           foreach(IWebElement item in list){
         // String text=driver.FindElement(By.XPath("//h3//parent::article/h3/a)[2]")).Text;
               report.stepPassed(item.Text, "Passed");

           }

        }
    }
}