﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Globalization;
using GoC.WebTemplate;

namespace GoC.WebTemplateMVC.Controllers
{
    public class TestWebTemplatePageController : WebTemplateBaseController
    {
        public ActionResult HelloWorld()
        {
            WebTemplateCore.ApplicationName = "Application Web Template";
            WebTemplateCore.ShowSecure = true;
            WebTemplateCore.Breadcrumbs = null;
            return View();
        }

        public ActionResult StandardPage ()
        {
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult Secure()
        {

            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowSecure = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult SignIn()
        {
            
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            WebTemplateCore.ShowSignInLink = true;
            WebTemplateCore.SignInLinkHref = "about//blank";
            return View("HelloWorld");
        }
        public ActionResult SignOut()
        {
            
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            WebTemplateCore.ShowSignOutLink = true;
            WebTemplateCore.SignOutLinkHref = "about//blank";
            return View("HelloWorld");
        }
        public ActionResult NoSearch()
        {

            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowSearch = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            return View("HelloWorld");
        }
        public ActionResult NoMenu()
        {

            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowSiteMenu = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult CustomMenu()
        {
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.CustomSiteMenuURL =
                "https://ssl-templates.services.gc.ca/app/cls/WET/gcweb/v4_0_24/cdts/custommenu-en.html";

            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            return View("HelloWorld");
        }
        public ActionResult SignInWithCustomMenu()
        {
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.CustomSiteMenuURL =
                "https://ssl-templates.services.gc.ca/app/cls/WET/gcweb/v4_0_24/cdts/custommenu-en.html";

            WebTemplateCore.SignInLinkHref = "about//blank";
            WebTemplateCore.ShowSignInLink = true;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;
            return View("HelloWorld");
        }

        public ActionResult WithBreadCrumbs()
        {
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = new List<Breadcrumb>
            {
                new Breadcrumb{ Href = "https://www.canada.ca/en.html", Title = "GoC", Acronym = "Government of Canada"  },
                new Breadcrumb { Title = "My application" }
            };
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false;

            return View("HelloWorld");
        }

        public ActionResult StandardFooter()
        {
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false; ;
            return View("HelloWorld");
        }
        public ActionResult CustomFooter()
        {
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = null;
            WebTemplateCore.ShowPostContent = false; ;
            WebTemplateCore.CustomFooterLinks = new List<FooterLink>
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


        public ActionResult TransactionalFooterCustomLinks()
        {
            
            WebTemplateCore.ApplicationName = "Application Name";
            WebTemplateCore.Breadcrumbs = null;
            WebTemplateCore.LanguageLink_URL = "apptop-fr.html";
            WebTemplateCore.ShowLanguageLink = true;
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.ShowGlobalNav = false;
            WebTemplateCore.ContactLinks = new List<Link> { new Link {Href = "#"} };
            WebTemplateCore.ShowFeatures = false;
            WebTemplateCore.TermsConditionsLink_URL = "#";
            WebTemplateCore.PrivacyLink_URL = "#";
            return View("HelloWorld");
        }
        //
        // GET: /TestWebTemplatePage/
        public ActionResult TestPage()
        { 
            //BASIC SETTINGS ====================================
           // this.WebTemplateCore.WebTemplateTheme = "GCWeb";
            WebTemplateCore.Environment = "akamai";
            WebTemplateCore.WebTemplateSubTheme = "esdc";
            WebTemplateCore.HeaderTitle = "Sample Page";

            WebTemplateCore.ScreenIdentifier = "897987sadfjkkla--33";

            WebTemplateCore.ApplicationTitle_Text = "HELLO";

            WebTemplateCore.HTMLHeaderElements.Add("<meta name='description' content='My Description'>");

            WebTemplateCore.DateModified = Convert.ToDateTime("2016-08-28", CultureInfo.CurrentCulture);

            WebTemplateCore.VersionIdentifier = "AA927823737.00.99";

            //this.WebTemplateCore.LanguageLink_URL = "http://www.tsn.com";
           // this.WebTemplateCore.LanguageLink_URL = "../lang.aspx";

         //   this.WebTemplateCore.LanguageLink_URL = "../TestWebTemplatePage/ChangeCulture?GoCTemplateCulture=fr-CA";

            WebTemplateCore.ShowFeatures = true;

            WebTemplateCore.ShowFeedbackLink = true;

            WebTemplateCore.ShowSearch = true;

            WebTemplateCore.SessionTimeout.Enabled = true;
            WebTemplateCore.SessionTimeout.Inactivity = 20000;
            WebTemplateCore.SessionTimeout.ReactionTime = 20001;
            WebTemplateCore.SessionTimeout.SessionAlive = 20002;
            WebTemplateCore.SessionTimeout.LogoutUrl = "20003";
            WebTemplateCore.SessionTimeout.RefreshCallbackUrl = "20005";
            WebTemplateCore.SessionTimeout.RefreshOnClick = false;
            WebTemplateCore.SessionTimeout.RefreshLimit = 20007;
            WebTemplateCore.SessionTimeout.Method = "20008";
            WebTemplateCore.SessionTimeout.AdditionalData = "20009";

            WebTemplateCore.TermsConditionsLink_URL = "http://www.pinkbike.com";
            WebTemplateCore.PrivacyLink_URL = "http://www.lapresse.ca";

            //BREADCRUMB ====================================
            WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("http://www.canada.ca/en/index.htm", "l'Homéêçå & gamble", "l'abc&fich"));
            WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("", "CDN Sample", "Content Delivery Network Sample"));

            //FOOTER Links SECTIONS ====================================
            WebTemplateCore.ContactLinks.Add(new Link("http://www.cnn.com", "C'Link 4"));
            WebTemplateCore.ContactLinks.Add(new Link("http://www.tsn.com", "CLink 5"));

            WebTemplateCore.NewsLinks.Add(new Link("#", "NLink3"));
            WebTemplateCore.NewsLinks.Add(new Link("#", "NLink5"));

            WebTemplateCore.AboutLinks.Add(new Link("#", "ALink6"));
            WebTemplateCore.AboutLinks.Add(new Link("#", "ALink7"));
            
            //Share this page LINK ====================================
            WebTemplateCore.ShowSharePageLink = true;

            WebTemplateCore.SharePageMediaSites.Add(Core.SocialMediaSites.bitly);
            WebTemplateCore.SharePageMediaSites.Add(Core.SocialMediaSites.facebook);


            //LEFT MENU ====================================
            MenuSection leftmen = new MenuSection();

            leftmen.Name = "menu aslfkjsaklj";
            
            leftmen.Items.Add(new Link("http://www.tsn.ca", "aaa"));
            leftmen.Items.Add(new Link("http://www.cnn.ca", "bbb"));

            WebTemplateCore.LeftMenuItems.Add(leftmen);

            ////set the header for this section of the menu
            //leftMenu.Name = "Section A";
            ////set the links for this section of the menu
            //leftMenu.Items.Add(new GoC.WebTemplate.Link("http://www.tsn.ca", "TSN"));
            //leftMenu.Items.Add(new GoC.WebTemplate.Link("http://www.cnn.ca", "CNN"));

            //add section to template
            //this.WebTemplateCore.LeftMenuItems.Add(leftMenu);

            //or can be done with a 1 liner
            WebTemplateCore.LeftMenuItems.Add(new MenuSection("l'index Section B", "http://www.pinkbike.com", new Link[] { 
                                                                                new MenuItem("http://www.rds.ca", "RDS", true, new MenuItem[] { 
                                                                                    new MenuItem("http://www.rds.ca", "sub 1", true), 
                                                                                    new MenuItem("http://www.lapresse.com", "sub 2") }), 
                                                                                new Link("http://www.lapresse.com", "L'a Presse") }));

            // GoC.WebTemplate.MenuSection leftMenu = new GoC.WebTemplate.MenuSection();

            //Leaving Secure site ====================================
            WebTemplateCore.LeavingSecureSiteWarning_Enabled = true;
            WebTemplateCore.LeavingSecureSiteWarning_DisplayModalWindow = false;
            WebTemplateCore.leavingSecureSiteWarning_ExcludedDomains = "www.redseal.ca";

            WebTemplateCore.LeavingSecureSiteWarning_Message = "Y'éou are about to leave a secure site, do you wish to continue?223";

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

            WebTemplateCore.HTMLBodyElements.Add(sb.ToString());

            //this.WebTemplateCore.HTMLBodyElements.Add("<script type='text/javascript' src='./GoC.WebTemplate/blabla.js'></script>");
            
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