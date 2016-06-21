using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProgectTemplate.IoC;
using ProgectTemplate.WebApi.Helpers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProgectTemplate.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Elmah
            config.Filters.Add(new ElmahErrorAttribute());
            
            // Web API configuration and services
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Força retorno sempre JSON, removendo tipo de retorno XML.
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            jsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            Bootstrap.RegisterServices(ImplementationType.API, config);
           
        }
    }
}
