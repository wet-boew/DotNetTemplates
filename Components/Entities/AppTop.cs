using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoC.WebTemplate.Components.Entities
{
    public class AppTop : ITop
    {
        /// <summary>
        /// This is an array but it should only have one item in it. 
        /// </summary>
        public List<Link> AppName { get; set; }
        public string MenuPath { get; set; }
        public string CdnEnv { get; set; }
        public List<CustomSearch> CustomSearch { get; set; }
        public List<LanguageLink> LngLinks { get; set; }
        public List<Link> AppSettings { get; set; }
        /// <summary>
        /// This is an array but it should only have one item in it. 
        /// </summary>
        public List<Link> SignIn { get; set; }
        /// <summary>
        /// This is an array but it should only have one item in it. 
        /// </summary>
        public List<Link> SignOut { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Search { get; set; }
        public List<Breadcrumb> Breadcrumbs { get; set; }
        public string SubTheme { get; set; }
        public bool ShowPreContent { get; set; }
        public string LocalPath { get; set; }

        [JsonProperty(DefaultValueHandling=DefaultValueHandling.Include)]
        public bool TopSecMenu { get; set; }
        public List<MenuLink> MenuLinks { get; set; }
        public InfoBanner InfoBanner { get; set; }
        public HeaderMenu HeaderMenu { get; set; }
    }
}