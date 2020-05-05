using System;
namespace Tests
{
    public class TestSuite : Base
    {
        public TestSuite()
        {
            report.testStart("Automation");
        }
        public void test1()
        {

            Base.launchSite("http://news.google.com/");
            driver.Manage().Window.Maximize();
            printHeadLines headLines = new printHeadLines();

        }

        public void test2()
        {

            Base.launchSite("https://www.hippodromeonline.com/ ");
            driver.Manage().Window.Maximize();
            RegisterForm headLines = new RegisterForm();



        }
    }

}