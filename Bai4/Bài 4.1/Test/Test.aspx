<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Test.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%
            for(int i = 0; i < 10; i++)
            {
                Response.Write(i+"<br/>");
            }
            %>
    </form>
</body>
</html>
