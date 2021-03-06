<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>      
         <title>员工管理</title>
        <link rel="stylesheet" href="Style.css" />
    </head>
    <body>
        <form id="form1" runat="server">
            <div id="page">
                <div class="top">
                    选择查询部门：
                    <asp:DropDownList ID="DropDownListDepartments" runat="server" />
                    <asp:Button ID="ButtonSearch" runat="server" Text="查询" OnClick="ButtonSearch_Click" />
                </div>
                <asp:GridView ID="GridViewEmployees" runat="server" 
                    AutoGenerateColumns="false" Width="100%">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="姓名" />
                        <asp:BoundField DataField="Gender" HeaderText="性别" />
                        <asp:BoundField DataField="BirthDate" HeaderText="出生日期" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="Department" HeaderText="部门"/>
                    </Columns>
                </asp:GridView>
            </div>
        </form>
    </body>
</html>

