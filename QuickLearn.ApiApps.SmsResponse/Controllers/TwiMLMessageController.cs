using QuickLearn.ApiApps.TwiMLMessageResponse.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Linq;
using TRex.Metadata;

namespace QuickLearn.ApiApps.TwiMLMessageResponse.Controllers
{
    [RoutePrefix("TwiML")]
    public class TwiMLMessageController : ApiController
    {

        [HttpPost]
        [Route("MessageContent")]
        [Metadata("Generate TwiML Message", "Generates TwiML for a message to be sent as an SMS response")]
        public GeneratedMessage GenerateMessage([FromBody]MessageContent messageContent)
        {
            XDocument doc = new XDocument();
            doc.Add(new XElement("Response"));

            XElement message = new XElement("Message");
            message.Add(messageContent.Text);

            if (!string.IsNullOrWhiteSpace(messageContent.To))
            {
                message.Add(new XAttribute("to", messageContent.To));
            }

            if (!string.IsNullOrWhiteSpace(messageContent.From))
            {
                message.Add(new XAttribute("from", messageContent.From));
            }

            if (!string.IsNullOrWhiteSpace(messageContent.Action))
            {
                message.Add(new XAttribute("action", messageContent.Action));
                message.Add(new XAttribute("method", messageContent.Method));
            }

            if (!string.IsNullOrWhiteSpace(messageContent.StatusCallbackUrl))
            {
                message.Add(new XAttribute("statusCallback", messageContent.StatusCallbackUrl));
            }

            doc.Root.Add(message);

            using (MemoryStream outputStream = new MemoryStream())
            {
                doc.Save(outputStream);
                return new GeneratedMessage()
                {
                    TwiMLMessage = Encoding.UTF8.GetString(outputStream.ToArray())
                };
            }
        }

    }
}
