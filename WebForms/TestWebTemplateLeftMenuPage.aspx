﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GoC.WebTemplate/GoCWebTemplate.LeftMenu.Master" AutoEventWireup="true" CodeBehind="TestWebTemplateLeftMenuPage.aspx.cs" Inherits="GoC.WebTemplate.WebForms.TestWebTemplateLeftMenuPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Your Content</h1>

    <p>Here is an external link that will display the warning:<a href="http://www.pinkbike.com">Link to External Page</a></p>

    <a href="http://www.pinkbike.com" target="_blank">new window - Link to External Page </a>
    

    <table class="table table-striped">
	<thead>
		<tr>
			<th scope="col">Description</th>
			<th scope="col">Min</th>
			<th scope="col">Low</th>
			<th scope="col">Value</th>
			<th scope="col">Max</th>
			<th scope="col">High</th>
			<th scope="col">Result</th>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>Normal (75%)</td>
			<td>20</td>
			<td>n/a</td>
			<td>65</td>
			<td>80</td>
			<td>n/a</td>
			<td><meter min="20" value="65" max="80">75% (normal)</meter></td>
		</tr>
		<tr>
			<td>Too high (90%)</td>
			<td>0</td>
			<td>n/a</td>
			<td>90</td>
			<td>100</td>
			<td>80</td>
			<td><meter min="0" value="90" max="100" high="80">90% (too high)</meter></td>
		</tr>
		<tr>
			<td>Too low (15%)</td>
			<td>100</td>
			<td>120</td>
			<td>115</td>
			<td>200</td>
			<td>180</td>
			<td><meter min="100" low="120" value="115" max="200" high="180">15% (too low)</meter></td>
		</tr>
		<tr>
			<td colspan="3"><button class="btn btn-default" id="decreaseMeter" type="button">Decrease</button></td>
			<td colspan="3"><button class="btn btn-default" id="increaseMeter" type="button">Increase</button></td>
			<td><meter id="updateTest" min="100" low="120" value="150" max="200" high="180"><span class="wb-inv">150</span></meter></td>
		</tr>
	</tbody>
</table>
    
    <div id="cdn-youtube">
</div>
<!-- Write closure template -->

    

</asp:Content>
