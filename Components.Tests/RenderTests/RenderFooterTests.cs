﻿using System;
using FluentAssertions;
using Xunit;
using AutoFixture.Xunit2;
using System.Collections.Generic;
using GoC.WebTemplate.Components.Entities;
using GoC.WebTemplate.Components.Utils.Caching;
using GoC.WebTemplate.Components.Configs.Cdts;

namespace GoC.WebTemplate.Components.Test.RenderTests
{
    public class RenderFooterTests
    {

        [Theory, AutoNSubstituteData]
        public void ContactLinksShoulNotRenderWhenNull(Model sut)
        {
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[]");
        }

        [Theory, AutoNSubstituteData]
        public void ContactLinksShoulNotRenderWhenEmpty(Model sut)
        {
            sut.ContactLinks = new List<Link>();
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[]");
        }

        [Theory, AutoNSubstituteData]
        public void ContactLinksHrefMustBeSpecifieds(Model sut)
        {
            sut.ContactLinks = new List<Link> { new Link() };
            Action act = () => sut.Render.Setup();
            act.Should().Throw<InvalidOperationException>().WithMessage("Href must be specified");
        }

        [Theory, AutoNSubstituteData]
        public void ContactLinksShouldNotBeEmptyWhenValueIsSet(Model sut)
        {
            sut.ContactLinks = new List<Link> { new Link() { Href = "foo" } };
            sut.Render.Setup().ToString().Should().NotContain("\"contactLinks\":[{}]")
              .And.Contain("\"contactLinks\":[{\"href\":\"foo\"}]");

        }

        [Theory, AutoNSubstituteData]
        public void ContactLinkSetTextAKAMAI([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "AKAMAI",
                Theme = "gcweb"
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Text = "LinkText" } };
            sut.Settings.GcToolsModal = false;
            Action act = () => sut.Render.Setup();
            act.Should().Throw<InvalidOperationException>().WithMessage("Unable to edit Contact Link text in this environment");
        }

        [Theory, AutoNSubstituteData]
        public void ContactLinkSetTextPRODSSL([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "PROD_SSL",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" } };
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void ContactLinkSetTextESDCProd([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "ESDC_PROD",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            sut.Settings.UseHttps = true;
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" } };
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void TransactionalFooterContactLinkSetTextAKAMAI([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "AKAMAI",
                Theme = "gcweb"
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Text = "LinkText" } };
            sut.Settings.GcToolsModal = false;
            Action act = () => sut.Render.TransactionalSetup();
            act.Should().Throw<InvalidOperationException>().WithMessage("Unable to edit Contact Link text in this environment");
        }

        [Theory, AutoNSubstituteData]
        public void TransactionalFooterContactLinkSetTextPRODSSL([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "PROD_SSL",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" } };
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void TransactionalFooterContactLinkSetTextESDCProd([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "ESDC_PROD",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            sut.Settings.UseHttps = true;
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" } };
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void MultipleContactLinksAKAMAI([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "AKAMAI",
                Theme = "gcweb"
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" }, new Link() { Href = "TestLink2", Text = "Link2" } };
            sut.Settings.GcToolsModal = false;
            Action act = () => sut.Render.Setup();
            act.Should().Throw<InvalidOperationException>().WithMessage("Having multiple contact links not allowed in this environment");
        }


        [Theory, AutoNSubstituteData]
        public void MultipleContactLinksPRODSSL([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "PROD_SSL",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" }, new Link() { Href = "TestLink2", Text = "Link2" } };
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"},{\"href\":\"TestLink2\",\"text\":\"Link2\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void MultipleContactLinksESDCProd([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "ESDC_PROD",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" }, new Link() { Href = "TestLink2", Text = "Link2" } };
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"},{\"href\":\"TestLink2\",\"text\":\"Link2\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void TransactionalFooterMultipleContactLinksAKAMAI([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "AKAMAI",
                Theme = "gcweb",
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" }, new Link() { Href = "TestLink2", Text = "Link2" } };
            sut.Settings.GcToolsModal = false;
            Action act = () => sut.Render.TransactionalSetup();
            act.Should().Throw<InvalidOperationException>().WithMessage("Having multiple contact links not allowed in this environment");
        }

        [Theory, AutoNSubstituteData]
        public void TransactionalFooterMultipleContactLinksPRODSSL([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "PROD_SSL",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" }, new Link() { Href = "TestLink2", Text = "Link2" } };
            sut.Render.TransactionalSetup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"},{\"href\":\"TestLink2\",\"text\":\"Link2\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void TransactionalFooterMultipleContactLinksESDCProd([Frozen]ICdtsCacheProvider cdtsCacheProvider, Model sut)
        {
            var currentEnv = new CdtsEnvironment
            {
                Name = "ESDC_PROD",
                Theme = "gcintranet",
                CanHaveMultipleContactLinks = true
            };
            sut.Settings.UseHttps = true;
            new CdtsEnvironmentCache(cdtsCacheProvider).GetContent()[sut.Settings.Environment] = currentEnv;
            sut.ContactLinks = new List<Link>() { new Link() { Href = "TestLink1", Text = "Link1" }, new Link() { Href = "TestLink2", Text = "Link2" } };
            sut.Render.TransactionalSetup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"TestLink1\",\"text\":\"Link1\"},{\"href\":\"TestLink2\",\"text\":\"Link2\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void ShouldNotEncodeURL(Model sut)
        {
            sut.ContactLinks = new List<Link>() { new Link { Href = "http://localhost:8080/foo.html" } };
            var htmlstring = sut.Render.Setup();
            htmlstring.ToString().Should().Contain("http://localhost:8080/foo.html");
        }

        [Theory, AutoNSubstituteData]
        public void ExceptionWhenCallingRenderFooterLinks(Model sut)
        {
            Action execute = () =>
            {
                var ignore = sut.Render.Setup();
            };
            execute.Should().NotThrow<NullReferenceException>();

        }

        [Theory, AutoNSubstituteData]
        public void HandleEmptyContactLinkList(Model sut)
        {
            sut.ContactLinks = new List<Link>();
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[]");
        }

        [Theory, AutoNSubstituteData]
        public void HandleContactLinkValue(Model sut)
        {
            sut.ContactLinks = new List<Link>() { new Link() { Href = "http://testvalue" } };
            sut.Render.Setup().ToString().Should().Contain("\"contactLinks\":[{\"href\":\"http://testvalue\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void HideMainCorporateFooter(Model sut)
        {
            sut.HideFooterMain = true;
            sut.HideFooterCorporate = true;
            sut.Render.Setup().ToString().Should().Contain("\"hideFooterMain\":true,\"hideFooterCorporate\":true");
        }

        [Theory, AutoNSubstituteData]
        public void ShowContextualFooter(Model sut)
        {
            List<Link> links = new List<Link>
            {
                new Link() {Text = "Link 1", Href = "google"},
                new Link() {Text = "Link 2", Href = "google", NewWindow = true}
            };

            sut.ContextualFooter = new ContextualFooter() { Links = links, Title = "Contextual" };
            sut.Render.Setup().ToString().Should().Contain("\"contextualFooter\":{\"title\":\"Contextual\",\"links\":[{\"href\":\"google\",\"text\":\"Link 1\"},{\"href\":\"google\",\"text\":\"Link 2\",\"newWindow\":true}]");
        }

        /// <summary>
        /// This is testing that the footer (when showFooter = true) renders the privacyLink and the termsLink as a single object
        /// </summary>
        [Theory, AutoNSubstituteData]
        public void ModifyTermsPrivacyLink(Model sut)
        {
            sut.PrivacyLink = new FooterLink() { Href = "google" };
            sut.TermsConditionsLink = new FooterLink() { Href = "google" };
            sut.Render.Setup().ToString().Should().Contain("\"privacyLink\":{\"href\":\"google\"},\"termsLink\":{\"href\":\"google\"}");
        }

        /// <summary>
        /// This is testing that the transactional footer (when showFooter = false) renders the privacyLink and the termsLink as an array
        /// </summary>
        [Theory, AutoNSubstituteData]
        public void ModifyTermsPrivacyLinkTransactionalFooter(Model sut)
        {
            sut.PrivacyLink = new FooterLink() { Href = "google" };
            sut.TermsConditionsLink = new FooterLink() { Href = "google" };
            sut.Render.TransactionalSetup().ToString().Should().Contain("\"privacyLink\":[{\"href\":\"google\"}],\"termsLink\":[{\"href\":\"google\"}]");
        }
    }
}