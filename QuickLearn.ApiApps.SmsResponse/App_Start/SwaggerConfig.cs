using System.Web.Http;
using Swashbuckle.Application;
using WebActivatorEx;
using QuickLearn.ApiApps.TwiMLMessageResponse;
using TRex.Metadata;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace QuickLearn.ApiApps.TwiMLMessageResponse
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.DescribeAllEnumsAsStrings(false);
                        c.SingleApiVersion("v1", "TwiMLMessageResponse");
                        c.ReleaseTheTRex();
                            })
                        .EnableSwaggerUi(c =>
                            {
                    });
        }
    }
}