using SpecFlowProject_Wipfli.DataLibraries.DataVariables;
using System.Xml;

namespace SpecFlowProject_Wipfli.Utilities
{
    internal class XmlReader
    {
        private static string _username;
        private static string _password;
        private static string excelfilePath = @"DataLibraries\DataFiles\TestData.xml";  

        public static void ReadXmlData()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(excelfilePath);

            XmlNodeList nodes = xdoc.SelectNodes("//Root/Row");
            foreach (XmlNode node in nodes)
            {
                string TestCaseNumber = node.SelectSingleNode("TestCaseNumber").InnerText;
                if (TestCaseNumber == "1")
                {
                    _username = node.SelectSingleNode("Username").InnerText;
                    _password = node.SelectSingleNode("Password").InnerText;
                    StoreDataValuesToVariables.SetVariablesWithValues(_username, _password);
                }
            }
        }
    }
}
