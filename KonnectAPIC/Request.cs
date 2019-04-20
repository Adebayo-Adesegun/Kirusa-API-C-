using System;
using System.Collections.Generic;
using System.Text;

namespace KonnectAPIC
{
    public class Request
    {
        public string id { get; set; }
        public string from { get; set; }
        public List<string> to { get; set; }
        public string sender_mask { get; set; }
        public string body { get; set; }

    }

}
