using System;
using Tests;


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            TestSuite Tests = new TestSuite();
            //COMMENT TO EXECUTE TEST TWO
            Tests.SetUp();
            Tests.test1();
            Tests.TearDown();


            //UNCOMMENT TO EXECUTE TEST TWO
            //     Tests.SetUp();
            //     Tests.test2();
            //     Tests.TearDown();
            //     Tests.Complete();
            // }
        }
    }
