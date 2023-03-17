﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GoC.WebTemplate/GoCWebTemplate.Master" AutoEventWireup="true" CodeBehind="BaseSettingsSample.aspx.cs" Inherits="GoC.WebTemplate.WebForm.Sample.SamplePages.BaseSettingsSample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 id="wb-cont">GoC Web Template Samples - Basic Settings</h1>
    <p><a href="http://www.gcpedia.gc.ca/wiki/Content_Delivery_Network/GoC_.NET_template_guide">Web Template Documentation (GCPedia)</a></p>

    <p>This sample page provides the basic items to configure in your pages, when using the GoC Web Template.</p>

    <h2>Page Title</h2>
    <p>This setting determines the title for your site.</p>
    <p>Set programmatically via the <code class="wb-prettify">"HeaderTitle"</code> property of the Web Template.</p>

    <h2>Metatags</h2>
    <p>A string collection is available to include HTML Elements, including Meta Tag, to the head section of the page.</p>
    <p>Set programmatically by populating the <code class="wb-prettify">"HTMLHeaderElements"</code> collection of the Web Template.</p>
    <p>The collection is of type <code class="wb-prettify">"String"</code>, and the complete html tag for your MetaTag to include should be supplied.</p>
    <p>Note: this collections can also be used to add script tags for javascript and/or link tag to include CSSs.</p>
        
    <h2>Date Modified</h2>
    <p>The DateModified is displayed near the bottom of the page. This element shares the same location as "VersionIdentifier" and only one of the two can be displayed at once. If a "DateModified" is supplied the date will take precedence over the "VersionIdentifier". </p>
    <p>Set programmatically via the <code class="wb-prettify">"DateModified"</code> property of the Web Template.</p>

    <h2>Version Identifier</h2>
    <p>The Version Identifier is displayed near the bottom of the page. This element shares the same location as "DateModified" and only one of the two can be displayed at once. If a "DateModified" is supplied the date will take precedence over the "VersionIdentifier".</p>
    <p>Set programmatically via the <code class="wb-prettify">"VersionIdentifier"</code> property of the Web Template.</p>

    <h2>Screen Identifier</h2>
    <p>The Screen Identifier is displayed near the bottom of the page. This element serves a unique identifier for your page and can be used to help communication between users and the service desk/support team to identify the location exact location of a user in your application.</p>
    <p>Set programmatically via the <code class="wb-prettify">"ScreenIdentifier"</code> property of the Web Template.</p>

    <h2>Contact Links</h2>
    <p>The Contact Links located at the bottom of the page.</p>
    <p>Set programmatically via the <code class="wb-prettify">"ContactLinks"</code> property of the Web Template.</p>

    <div class="wb-prettify all-pre lang-vb linenums">
    <h3>C# Code Sample</h3>
<pre>
//specify a title for this page
this.WebTemplateMaster.WebTemplateModel.HeaderTitle = "My Title";

//specify the metatags
this.WebTemplateMaster.WebTemplateModel.HTMLHeaderElements.Add("&lt;meta charset='UTF-8'&gt;");
this.WebTemplateMaster.WebTemplateModel.HTMLHeaderElements.Add("&lt;meta name='singer' content='Elvis'&gt;");
this.WebTemplateMaster.WebTemplateModel.HTMLHeaderElements.Add("&lt;meta http-equiv='default-style' content='sample'&gt;");

//specify a specific date modified
this.WebTemplateMaster.WebTemplateModel.DateModified = Convert.ToDateTime("2016-08-28", CultureInfo.CurrentCulture);
//or for using the current date
//this.WebTemplateMaster.WebTemplateModel.DateModified = DateTime.Now.Date;

//specify the version identifier (Note: since the date modified is supplied the date takes precedence)
this.WebTemplateMaster.WebTemplateModel.VersionIdentifier = "AA927823737.00.99";

//specify a screen identifier
this.WebTemplateMaster.WebTemplateModel.ScreenIdentifier = "SP-3485-01";

//Specify the Contact Link
this.WebTemplateModel.ContactLinks = new List<Link>(){ new Link() {Href="http://travel.gc.ca/"} };
</pre>
</div>
   <!-- #include virtual="SamplesNavigation.html" -->
</asp:Content>
