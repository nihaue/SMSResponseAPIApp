using System.Web.Http;

namespace QuickLearn.ApiApps.TwiMLMessageResponse
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
