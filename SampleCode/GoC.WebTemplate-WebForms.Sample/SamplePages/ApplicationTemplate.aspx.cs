﻿using System;
using System.Collections.Generic;
using GoC.WebTemplate.Components;
using GoC.WebTemplate.Components.JSONSerializationObjects;
using GoC.WebTemplate.WebForms;

namespace GoC.WebTemplate.WebForm.Sample.SamplePages
{
    public partial class ApplicationTemplate : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebTemplateMaster.WebTemplateCore.ApplicationTitle.Text = "Application Name";
            WebTemplateMaster.WebTemplateCore.LanguageLink.Href = "apptop-fr.html";
            WebTemplateMaster.WebTemplateCore.ShowPreContent = false;
            WebTemplateMaster.WebTemplateCore.ShowSearch = true;

            WebTemplateMaster.WebTemplateCore.ContactLinks = new List<Link> { new Link() { Href = "http://travel.gc.ca/" } };

            WebTemplateMaster.WebTemplateCore.Breadcrumbs = new List<Breadcrumb>
            {
                new Breadcrumb{ Href = "https://www.canada.ca/en.html", Title = "GoC", Acronym = "Government of Canada"  },
                new Breadcrumb { Title = "My application" }
            };
            WebTemplateMaster.WebTemplateCore.CustomFooterLinks = new List<FooterLink>
            {
                new FooterLink
                {
                    Href = "about:blank",
                    NewWindow = true,
                    Text = "Footer Link 1"
                }
            };
            WebTemplateMaster.WebTemplateCore.CustomFooterLinks.Add(new FooterLink
            {
                Href="about:blank",
                Text = "Footer Link 2"
            });

            WebTemplateMaster.WebTemplateCore.SignInLinkURL = "about:blank";
            WebTemplateMaster.WebTemplateCore.ShowSignInLink = true;
            WebTemplateMaster.WebTemplateCore.AppSettingsURL = "http://tempuri.com";


            WebTemplateMaster.WebTemplateCore.CustomSearch = new CustomSearch
            {
                Action = "http://hrsdc.prv/cgi-bin/recherche-search/Intraweb/index.aspx",
                // Id = "0001", optional
                Method = "get", // 'get' or 'post'
                Placeholder = "Search ESDC IntraWeb",
                HiddenInput = new List<KeyValuePair<string, string>> //optional
                {
                    new KeyValuePair<string, string>("GoCTemplateCulture", "en-CA"),
                    new KeyValuePair<string, string>("p1", "gc")
                }
            };
        }
    }
}