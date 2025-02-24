﻿using SpecFlowProject_Wipfli.DataLibraries.DataVariables;

namespace SpecFlowProject_Wipfli.Utilities
{
    internal class CsvReader
    {
        private static string _username;
        private static string _password;
        private static string csvFilePath = @"DataLibraries\DataFiles\TestData.csv";      

        public static void ReadCsvData()
        {
            
            List<string> testCaseNo = new List<string>();
            List<string> username= new List<string>();
            List<string> password = new List<string>();


            string[] csvLines = File.ReadAllLines(csvFilePath);
            for (int i = 0; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(',');
                testCaseNo.Add(rowData[0]);
                username.Add(rowData[1]);
                password.Add(rowData[2]);
                if (testCaseNo[i] == "1")
                {
                    _username = username[i];
                    _password = password[i];
                    StoreDataValuesToVariables.SetVariablesWithValues(_username, _password);
                }
            }

            
        }
    }
}
