﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GoC.WebTemplate/GoCWebTemplate.Master" AutoEventWireup="true" CodeBehind="FooterLinksSample.aspx.cs" Inherits="GoC.WebTemplate.WebForm.Sample.Pages.FooterLinksSample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>GoC Web Template Samples - Footer Links</h1>
<p><a href="http://www.gcpedia.gc.ca/wiki/Content_Delivery_Network/GoC_.NET_template_guide">Web Template Documentation (GCPedia)</a></p>

<p>This sample page demonstrates how your application can add custom footer links via the GoC Web Template.</p>

<h2>Footer References</h2>
<p>Will you need a custom header/footer? Keep in mind this is different than removing or adding certain elements that are allowed as per the C&IA specifications document. 
    Any element that can be implemented using the C&IA specifications document does not require a custom header/footer and is available in the default version of the CDTS. 
    Currently it is advisable to not implement a custom header/footer unless you have permission to do so from your department, TBS or Principal Publisher. 
    If you have permission to do so then follow the instructions for the "Application templates" in the menu on the right.</p>

<h2>Contact Links</h2>
<p>The "Contact Us" link located at the bottom of the page can be customized by populating the <code class="wb-prettify">contactLinks</code></p>.
<p>Set programmatically via the <code class="wb-prettify">"ContactLinks"</code> property of the Web Template.</p>

<h2>Custom Footer Links</h2>
<div class="wb-prettify all-pre lang-c# linenums">
<pre>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Contact Links
            WebTemplateMaster.WebTemplateCore.ContactLinks = new List<Link>(){ new Link("http://travel.gc.ca/", "Contact Us") };

            //Note: For your solution, the values should be coming from your culture sensitive source ex: resource files, db etc...)
        }
</pre>
</div>
    <!-- #include virtual="SamplesNavigation.html" -->
</asp:Content>
