<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleInterest.aspx.cs" Inherits="Froms_In_dot_net.SimpleInterest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
        <asp:Label Text="Principal:" runat="server" AssociatedControlID="txtPrincipal"></asp:Label>
        <asp:TextBox runat="server" ID="txtPrincipal"></asp:TextBox><br />

        <asp:Label Text="Rate (%):" runat="server" AssociatedControlID="txtRate"></asp:Label>
        <asp:TextBox runat="server" ID="txtRate"></asp:TextBox><br />

        <asp:Label Text="Time (Years):" runat="server" AssociatedControlID="txtTime"></asp:Label>
        <asp:TextBox runat="server" ID="txtTime"></asp:TextBox><br />

        <asp:Button runat="server" ID="btnCalculate" Text="Calculate" OnClick="btnCalculate_Click" /><br />

        <asp:Label runat="server" ID="lblResult" Font-Bold="true"></asp:Label>
    </form>
</body>
</html>
