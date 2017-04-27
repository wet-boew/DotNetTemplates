﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GoC.WebTemplate/GoCWebTemplate.Master" AutoEventWireup="true" CodeBehind="ErrorSample.aspx.cs" Inherits="ErrorSample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="row mrgn-tp-lg">
    <div class="col-xs-3 col-sm-2 col-md-1 text-center mrgn-tp-md">
        <span class="glyphicon glyphicon-warning-sign" style="color:#96323a;font-size:400%"></span>
    </div>
    <div class="col-xs-9 col-sm-10 col-md-11">
        <h1 class="mrgn-tp-md">We couldn't find that Web page</h1>
        <p class="pagetag"><strong>Error 404</strong></p>
    </div>
</div>
<div class="row mrgn-bttm-lg">
    <div class="col-md-12">
        <p>We're sorry you ended up here. Sometimes a page gets moved or deleted, but hopefully we can help you find what you're looking for. What next?</p>
        <ul>
            <li>Return to the <a href="/en/index.html">home page</a>;</li>
            <li>Consult the <a href="/en/sitemap.html">site map</a>;</li>
            <li>Check out the <a href="http://www.collectionscanada.gc.ca/012/012-412.01-e.html" rel="external">Government of Canada Web Archive</a> to view an older version; or</li>
            <li><a href="/en/contact/index.html">Contact us</a> and we'll help you out.</li>
        </ul>
    </div>
</div>
<!-- #include virtual="SamplesNavigation.html" -->
</asp:Content>
