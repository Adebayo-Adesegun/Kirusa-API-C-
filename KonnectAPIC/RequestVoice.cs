using System;
using System.Collections.Generic;
using System.Text;

namespace KonnectAPIC
{
    public class RequestVoice
    {
        // Unique transaction id for the request
        public string Id { get; set; }
        public List<string> Recipient { get; set; }
        public string Caller_id { get; set; }
        public string Media_url { get; set; }
    }
}
