using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;

namespace Tests
{
    public class csvUtil
    {

        List<columns> records;
        string directory;
        public csvUtil()
        {
            directory = Environment.CurrentDirectory + "\\Report";
            records = new List<columns>
            {
        new columns { Action = "Automation", Status = ""},
         };



        }
        public void testStart(string testName)
        {


        }
        public void stepPassed(String step, String status)
        {
            var temp = new columns { Action = step, Status = "Passed" };
            records.Add(temp);
        }
        public void StepFailed(String step, String status)
        {
            var temp = new columns { Action = step, Status = "Passed" };
            records.Add(temp);

        }
        public void testComplete()
        {
            var temp = new columns { Action = "Test Complete", Status = "" };

            records.Add(temp);
            using (var writer = new StreamWriter(directory + "\\Report.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }


    }

    public class columns
    {
        public string Action { get; set; }
        public string Status { get; set; }
    }
}