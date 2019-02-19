using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace WhatsappMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            TwilioClient.Init(
                Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID"),
                Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN")
            );

            var message = MessageResource.Create(
                from: new PhoneNumber("TWILIO_WHATSAPP_NUMBER"),
                to: new PhoneNumber("WHATSAPP_ENABLE_PHONE_NUMBER"),
                body: "Ahoy from Twilio!",
                mediaUrl: new List<Uri>{new Uri("URL_TO_IMAGE")}
            );

            Console.WriteLine("Message Sid" + message.Sid);
        }
    }
}
