using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlogLab.Models.Exception
{
    public class ApiException
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

        }
    }
}
