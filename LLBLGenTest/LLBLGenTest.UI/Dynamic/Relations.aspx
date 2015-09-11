<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Relations.aspx.cs" Inherits="LLBLGenTest.UI.Dynamic.Relations" %>

<%@ Import Namespace="SD.LLBLGen.Pro.ORMSupportClasses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Repeater runat="server" ID="rptFields">
        <HeaderTemplate>
            <h4>Fields:</h4>
            <ol>
        </HeaderTemplate>
        <ItemTemplate>
            <li><%# Data<KeyValuePair<String,Dictionary<String,string>>>().Key %></li>
        </ItemTemplate>
        <FooterTemplate>
            </ol>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater runat="server" ID="rptRelations">
        <HeaderTemplate>
            <h4>Relations:</h4>
            <ol>
        </HeaderTemplate>
        <ItemTemplate>
            <li>Field: <%# Data<IEntityRelation>().MappedFieldName %>, Type: <%# Data<IEntityRelation>().TypeOfRelation %></li>
        </ItemTemplate>
        <FooterTemplate>
            </ol>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater runat="server" ID="rptCustomProperties">
        <HeaderTemplate>
            <h4>Custom Properties:</h4>
            <ol>
        </HeaderTemplate>
        <ItemTemplate>
            <li>Key: <%# Eval("Key") %>, Value: <%# Eval("Value")%></li>
        </ItemTemplate>
        <FooterTemplate>
            </ol>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater runat="server" ID="rptOneToManyRelationFields">
        <HeaderTemplate>
            <h4>OneToManyRelationFields:</h4>
            <ol>
        </HeaderTemplate>
        <ItemTemplate>
            <li>Key: <%# Data<System.Reflection.FieldInfo>().Name %></li>
        </ItemTemplate>
        <FooterTemplate>
            </ol>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater runat="server" ID="rptManyToManyRelationFields">
        <HeaderTemplate>
            <h4>ManyToManyRelationFields:</h4>
            <ol>
        </HeaderTemplate>
        <ItemTemplate>
            <li>Key: <%# Data<System.Reflection.FieldInfo>().Name %></li>
        </ItemTemplate>
        <FooterTemplate>
            </ol>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
