<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Category1.aspx.cs" Inherits="LLBLGenTest.UI.Dynamic.Category1" %>

<%@ Import Namespace="LLBLGenTest.LLBL.EntityClasses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="cphContent" runat="server">
    <ol>
        <sh:SelfHidingRepeater runat="server" ID="rpt">
            <ItemTemplate>
                <li>
                    <%# Data<Category1Entity>().Title %>
                    <sh:SelfHidingRepeater runat="server" DataSource='<%# Data<Category1Entity>().Category2 %>'>
                        <HeaderTemplate>
                            <ol>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <li>
                                <%# Data<Category2Entity>().Title %>
                                <sh:SelfHidingRepeater runat="server" DataSource='<%# Data<Category2Entity>().PostCollectionViaCategory2Post%>'>
                                    <HeaderTemplate>
                                        <ol>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <li><%# Data<PostEntity>().Title %></li>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </ol>
                                    </FooterTemplate>
                                </sh:SelfHidingRepeater>
                            </li>
                        </ItemTemplate>
                        <FooterTemplate>
                            </ol>
                        </FooterTemplate>
                    </sh:SelfHidingRepeater>
                </li>
            </ItemTemplate>
        </sh:SelfHidingRepeater>
    </ol>
</asp:Content>
