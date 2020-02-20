<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ImageUploader.WebForm1" %>


<asp:Content ID="id1" ContentPlaceHolderID="Maincontent" runat="server">
    <div class="jumbotron">    
    <asp:FileUpload ID="FileUpload1" runat="server" />
        <br/>
    <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
        <br/> 
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <asp:Image ID="Image1"
                ImageUrl='<%#Eval("Name","~/Resources/{0}") %>'
                width="350px" height="350px" runat="Server" />
            <br/>
            <%#Eval("Name") %>
            </ItemTemplate>
            </asp:DataList>
        </div>
</asp:Content>