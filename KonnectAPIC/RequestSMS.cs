using System;
using System.Collections.Generic;
using System.Text;

namespace KonnectAPIC
{
    public class RequestSMS
    {
        // Unique transaction id for the request
        public string Id { get; set; }
        //The sender phone number. If not specified, the default sender id is used.
        public string From { get; set; }
        // The destination phone number, multiple phone numbers should be passed as a JSON array separated by comma.
        public List<string> To { get; set; }
        // The string to mask the sender.
        public string Sender_mask { get; set; }
       // The full text of the message
        public string Body { get; set; }

    }

}
