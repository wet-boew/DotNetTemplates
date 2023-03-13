using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using GoC.WebTemplate.Components.Configs;
using GoC.WebTemplate.Components.Configs.Cdts;
#if NETCOREAPP
    using Microsoft.AspNetCore.Html;
#elif NETFRAMEWORK
    using System.Web;
#endif

namespace GoC.WebTemplate.Components.Utils
{
    public static class JsonSerializationHelper
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            },
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml
        };

        /// <summary>
        /// Basic json serialization using the settings that work with the CDTS google closure templates
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HtmlString SerializeToJson(object value)
        {
            return new HtmlString(JsonConvert.SerializeObject(value, Settings));
        }
    }
}