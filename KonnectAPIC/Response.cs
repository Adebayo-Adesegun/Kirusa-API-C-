using System;
using System.Collections.Generic;
using System.Text;

namespace KonnectAPIC
{
    public class Response
    {
        public string status { get; set; }
        public string error_code { get; set; }
        public string error_reason { get; set; }
    }
}
