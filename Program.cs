using System;
using Tests;


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
       
            TestSuite Tests = new TestSuite();
      
            // Tests.SetUp();
            // Tests.test1();
            // Tests.TearDown();
            // Tests.Complete();
    

            Tests.SetUp();
            Tests.test2();
            Tests.TearDown();
               Tests.Complete();
        }
    }
}
