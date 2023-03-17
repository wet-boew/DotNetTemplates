﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GoC.WebTemplate/GoCWebTemplate.Master" AutoEventWireup="true" CodeBehind="BreadcrumbSample.aspx.cs" Inherits="GoC.WebTemplate.WebForm.Sample.SamplePages.BreadcrumbSample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 id="wb-cont">GoC Web Template Samples - Breadcrumbs</h1>
    <p><a href="http://www.gcpedia.gc.ca/wiki/Content_Delivery_Network/GoC_.NET_template_guide">Web Template Documentation (GCPedia)</a></p>

    <p>The breadcrumbs are a list of links displayed near to the top of the content to help the user determine where they are on the site and to help them navigate.</p>

    <p>In the transactional mode, the Breadcrumb trail should be replaced with a link to exit the transaction, which directs the user to a safe point where they can abandon the current transaction and restart it should they wish.</p>

    <p>They are set programmatically by populating the <code class="wb-prettify">"Breadcrumbs"</code> collection of the Web Template.</p>

    <p>The <code class="wb-prettify">"Breadcrumb"</code> has 3 properties</p>
    <ul>
        <li><code class="wb-prettify">"href"</code>: the url of the link. If left empty, the item will be displayed in text and not as a hyperlink.</li>
        <li><code class="wb-prettify">"title"</code>: the text of the link that is displayed</li>
        <li><code class="wb-prettify">"acronym"</code>: if your title has an acronym, you can use this property to provide the full text of the title.  it will be displayed when the user hovers over the link.</li>
    </ul>       

    <div class="wb-prettify all-pre lang-vb linenums">
        <h3>C# Code Sample</h3>
        <pre>
//Specify your breadcrumbs
WebTemplateMaster.WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "http://www.canada.ca/en/index.html", Title = "Home" });
WebTemplateMaster.WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "http://www.esdc.gc.ca/en/jobs/opportunities/index.page", Title = "Jobs" });
WebTemplateMaster.WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Href = "http://www.esdc.gc.ca/en/jobs/opportunities/youth_students.page", Title = "Opportunities" });
//Leaving the "href" parameter empty, will create the breadcrumb in text and not as a hyperlink. Useful for the last item of the breadcrumb list. 
WebTemplateMaster.WebTemplateModel.Breadcrumbs.Add(new Breadcrumb { Title = "FSWEP", Acronym = "Federal Student Work Experience Program" });
        </pre>
    </div>
     <!-- #include virtual="SamplesNavigation.html" -->
</asp:Content>
