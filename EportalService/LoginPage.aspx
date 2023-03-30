<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EportalService.LoginPage" %>--%>
<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EportalService.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <%--<h2>Login</h2>--%>
        <hr />
        <div class="row">
            <div class="col-md-4">
                <form role="form" method="post">
                    <div class="form-group">
                        <label for="email">Email:</label>
                        <input type="email" class="form-control" id="txtEmail" name="email" required />
                    </div>
                    <div class="form-group">
                        <label for="password">Password:</label>
                        <input type="password" class="form-control" id="txtPassword" name="password" required />
                    </div>
                   <button type="submit" class="btn btn-primary" OnClick="btnsubmit_Click">Submit</button>
                    <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>
