﻿using System;
using GoC.WebTemplate.Components;

namespace GoC.WebTemplate.WebForms
{
    public partial class TestApplicationLeftMenuPage : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var leftMenu = new MenuSection
            {
                Name = "Section A",
                Link = "http://www.servicecanada.gc.ca",
                OpenInNewWindow = true
            };

            //set the header for this section of the menu
            //set the links for this section of the menu
            leftMenu.Items.Add(new MenuItem("http://www.tsn.ca", "TSN", new[] {
                                                            new MenuItem("http://www.cbc.ca", "sub 1", true),
                                                            new MenuItem("http://www.rds.ca", "sub 2") }));
            leftMenu.Items.Add(new MenuItem("http://www.cnn.ca", "CNN"));

            //add title 
            WebTemplateMaster.WebTemplateCore.ApplicationTitle.Text = "My Fancy Application Title";
            WebTemplateMaster.WebTemplateCore.ApplicationTitle.Href = "TestApplicationTemplatePage.aspx";

            //add section to template
            WebTemplateMaster.WebTemplateCore.LeftMenuItems.Add(leftMenu);

            //or can be done with a 1 liner
            WebTemplateMaster.WebTemplateCore.LeftMenuItems.Add(new MenuSection("Section B", new[] {
                                                                                new MenuItem("http://www.rds.ca", "RDS"),
                                                                                new MenuItem("http://www.lapresse.com", "La Presse") }));
        }
    }
}
