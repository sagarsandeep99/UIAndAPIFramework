using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_Wipfli.Utilities
{
    public class HandleAPIContent
    {
        public static T GetContent<T>(RestResponse response) where T : class 
        {
            var content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static T ParseJson<T>(string file)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }
    }
}
