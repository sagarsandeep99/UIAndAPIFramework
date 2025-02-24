using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_Wipfli.Utilities
{
    public class GetFilePath
    {
        public static string FilePath(string name) 
        {
            string path = @"..\..\..\" + name;
            return path;
        }
    }
}