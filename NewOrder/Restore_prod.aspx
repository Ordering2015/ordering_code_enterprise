﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restore_prod.aspx.cs" Inherits="EnterpriseOrdering.REstore_prod" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/styles.css" rel="stylesheet" type="text/css" />
    <link href="Styles/theme.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    



        <asp:Label ID="Label1" class= "vzh1" runat="server"></asp:Label>

        <br />
            <asp:Label ID="Label2" class="vzh2" runat="server" Text="LIST OF PRODUCTS"></asp:Label>



        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            class="vztable" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="pid" HeaderText="Product ID" SortExpression="pid" />
                <asp:BoundField DataField="pname" HeaderText="Product Name" 
                    SortExpression="pname" />
                <asp:BoundField DataField="qty" HeaderText="Quantity" SortExpression="qty" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" class="vzbtn" runat="server" Text="Ok" 
            onclick="Button1_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
