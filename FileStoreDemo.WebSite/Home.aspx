<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FileStoreDemo.WebSite.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <br />

            <asp:Label ID="lbl1" runat="server" Text="1，上传文件:"></asp:Label>
            <asp:FileUpload ID="fileUpload1" runat="server" Width="250px" />
            <asp:Button ID="btnUpload" runat="server" Text="上传" OnClick="btnUpload_Click" />
            <br />
            <br />

            <asp:Label ID="lbl2" runat="server" Text="2，下载文件："></asp:Label>
            <asp:Button ID="btnDownload" runat="server" Text="下载" OnClick="btnDownload_Click" />
        </div>
    </form>
</body>
</html>
