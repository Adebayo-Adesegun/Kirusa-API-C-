using System;
using System.Collections.Generic;

namespace KonnectAPIC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Recipient Numbers
            List<string> num = new List<string>();
            num.Add("< Add number with country code>");
            num.Add("< Add number with country code>");

            #endregion
            #region Credentials
            string accountId = "< Account id from kirusa dashboard >";
            string authkey =  "< Auth key from kirusa dashboard >";
            #endregion

            #region Send SMS
            RequestSMS sms = new RequestSMS();
            sms.Id = Guid.NewGuid().ToString();
            sms.To = num;
            sms.Body = "< Compose message to send as sms>";
            KonnectAPI konnect = new KonnectAPI(authkey, accountId);
            konnect.SendSMS(sms).Wait();
            #endregion



            #region SEND VOICE
            RequestVoice voice = new RequestVoice();
            voice.id = Guid.NewGuid().ToString();
            voice.recipient = num;
            voice.caller_id = "< OBD number from kirusa dashboard >";
            voice.media_url = "< link to recording eg https://myapp.com/recordings.mp3>";
            voice.direction = "outbound";

    
            KonnectAPI kon = new KonnectAPI(authkey, accountId);
            kon.SendVoice(voice).Wait();
            Console.WriteLine("Operation completed");
            Console.ReadLine();
            #endregion

        }
    }
}
