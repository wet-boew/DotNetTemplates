using System.Collections.Generic;

namespace GoC.WebTemplate.Components.Entities
{
    internal class AppFooter
    {
        public string CdnEnv { get; set; }
        public List<IFooterSection> FooterSections { get; set; }
        public List<Link> ContactLink { get; set; }
        public List<FooterLink> TermsLink { get; set; }
        public List<FooterLink> PrivacyLink { get; set; }
        public string SubTheme { get; set; }
        public string LocalPath { get; set; }
    }
}