<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <strong><span class="auto-style1">Login Id and Password generation</span><br />
        <br />
        </strong>Enter<strong> </strong>your First Name <strong>
        <asp:TextBox ID="firstNameText" runat="server" style="margin-left: 20px; margin-bottom: 0px" Width="194px"></asp:TextBox>
        <br />
        <br />
        </strong>Enter your Last Name<asp:TextBox ID="lastNameText" runat="server" style="margin-left: 25px" Width="194px"></asp:TextBox>
        <br />
        <br />
        Enter your Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ageTextBox" runat="server" style="margin-left: 17px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="button1" runat="server" OnClick="Button1_Click" style="margin-left: 104px" Text="Generate Username and Password" Width="228px" />
        <br />
        <br />
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        Username Generated :&nbsp; <asp:Label ID="userLabel" runat="server"></asp:Label>
        <br />
        <br />
        Password Generated&nbsp; :
        <asp:Label ID="passLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
