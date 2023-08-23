﻿using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using AutoFixture.Xunit2;
using GoC.WebTemplate.Components.Entities;
using GoC.WebTemplate.Components.Configs.Cdts;
using NSubstitute;

namespace GoC.WebTemplate.Components.Test.RenderTests
{
    public class RenderAppTopTests
    {
        [Theory, AutoNSubstituteData]
        public void MenuLinksShouldNotRenderWhenNull(Model sut)
        {
            sut.MenuLinks = null;
            sut.Render.AppSetup().ToString().Should().NotContain("menuLinks");
        }

        [Theory, AutoNSubstituteData]
        public void DoNotRenderNewWindowInMenuLinksIfFalse(Model sut)
        {
            sut.MenuLinks = new List<MenuLink>
            {
                new MenuLink
                {
                    Href = "foo",
                    Text = "bar",
                    NewWindow = false
                }
            };

            sut.Render.AppSetup().ToString().Should().Contain("\"menuLinks\":[{\"href\":\"foo\",\"text\":\"bar\"}]}");
        }

        [Theory, AutoNSubstituteData]
        public void RenderNewWindowInMenuLinksIfTrue(Model sut)
        {
            sut.MenuLinks = new List<MenuLink>
      {
        new MenuLink
        {
          Href = "foo",
          Text = "bar",
          NewWindow = true
        }
      };

            sut.Render.AppSetup().ToString().Should().Contain("\"menuLinks\":[{\"href\":\"foo\",\"text\":\"bar\",\"newWindow\":true}]}");
        }

        [Theory, AutoNSubstituteData]
        public void MenuLinks(Model sut)
        {
            sut.MenuLinks = new List<MenuLink>
      {
        new MenuLink
        {
          Href = "foo",
          Text = "bar",
          Acronym = "baz"
        }
      };

            sut.Render.AppSetup().ToString().Should().Contain("\"menuLinks\":[{\"href\":\"foo\",\"text\":\"bar\",\"acronym\":\"baz\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void SubLinks(Model sut)
        {
            sut.MenuLinks = new List<MenuLink>
            {
                new MenuLink
                {
                    Text = "MenuLink",
                    SubLinks = new List<SubLink>
                    {
                        new SubLink
                        {
                            Text = "SubLinkText1",
                            Href = "SubLinkHerf1",
                            NewWindow = true,
                            Acronym = "baz"

                        }
                    }
                }
            };
            var result = sut.Render.AppSetup();

            result.ToString().Should().Contain("\"menuLinks\":[{\"subLinks\":[{\"subhref\":\"SubLinkHerf1\",\"subtext\":\"SubLinkText1\",\"acronym\":\"baz\",\"newWindow\":true}],\"text\":\"MenuLink\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void ThrowExceptionIfMenuLinksAndCustomMenuURLAreBothSet(Model sut)
        {
            sut.MenuLinks = new List<MenuLink> { new MenuLink() };
            sut.CustomSiteMenuURL = "Foo";

            // ReSharper disable once MustUseReturnValue
            Action act = () => sut.Render.AppSetup();

            act.Should().Throw<InvalidOperationException>();
        }


        [Theory]
        [InlineAutoNSubstituteData("GCWeb")]
        [InlineAutoNSubstituteData("GCTheme")]
        public void AppNameAndAppURLRenderedSameBetweenGCWebandGCIntranet(string theme, [Frozen] ICdtsEnvironment fakeEnvironment, Model sut)
        {

            fakeEnvironment.Theme = theme;
            sut.ApplicationTitle.Text = "foo";
            sut.ApplicationTitle.Href = "bar";


            sut.Render.AppSetup().ToString()
              .Should().Contain("\"appName\":[{\"href\":\"bar\",\"text\":\"foo\"}]");
        }
        [Theory, AutoNSubstituteData]
        public void AppSettingsLinkRendersWhenPresent(Model sut)
        {
            //Setup
            var testurl = "http://tempuri.com";
            sut.AppSettingsURL = testurl;
            //Test
            var results = sut.Render.AppSetup();
            //Verify
            results.ToString().Should().Contain("\"appSettings\":[{\"href\":\"" + testurl + "\"}]");
        }

        [Theory, AutoNSubstituteData]
        public void AppSettingsLinkShouldNotRendersWhenPresent(Model sut)
        {
            //Setup           
            sut.AppSettingsURL = null;
            //Test
            var results = sut.Render.AppSetup();
            //Verify
            results.ToString().Should().NotContain("\"appSettings\"");
        }

        [Theory, AutoNSubstituteData]
        public void TopSecMenuTrueInAppTopWhenLeftMenuItems(Model sut)
        {
            sut.LeftMenuItems = new List<MenuSection>();
            sut.LeftMenuItems.Add(new MenuSection
            {
                Href = "foo",
                Text = "bar"
            });
            sut.Render.AppSetup().ToString().Should().Contain("\"topSecMenu\":true");
        }

        [Theory, AutoNSubstituteData]
        public void TopSecMenuFalseInAppTopWhenLeftMenuItems(Model sut)
        {
            sut.Render.AppSetup().ToString().Should().Contain("\"topSecMenu\":false");
        }

        [Theory, AutoNSubstituteData]
        public void IntranetTitleShouldNotRenderWhenNullInAppTop(Model sut)
        {
            sut.IntranetTitle = null;
            sut.Render.AppSetup().ToString().Should().NotContain("\"intranetTitle\":[null]");
        }

        [Theory, AutoNSubstituteData]
        public void IntranetTitleAppTop(Model sut)
        {
            sut.IntranetTitle = new IntranetTitle { Text = "foo", Href = "bar", Acronym = "plat" };
            sut.Render.AppSetup().ToString().Should().Contain("\"intranetTitle\":[{\"href\":\"bar\",\"text\":\"foo\",\"acronym\":\"plat\"}]");
        }
        
        [Theory, AutoNSubstituteData]
        public void RenderCustomSearchWhenSet(Model sut)
        {
            sut.CustomSearch = new CustomSearch
            {
                Action = "action1",
                Id = "id3",
                Method = "method4",
                Placeholder = "placeholder5",
                Name = "name6",
                HiddenInput = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("name1", "val1"),
                    new KeyValuePair<string, string>("name2", "val2")
                }
            };

            var json = sut.Render.AppSetup();
            json.ToString().Should().Contain("\"customSearch\":[{\"action\":\"action1\",\"placeholder\":\"placeholder5\",\"id\":\"id3\",\"method\":\"method4\",\"name\":\"name6\",\"hiddenInput\":[{\"name\":\"name1\",\"value\":\"val1\"},{\"name\":\"name2\",\"value\":\"val2\"}]}]");
        }
        
        [Theory, AutoNSubstituteData]
        public void RenderCustomSearchNotSet(Model sut)
        {
            var json = sut.Render.AppSetup();
            json.ToString().Should().NotContain("customSearch");
        }
        
        [Theory, AutoNSubstituteData]
        public void AppSearchIsNullByDefault(Model sut)
        {
            var json = sut.Render.AppSetup();
            json.ToString().Should().NotContain("\"Search\"");
        }

        [Theory, AutoNSubstituteData]
        public void RenderAppTopMustNotCrashWithNullBreadCrumbs(Model sut)
        {
            sut.Breadcrumbs = null;
            // ReSharper disable once MustUseReturnValue
            Action execute = () => sut.Render.AppSetup();
            execute.Should().NotThrow<ArgumentNullException>();
        }

        [Theory, AutoNSubstituteData]
        public void SiteMenuPathShouldNotRenderWhenNull(Model sut)
        {
            var json = sut.Render.AppSetup();
            json.ToString().Should().NotContain("menuPath");
        }

        [Theory, AutoNSubstituteData]
        public void SignInLinkNotRenderedWhenFlagisFalse(Model sut)
        {

            sut.ShowSignInLink = false;
            var json = sut.Render.AppSetup();
            json.ToString().Should().NotContain("signIn");
        }

        [Theory, AutoNSubstituteData]
        public void SignInLinkNotRenderedWhenLinkIsNull(Model sut)
        {

            sut.ShowSignInLink = true;
            sut.Settings.SignInLinkUrl = null;
            var json = sut.Render.AppSetup();
            json.ToString().Should().NotContain("signIn");
        }

        [Theory, AutoNSubstituteData]
        public void SignOutLinkNotRenderedWhenFlagisFalse(Model sut)
        {

            sut.ShowSignOutLink = false;
            var json = sut.Render.AppSetup();
            json.ToString().Should().NotContain("signOut");
        }

        [Theory, AutoNSubstituteData]
        public void SignOutLinkNotRenderedWhenLinkIsNull(Model sut)
        {

            sut.ShowSignOutLink = true;
            sut.ShowSignInLink = false;
            sut.Settings.SignOutLinkUrl = null;
            var json = sut.Render.AppSetup();
            json.ToString().Should().NotContain("signOut");
        }

        [Theory, AutoNSubstituteData]
        public void SignInAndSignOutLinkBothOn(Model sut)
        {
            sut.ShowSignOutLink = true;
            sut.ShowSignInLink = true;
            // ReSharper disable once MustUseReturnValue
            Action act = () => sut.Render.AppSetup();
            act.Should().Throw<InvalidOperationException>();
        }

        [Theory, AutoNSubstituteData]
        public void LanguageLinkRenders(Model sut)
        {
            sut.LanguageLink.Href = "foo-en.lang";
            sut.Settings.ShowLanguageLink = true;
            var json = sut.Render.AppSetup();
            json.ToString().Should().Contain("\"lngLinks\":[{\"href\":\"foo-en.lang\"");
        }

        [Theory, AutoNSubstituteData]
        public void GcToolsMoalRendersInIntranet(Model sut)
        {
            sut.Settings.GcToolsModal = true;
            sut.CdtsEnvironment.Theme = "gcintranet";

            var result = sut.Render.AppSetup().ToString();
            result.Should().Contain("\"GCToolsModal\":true");
        }

        [Theory, AutoNSubstituteData]
        public void GcToolsMoalDoesntRenderInGcWeb(Model sut)
        {
            sut.Settings.GcToolsModal = true;
            sut.CdtsEnvironment.ThemeIsGCWeb().Returns(true);

            var result = sut.Render.AppSetup().ToString();
            result.Should().NotContain("GCToolsModal");
        }

        [Theory, AutoNSubstituteData]
        public void RenderInfoBanner(Model sut)
        {
            sut.CdtsEnvironment.ThemeIsGCWeb().Returns(true);
            sut.InfoBanner = new InfoBanner() { MainHTML = "Information Banner", Button = new Link() { Text = "Button", Href = "google" }, Link = new Link() { Text = "Link", Href = "google" } };

            var result = sut.Render.AppSetup().ToString();
            result.Should().Contain("\"infoBanner\":{\"mainHTML\":\"Information Banner\",\"link\":{\"href\":\"google\",\"text\":\"Link\"},\"button\":{\"href\":\"google\",\"text\":\"Button\"}");
        }

        [Theory, AutoNSubstituteData]
        public void RenderHeaderMenu(Model sut)
        {
            sut.CdtsEnvironment.ThemeIsGCWeb().Returns(true);
            sut.HeaderMenu = new HeaderMenu()
            {
                Text = "Menu",
                Links = new List<Components.Entities.Link>()
                {
                    new Link(){Href = "google", Text = "Link 1"},
                    new Link(){Href = "google", Text = "Link 2", NewWindow = true}
                },
                LogoutLink = new Link() { Text = "Logout", Href = "google" }
            };

            var result = sut.Render.AppSetup().ToString();
            result.Should().Contain("\"headerMenu\":{\"text\":\"Menu\",\"links\":[{\"href\":\"google\",\"text\":\"Link 1\"},{\"href\":\"google\",\"text\":\"Link 2\",\"newWindow\":true}],\"logoutLink\":{\"href\":\"google\",\"text\":\"Logout\"}}");
        }
    }
}