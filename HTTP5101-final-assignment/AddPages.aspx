<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPages.aspx.cs" Inherits="HTTP5101_final_assignment.WebForm1" %>
<asp:Content ID="newpage" ContentPlaceHolderID="body" runat="server">
<head runat="server">
    <title>Add a New Page</title>
</head>s
<body>
    <h1>Add New Entry</h1>
    <form id="form1" runat="server">
        <div>
            <label for="blog_title">Blog Title:</label>
            <asp:TextBox runat="server" ID="blog_title"></asp:TextBox> 
            <asp:RequiredFieldValidator runat="server" 
                ControlToValidate="blog_title" 
                ErrorMessage="Please enter a title">
            </asp:RequiredFieldValidator>
        </div>
        <div>
            <label for="blog_content">Blog Content:</label>
            <asp:TextBox runat="server" ID="blog_content" TextMode="MultiLine" Columns="50" Rows="5"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" 
                ControlToValidate="blog_content" 
                ErrorMessage="Please enter content">
            </asp:RequiredFieldValidator>
        </div>
        <asp:Button runat="server" OnClick="add_post" Text="Submit" /> 
    </form>
</body>
</asp:content>
