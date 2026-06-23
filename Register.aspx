<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Froms_In_dot_net.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">



        <h2>Registration Form</h2>



        <asp:ValidationSummary ID="ValidationSummary1"

            runat="server"

            HeaderText="Please correct the following errors:" />



        <br />



        <asp:Label Text="Name" runat="server"></asp:Label>

        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator

            ID="rfvName"

            runat="server"

            ControlToValidate="txtName"

            ErrorMessage="Enter Name">

        </asp:RequiredFieldValidator>

        <br /><br />



        <asp:Label Text="Email" runat="server"></asp:Label>

        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator

            ID="rfvEmail"

            runat="server"

            ControlToValidate="txtEmail"

            ErrorMessage="Enter Email">

        </asp:RequiredFieldValidator>



        <asp:RegularExpressionValidator

            ID="revEmail"

            runat="server"

            ControlToValidate="txtEmail"

            ValidationExpression="\w+([-.+']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"

            ErrorMessage="Invalid Email">

        </asp:RegularExpressionValidator>

        <br /><br />



        <asp:Label Text="Password" runat="server"></asp:Label>

        <asp:TextBox ID="txtPassword"

            runat="server"

            TextMode="Password">

        </asp:TextBox>



        <asp:RequiredFieldValidator

            ID="rfvPassword"

            runat="server"

            ControlToValidate="txtPassword"

            ErrorMessage="Enter Password">

        </asp:RequiredFieldValidator>

        <br /><br />



        <asp:Label Text="Gender" runat="server"></asp:Label>

        <asp:RadioButton ID="rbMale"

            runat="server"

            GroupName="Gender"

            Text="Male" />



        <asp:RadioButton ID="rbFemale"

            runat="server"

            GroupName="Gender"

            Text="Female" />

        <br /><br />



        <asp:Label Text="Date of Birth" runat="server"></asp:Label>

        <asp:TextBox ID="txtDOB"

            runat="server"

            TextMode="Date">

        </asp:TextBox>

        <br /><br />



        <asp:Label Text="Phone Number" runat="server"></asp:Label>

        <asp:TextBox ID="txtPhone"

            runat="server">

        </asp:TextBox>



        <asp:RequiredFieldValidator

            ID="rfvPhone"

            runat="server"

            ControlToValidate="txtPhone"

            ErrorMessage="Enter Phone Number">

        </asp:RequiredFieldValidator>



        <asp:RegularExpressionValidator

            ID="revPhone"

            runat="server"

            ControlToValidate="txtPhone"

            ValidationExpression="^\d{10}$"

            ErrorMessage="Enter 10 digit phone number">

        </asp:RegularExpressionValidator>

        <br /><br />



        <asp:Label Text="Address" runat="server"></asp:Label>

        <asp:TextBox ID="txtAddress"

            runat="server"

            TextMode="MultiLine"

            Rows="4">

        </asp:TextBox>

        <br /><br />



        <asp:Label Text="Country" runat="server"></asp:Label>

        <asp:DropDownList ID="ddlCountry" runat="server">

            <asp:ListItem Text="Select Country" Value=""></asp:ListItem>

            <asp:ListItem Text="Nepal" Value="Nepal"></asp:ListItem>

            <asp:ListItem Text="India" Value="India"></asp:ListItem>

            <asp:ListItem Text="USA" Value="USA"></asp:ListItem>

            <asp:ListItem Text="UK" Value="UK"></asp:ListItem>

        </asp:DropDownList>



        <asp:RequiredFieldValidator

            ID="rfvCountry"

            runat="server"

            ControlToValidate="ddlCountry"

            InitialValue=""

            ErrorMessage="Select Country">

        </asp:RequiredFieldValidator>

        <br /><br />



        <asp:CheckBox ID="chkTerms"

            runat="server"

            Text="I accept Terms and Conditions" />



        <asp:CustomValidator

            ID="cvTerms"

            runat="server"

            ErrorMessage="Accept Terms and Conditions"

            OnServerValidate="cvTerms_ServerValidate">

        </asp:CustomValidator>



        <br /><br />



        <asp:Button ID="btnRegister"

            runat="server"

            Text="Register"

            OnClick="btnRegister_Click" />



        <br /><br />



        <asp:Label ID="lblDisplay"

            runat="server"

            ForeColor="Green">

        </asp:Label>



    </form>

</body>

</html>
