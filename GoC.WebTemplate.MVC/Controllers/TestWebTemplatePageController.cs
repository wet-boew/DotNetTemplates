﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Globalization;
using GoC.WebTemplate.Components.Entities;

namespace GoC.WebTemplate.MVC.Controllers
{
    public class TestWebTemplatePageController : WebTemplateBaseController
    {

        public ActionResult LeftMenuSecure()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            WebTemplateModel.LeftMenuItems = new List<MenuSection>
            {
                new MenuSection
                {
                    Items = new List<MenuItem> { 
                        new MenuItem {
                            Href = "",
                            Text = "Menu Item 1"
                        }, new MenuItem {
                            Href= "#",
                            Text = "Menu Item 2"
                        }
                    } ,
                    Href = "#",
                    Text  = "MenuSection",
                    NewWindow = false
                },
                new MenuSection{
                    Text="Principale",
                    Items= new List<MenuItem> {
                        new MenuItem{
                            Href="linka",
                            Text="Secondaire",
                            SubItems= new List<Link> {
                                new Link{
                                    Href="linkb",
                                    Text="Tertiaire"
                                }
                            }
                        }
                    }
                }
            };
            return View("HelloWorldLeftMenu");
        }
        public ActionResult HelloWorld()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Web Template";
            WebTemplateModel.Breadcrumbs = null;
            return View();
        }

        public ActionResult StandardPage()
        {
            WebTemplateModel.AppSettingsURL = "http://tempuri.com";
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult Secure()
        {

            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult SignIn()
        {

            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            WebTemplateModel.ShowSignInLink = true;
            WebTemplateModel.Settings.SignInLinkUrl = "about//blank";
            return View("HelloWorld");
        }
        public ActionResult SignOut()
        {

            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            WebTemplateModel.ShowSignOutLink = true;
            WebTemplateModel.Settings.SignOutLinkUrl = "about//blank";
            return View("HelloWorld");
        }
        public ActionResult NoSearch()
        {

            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowSearch = false;
            WebTemplateModel.Settings.ShowPostContent = false;
            return View("HelloWorld");
        }
        public ActionResult NoMenu()
        {

            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult CustomMenu()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.CustomSiteMenuURL =
               "https://ssl-templates.services.gc.ca/app/cls/WET/gcweb/" + WebTemplateModel.Settings.Version + "/cdts/ajax/appmenu-en.html";

            WebTemplateModel.Settings.ShowPostContent = false;
            return View("HelloWorld");
        }
        public ActionResult SignInWithCustomMenu()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.CustomSiteMenuURL =
               "https://ssl-templates.services.gc.ca/app/cls/WET/gcweb/" + WebTemplateModel.Settings.Version + "/cdts/ajax/appmenu-en.html";

            WebTemplateModel.Settings.SignInLinkUrl = "about//blank";
            WebTemplateModel.ShowSignInLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult WithBreadCrumbs()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = new List<Breadcrumb>
            {
                new Breadcrumb{ Href = "https://www.canada.ca/en.html", Title = "GoC", Acronym = "Government of Canada"  },
                new Breadcrumb { Title = "My application" }
            };
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;

            return View("HelloWorld");
        }

        public ActionResult StandardFooter()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            return View("HelloWorld");
        }
        public ActionResult CustomFooterGcWeb()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            WebTemplateModel.CustomFooterLinks = new List<FooterLink>
            {
                new FooterLink {Href= "#", Text= "Link 1"},
                new FooterLink {Href= "#", Text= "Link 2"},
                new FooterLink {Href= "#", Text= "Link 3", NewWindow= true},
                new FooterLink {Href= "#", Text= "Link 4"},
                new FooterLink {Href= "#", Text= "Link 5"},
                new FooterLink {Href= "#", Text= "Link 6"},
                new FooterLink {Href= "#", Text= "Link 7"},
                new FooterLink {Href= "#", Text= "Link 8"},
                new FooterLink {Href= "#", Text= "Link 9"}
            };
            return View("HelloWorld");
        }

        public ActionResult CustomFooterGcIntranet()
        {
            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.Settings.ShowPostContent = false;
            WebTemplateModel.FooterSections = new List<FooterSection>
            {
                new FooterSection
                {
                    SectionName = "Section 1 Custom",
                    CustomFooterLinks = new List<FooterLink>
                    {
                        new FooterLink {Href= "google.ca", Text= "Link 1"},
                        new FooterLink {Href= "#", Text= "Link 2"},
                        new FooterLink {Href= "google.ca", Text= "Link 3", NewWindow= true},
                    }
                },
                new FooterSection
                {
                    SectionName = "Section 2 Custom",
                    CustomFooterLinks = new List<FooterLink>
                    {
                        new FooterLink {Href= "#", Text= "Link 4"},
                        new FooterLink {Href= "#", Text= "Link 5"},
                        new FooterLink {Href= "#", Text= "Link 6"},
                    }
                },
                new FooterSection
                {
                    SectionName = "Section 3 Custom",
                    CustomFooterLinks = new List<FooterLink>
                    {
                        new FooterLink {Href= "#", Text= "Link 7"},
                        new FooterLink {Href= "#", Text= "Link 8"},
                        new FooterLink {Href= "#", Text= "Link 9"},
                    }
                }
            };
            return View("HelloWorld");
        }

        public ActionResult TransactionalFooterCustomLinks()
        {

            WebTemplateModel.ApplicationTitle.Text = "Application Name";
            WebTemplateModel.Breadcrumbs = null;
            WebTemplateModel.LanguageLink.Href = "apptop-fr.html";
            WebTemplateModel.Settings.ShowLanguageLink = true;
            WebTemplateModel.TermsConditionsLink = new FooterLink { Href = "#" };
            WebTemplateModel.PrivacyLink = new FooterLink { Href = "#" };
            return View("HelloWorld");
        }
        //
        // GET: /TestWebTemplatePage/
        public ActionResult TestPage()
        {
            //BASIC SETTINGS ====================================
            // this.WebTemplateCore.WebTemplateTheme = "GCWeb";
            WebTemplateModel.Settings.Environment = "PROD_SSL";
            WebTemplateModel.Settings.UseHttps = null;
            WebTemplateModel.HeaderTitle = "Sample Page";

            WebTemplateModel.ScreenIdentifier = "897987sadfjkkla--33";

            WebTemplateModel.ApplicationTitle.Text = "HELLO";

            WebTemplateModel.HTMLHeaderElements.Add("<meta name='description' content='My Description'>");

            WebTemplateModel.DateModified = Convert.ToDateTime("2016-08-28", CultureInfo.CurrentCulture);

            WebTemplateModel.VersionIdentifier = "AA927823737.00.99";

            //this.WebTemplateCore.LanguageLink_URL = "http://www.tsn.com";
            // this.WebTemplateCore.LanguageLink_URL = "../lang.aspx";

            //   this.WebTemplateCore.LanguageLink_URL = "../TestWebTemplatePage/ChangeCulture?GoCTemplateCulture=fr-CA";

            WebTemplateModel.Settings.FeedbackLink.Show = true;

            WebTemplateModel.Settings.ShowSearch = true;

            WebTemplateModel.Settings.SessionTimeout.Enabled = true;
            WebTemplateModel.Settings.SessionTimeout.Inactivity = 20000;
            WebTemplateModel.Settings.SessionTimeout.ReactionTime = 20001;
            WebTemplateModel.Settings.SessionTimeout.SessionAlive = 20002;
            WebTemplateModel.Settings.SessionTimeout.LogoutUrl = "20003";
            WebTemplateModel.Settings.SessionTimeout.RefreshCallBackUrl = "20005";
            WebTemplateModel.Settings.SessionTimeout.RefreshOnClick = false;
            WebTemplateModel.Settings.SessionTimeout.RefreshLimit = 20007;
            WebTemplateModel.Settings.SessionTimeout.Method = "20008";
            WebTemplateModel.Settings.SessionTimeout.AdditionalData = "20009";

            WebTemplateModel.TermsConditionsLink = new FooterLink { Href = "http://www.pinkbike.com" };
            WebTemplateModel.PrivacyLink = new FooterLink { Href = "http://www.lapresse.ca" };

            //BREADCRUMB ====================================
            WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "http://www.canada.ca/en/index.htm", Title = "l'Homéêçå & gamble", Acronym = "l'abc&fich" });
            WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "", Title = "CDN Sample", Acronym = "Content Delivery Network Sample" });


            //Share this page LINK ====================================
            WebTemplateModel.Settings.ShowSharePageLink = true;

            WebTemplateModel.SharePageMediaSites.Add(SocialMediaSites.bitly);
            WebTemplateModel.SharePageMediaSites.Add(SocialMediaSites.facebook);


            //LEFT MENU ====================================
            MenuSection leftmen = new MenuSection
            {
                Text = "menu aslfkjsaklj"
            };

            leftmen.Items.Add(new MenuItem { Href = "http://www.tsn.ca", Text = "aaa" });
            leftmen.Items.Add(new MenuItem { Href = "http://www.cnn.ca", Text = "bbb" });

            WebTemplateModel.LeftMenuItems.Add(leftmen);

            ////set the header for this section of the menu
            //leftMenu.Name = "Section A";
            ////set the links for this section of the menu
            //leftMenu.Items.Add(new GoC.WebTemplate.Link("http://www.tsn.ca", "TSN"));
            //leftMenu.Items.Add(new GoC.WebTemplate.Link("http://www.cnn.ca", "CNN"));

            //add section to template
            //this.WebTemplateCore.LeftMenuItems.Add(leftMenu);

            //or can be done with a 1 liner
            WebTemplateModel.LeftMenuItems.Add(new MenuSection
            {
                Text = "l'index Section B",
                Href = "http://www.pinkbike.com",
                Items = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Href="http://www.rds.ca",
                        Text="RDS",
                        NewWindow= true,
                        SubItems = new List<Link>
                        {
                            new Link
                            {
                                Href="http://www.rds.ca",
                                Text="sub 1",
                                NewWindow= true
                            },
                            new Link
                            {
                                Href="http://www.lapresse.com",
                                Text="sub 2"
                            }
                        }
                    },
                    new MenuItem
                    {
                        Href = "http://www.lapresse.com",
                        Text = "L'a Presse"
                    }
                }
            });

            // GoC.WebTemplate.MenuSection leftMenu = new GoC.WebTemplate.MenuSection();

            //Leaving Secure site ====================================
            WebTemplateModel.Settings.LeavingSecureSiteWarning.Enabled = true;
            WebTemplateModel.Settings.LeavingSecureSiteWarning.DisplayModalWindow = false;
            WebTemplateModel.Settings.LeavingSecureSiteWarning.ExcludedDomains = "www.redseal.ca";
            WebTemplateModel.Settings.LeavingSecureSiteWarning.Message = "You are about to leave a secure site, do you wish to continue?";

            //HTML HEADER/BODY ELEMENTS ====================================
            //this.WebTemplateCore.HTMLHeaderElements.Add("jones.css");
            //this.WebTemplateCore.HTMLHeaderElements.Add("<link rel='stylesheet' type='text/css' href='mystyle.css'>");
            //this.WebTemplateCore.HTMLHeaderElements.Add("<script type='text/javascript' src='javascript.js'></script>");

            //this.WebTemplateCore.HTMLHeaderElements.Add("<!--my comments-->");

            //this.WebTemplateCore.HTMLBodyElements.Add("<link rel='stylesheet' type='text/css' href='mystyle.css'>");
            //this.WebTemplateCore.HTMLBodyElements.Add("<script type='text/javascript' src='javascript.js'></script>");


            System.Text.StringBuilder sb = new System.Text.StringBuilder();


            sb.AppendLine("<script>");
            sb.AppendLine("(function( $, wb ) {");
            sb.AppendLine("\"use strict\";");

            sb.AppendLine("$( document ).on( \"click vclick\", \"#increaseMeter, #decreaseMeter\", function( event ) {");
            sb.AppendLine("var $elm = $( \"#updateTest\" ),");
            sb.AppendLine("increase = event.currentTarget.id === \"increaseMeter\",");
            sb.AppendLine("valuenow = parseInt( $elm.attr( \"value\" ), 10 ),");
            sb.AppendLine("limit = parseInt( $elm.attr( increase ? \"max\" : \"min\" ), 10 ),");
            sb.AppendLine("change = increase ? 1 : -1,");
            sb.AppendLine("newValue = valuenow === limit ? 0 : valuenow + change;");

            sb.AppendLine("$elm");

            sb.AppendLine(".attr( \"value\", newValue )");
            sb.AppendLine(".find( \"span\" )");
            sb.AppendLine(".text( newValue );");

            sb.AppendLine("$elm.trigger( \"wb-update.wb-meter\" );");
            sb.AppendLine("});");

            sb.AppendLine("})( jQuery, wb );");
            sb.AppendLine("</script>");

            WebTemplateModel.HTMLBodyElements.Add(sb.ToString());

            //this.WebTemplateCore.HTMLBodyElements.Add("<script type='text/javascript' src='./GoC.WebTemplate/blabla.js'></script>");

            return View();
        }
        public ActionResult SplashPage()
        {
            WebTemplateModel.SplashPageInfo.EnglishHomeUrl = "http://www.canada.ca/en/index.html";
            WebTemplateModel.SplashPageInfo.FrenchHomeUrl = "http://www.canada.ca/fr/index.html";
            WebTemplateModel.SplashPageInfo.EnglishTermsUrl = "http://www.canada.ca/en/transparency/terms.html";
            WebTemplateModel.SplashPageInfo.FrenchTermsUrl = "http://www.canada.ca/fr/transparence/avis.html";
            WebTemplateModel.SplashPageInfo.EnglishName = "[My web asset]";
            WebTemplateModel.SplashPageInfo.FrenchName = "[Mon actif web]";
            return View();
        }

        //public RedirectResult RedirectTest()
        //{
        //    return Redirect("http://www.lapresse.com");
        //}

        //public RedirectToRouteResult RedirecttoRouteTest()
        //{
        //    return RedirectToAction("Index");
        //}

        //public FileStreamResult FileResutTest()
        //{
        //    string name = "C://sf-ml/me.txt";
        //    System.IO.FileInfo info = new System.IO.FileInfo(name);
        //    if (!info.Exists)
        //    {
        //        using (System.IO.StreamWriter writer = info.CreateText())
        //        {
        //            writer.WriteLine("Hello, I am a new text file");
        //        }
        //    }
        //    return File(info.OpenRead(), "text/plain");
        //}

        //public ActionResult EmptyRestultTest()
        //{
        //    return EmptyResult();
        //}

        //public PartialViewResult PartialVR()
        //{
        //    return PartialView(); tested in separate project
        //}

        //public ContentResult ContentResultTest()
        //{
        //    return Content();
        //}

    }
}