using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_Wipfli.APISupport.Model.Response
{
    public class CreateUserResponse
    {
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
    }

}
