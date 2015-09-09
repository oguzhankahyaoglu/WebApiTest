<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LLBLGenTest.UI.Dynamic.Default" %>

<%@ Import Namespace="LLBLGenTest.LLBL.EntityClasses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Repeater runat="server" ID="rpt">
        <ItemTemplate>
            <h1><%# Data<PostEntity>().Title %></h1>
            <div><%# Data<PostEntity>().Description%></div>
            <asp:Repeater runat="server" DataSource='<%# Data<PostEntity>().Category1CollectionViaCategory1Post %>'>
                <HeaderTemplate>
                    <ol>
                </HeaderTemplate>
                <ItemTemplate>
                    <li><%# Data<Category1Entity>().Title %></li>
                </ItemTemplate>
                <FooterTemplate>
                    </ol>
                </FooterTemplate>
            </asp:Repeater>
            <br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
