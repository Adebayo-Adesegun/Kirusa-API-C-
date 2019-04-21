using System;
using System.Collections.Generic;
using System.Text;

namespace KonnectAPIC
{
    public class Request
    {
        // Unique transaction id for the request
        public string id { get; set; }
        //The sender phone number. If not specified, the default sender id is used.
        public string from { get; set; }
        // The destination phone number, multiple phone numbers should be passed as a JSON array separated by comma.
        public List<string> to { get; set; }
        // The string to mask the sender.
        public string sender_mask { get; set; }
       // The full text of the message
        public string body { get; set; }

    }

}
