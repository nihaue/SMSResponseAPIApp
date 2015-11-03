using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRex.Metadata;

namespace QuickLearn.ApiApps.TwiMLMessageResponse.Models
{
    public class GeneratedMessage
    {
            [Metadata("TwiML Message", "TwiML output wrapping the input content")]
            public string TwiMLMessage { get; set; }
    }
}
