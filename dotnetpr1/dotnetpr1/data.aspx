<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="dotnetpr1.data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dataform</title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
             <asp:Label ID="lblid" runat="server" Text="empID"></asp:Label>
             <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblname" runat="server" Text="empName"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblemail" runat="server" Text="email"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnclear" runat="server" Text="Clear" OnClick="btnclear_Click"/>
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
        </div>        
    </form>
</body>
</html>
