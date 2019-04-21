using System;
using System.Collections.Generic;

namespace KonnectAPIC
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> num = new List<string>();
            num.Add("+2347066576295");
            num.Add("+2348099229834");
            num.Add("+2347034832618");
            num.Add("+2347085626242");
            num.Add("+2347013251237");


            string accountId = "vS36AafGOOkZcUjIQQqwSQ==";
            string authkey = "OJug6FFgXObsKNg83TJsXwm_TK0v3YZlPwFJlaBe5uo= "; 
            

            Request req = new Request();
            req.id = Guid.NewGuid().ToString();
            req.to = num;
            req.body = "Kirusa: Test Bulk Message from Adebayo Adesegun Daniel.";


            KonnectAPI konnect = new KonnectAPI(authkey,accountId);
            konnect.SendSMS(req).Wait();


            Console.WriteLine("Operation completed");
            Console.ReadLine();

        }
    }
}
