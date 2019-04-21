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
            num.Add("+2347066576295");
            num.Add("+2349093438130");
            num.Add("+2348099229834");
            num.Add("+2347034832618");
            num.Add("+2347085626242");
            num.Add("+2347013251237");
            num.Add("+2348066342300");
            num.Add("+2347019780918");
            #endregion


            #region Credentials
            string accountId = "vS36AafGOOkZcUjIQQqwSQ==";
            string authkey = "OJug6FFgXObsKNg83TJsXwm_TK0v3YZlPwFJlaBe5uo= ";
            #endregion


            //#region Send SMS
            //RequestSMS sms = new RequestSMS();
            //sms.Id = Guid.NewGuid().ToString();
            //sms.To = num;
            //sms.Body = "Kirusa: Test Bulk Message from Adebayo Adesegun Daniel.";
            //KonnectAPI konnect = new KonnectAPI(authkey, accountId);
            //konnect.SendSMS(sms).Wait();
            //#endregion

            #region SEND VOICE
            RequestVoice voice = new RequestVoice();
            voice.id = Guid.NewGuid().ToString();
            voice.recipient = num;
            voice.caller_id = "+23417006120";
            voice.media_url = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3";
            voice.direction = "outbound";
            KonnectAPI kon = new KonnectAPI(authkey, accountId);
            kon.SendVoice(voice).Wait();
            #endregion



            Console.WriteLine("Operation completed");
            Console.ReadLine();

        }
    }
}
