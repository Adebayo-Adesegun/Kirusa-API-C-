using System;
using System.Collections.Generic;
using System.Text;

namespace KonnectAPIC
{
    public class RequestVoice
    {
        // Unique transaction id for the request
        public string id { get; set; }
        public List<string> recipient { get; set; }
        public string caller_id { get; set; }
        public string direction { get; set; }
        public string media_url { get; set; }
    }
}
