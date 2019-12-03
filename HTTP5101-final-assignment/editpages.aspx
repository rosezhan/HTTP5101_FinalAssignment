<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editpages.aspx.cs" Inherits="HTTP5101_final_assignment.WebForm2" %>
<asp:Content ID="updatepage" ContentPlaceHolderID="body" runat="server">
    <div>
        <div class="viewnav">
            <a class="left" href="ShowPage.aspx?pagenumber=<%=Request.QueryString["page_number"] %>">Cancel</a>
        </div>
    </div>
<body>
     <h1>Make Changes</h1>
    <form id="form1" runat="server">
        <div>
            <label for="blog_title">Blog Title:</label>
            <asp:TextBox runat="server" ID="blog_title"></asp:TextBox>
        </div>
        <div>
            <label for="blog_content">Blog Content:</label>
            <asp:TextBox runat="server" ID="blog_content" TextMode="MultiLine" Columns="50" Rows="5"></asp:TextBox>
        </div>
        <asp:Button runat="server" OnClick="update_post" Text="Update" />
        <asp:Button runat="server" OnClick="delete_post" Text="Delete" /> 
    </form>
</body>
</asp:content>
