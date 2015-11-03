using System.ComponentModel.DataAnnotations;
using TRex.Metadata;

namespace QuickLearn.ApiApps.TwiMLMessageResponse.Models
{
    public class MessageContent
    {

        [Metadata("SMS Message Text", "Text of the SMS message to send")]
        [Required]
        public string Text { get; set; }

        [Metadata("To", "Number to which the message will be sent", VisibilityType.Advanced)]
        public string To { get; set; }

        [Metadata("From", "Twilio number from which the message will be sent", VisibilityType.Advanced)]
        public string From { get; set; }

        [Metadata("Action", "Twilio will make a GET or POST request to this URL with the form parameters 'MessageStatus' and 'MessageSid'.", VisibilityType.Advanced)]
        public string Action { get; set; }

        [Metadata("Method", "Should be either 'GET' or 'POST'. This tells Twilio whether to request the 'action' URL via HTTP GET or POST", VisibilityType.Advanced)]
        public Method Method { get; set; }

        [Metadata("Status Callback", "The 'statusCallback' attribute takes a URL as an argument. When the message is actually sent, or if sending fails, Twilio will make an asynchronous POST request to this URL.", VisibilityType.Advanced)]
        public string StatusCallbackUrl { get; set; }
    }
}
