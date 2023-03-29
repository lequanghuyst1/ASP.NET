<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang gửi</title>
</head>
<body>
    <form id="form1" runat="server" method="post" >
        
        <div>
         User name:
        <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox><br />
         Password:
        <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox><br />
         <asp:Button runat="server" ID="cmdSubmit" Text="Submit"
        PostBackUrl="~/WebForm2.aspx" />
        </div>
        
    </form>
 
</body>
</html>
