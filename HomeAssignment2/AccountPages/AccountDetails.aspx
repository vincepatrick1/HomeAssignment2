<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountDetails.aspx.cs" Inherits="March22ClassExercise.AccountPages.AccountDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 255px;
        }
        .auto-style3 {
            width: 420px;
        }
        .auto-style4 {
            width: 255px;
            height: 31px;
        }
        .auto-style5 {
            width: 420px;
            height: 31px;
        }
        .auto-style6 {
            height: 31px;
        }
        .auto-style7 {
            width: 231px;
        }
        .auto-style8 {
            width: 231px;
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Account Name:</td>
                <td class="auto-style3">
                    <asp:Label ID="NameLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Account Type:</td>
                <td class="auto-style3">
                    <asp:Label ID="TypeLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Account Balance:</td>
                <td class="auto-style5">
                    <asp:Label ID="BalanceLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="WithDrawTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Button ID="WithdrawButton" runat="server" OnClick="WithdrawButton_Click" Text="Withdraw Money" />
                </td>
                <td class="auto-style6">
                    <asp:Label ID="WithdrawlErrorLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Eligible for Loan:</td>
                <td class="auto-style3">
                    <asp:Label ID="LoanLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Button ID="LoanButton" runat="server" Text="Want a Loan?" PostBackUrl="~/AccountPages/LoanApplicationPage.aspx" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address Provided:</td>
                <td class="auto-style3">
                    <asp:Label ID="AddressLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
