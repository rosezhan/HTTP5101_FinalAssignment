<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPages.aspx.cs" Inherits="HTTP5101_final_assignment.WebForm3" %>

<asp:Content ID="page_view" ContentPlaceHolderID="body" runat="server">
<head runat="server">
    <title>View Page</title>
</head>
<body>
     <h1><span id="page_title" runat="server"></span></h1>
    <form id="form1" runat="server">
        <div>
           <p><span id="page_content" runat="server"></span></p>
        </div>
        <asp:Button runat="server" OnClick="update_post" Text="Update" />
        <asp:Button runat="server" OnClick="delete_post" Text="Delete" 
            OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" /> 
    </form>
</body>
</asp:content>
