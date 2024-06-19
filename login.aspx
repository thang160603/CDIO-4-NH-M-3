<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CDIO_4.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table align="center">
     <tr>
         <td colspan="2">&nbsp;</td>
     </tr>
     <tr>
         <td>Tai khoan</td>
         <td>
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td>Mat khau</td>
         <td>
             <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td colspan="2">
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Đăng nhập" />
         </td>
     </tr>
     <tr>
         <td colspan="2">
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Đăng kí" />
         </td>
     </tr>
     <tr>
         <td colspan="2">
             <asp:Label ID="Label1" runat="server"></asp:Label>
         </td>
     </tr>
 </table>
</asp:Content>
