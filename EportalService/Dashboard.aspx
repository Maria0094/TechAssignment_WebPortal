<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="EportalService.Dashboard" %>--%>
<%@ Page Async="true" Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="EportalService.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2>Welcome to Dashboard  
            <p id ="userType" runat="server"></p>
        <hr />
        <div class="row">
            <div class="col-md-4">
                <p id="name" runat="server"><strong>Name:</strong></p>
                <p id="email" runat="server"><strong>Email:</strong> </p>
                <p id="mobile" runat="server"><strong>Mobile:</strong></p>
            </div>
            <div>
                <label id="error" runat="server"></label>
            </div>
        </div>
    </div>
</asp:Content>
