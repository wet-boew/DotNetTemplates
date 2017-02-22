﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GoC.WebTemplate/GoCWebTemplate.Master" AutoEventWireup="true" CodeBehind="FooterLinksSample.aspx.cs" Inherits="FooterLinksSample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
<h1>GoC Web Template Samples - Footer Links</h1>
<p><a href="http://www.gcpedia.gc.ca/wiki/Content_Delivery_Network/GoC_.NET_template_guide">Web Template Documentation (GCPedia)</a></p>

<p>The footer links consist of the Contact, News and About links located at the bottom of the page.  The theme you specify for your site determines which category and links are displayed.  The theme also determines which of the categories can be modified by the application.</p>

<p>All categories are based on the same logic which is a collection of <code class="wb-prettify">"Link"</code> and are set programmatically by populating the <code class="wb-prettify">"ContactLinks, NewsLinks and/or AboutLinks"</code> collections of the Web Template.</p>

    <p>The <code class="wb-prettify">"Link"</code> class has 2 properties</p>
<ul>
    <li><code class="wb-prettify">"href"</code>: the url of the link.</li>
    <li><code class="wb-prettify">"text"</code>: the text of the link that is displayed</li>
</ul>
               
       <div class="wb-prettify all-pre lang-vb linenums">
    <h3>C# Code Sample</h3>
    <pre>
//Contact Links
this.WebTemplateMaster.WebTemplateCore.ContactLinks.Add(new Link("http://travel.gc.ca/", "Travel"));
this.WebTemplateMaster.WebTemplateCore.ContactLinks.Add(new Link("http://healthycanadians.gc.ca/index-eng.php", "Health"));
this.WebTemplateMaster.WebTemplateCore.ContactLinks.Add(new Link("http://jobs-emplois.gc.ca/index-eng.htm", "Jobs"));

//News Links
this.WebTemplateMaster.WebTemplateCore.NewsLinks.Add(new Link("http://www.cbc.ca/news/canada", "CBC"));
this.WebTemplateMaster.WebTemplateCore.NewsLinks.Add(new Link("http://www.cnn.com/", "CNN"));

//About Links
this.WebTemplateMaster.WebTemplateCore.AboutLinks.Add(new Link("https://www.facebook.com", "Facebook"));
this.WebTemplateMaster.WebTemplateCore.AboutLinks.Add(new Link("http://www.lapresse.ca/", "LaPresse"));
    </pre>
</div>
<!-- #include virtual="SamplesNavigation.html" -->
</asp:Content>
