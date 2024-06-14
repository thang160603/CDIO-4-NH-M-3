<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CDIO_4.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table align="center">
     <tr>
         <td colspan="2">&nbsp;</td>
     </tr>
         <tr>
         <td>Họ Và Tên</td>
         <td>
             <asp:TextBox ID="TextBoxHoten" runat="server"></asp:TextBox>
         </td>
     </tr>
    <tr>
         <td>Số Điện Thoại</td>
         <td>
             <asp:TextBox ID="TextBoxSDT" runat="server"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td>Tài khoản</td>
         <td>
             <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td>Mật khẩu</td>
         <td>
             <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td>Xác nhận mật khẩu</td>
         <td>
             <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
         </td>
     </tr>
     <tr>
         <td colspan="2">
             <asp:Button ID="ButtonRegister" runat="server" OnClick="ButtonRegister_Click" Text="Đăng ký tài khoản" />
         </td>
     </tr>
     <tr>
         <td colspan="2">
             <asp:Label ID="LabelMessage" runat="server"></asp:Label>
         </td>
     </tr>
 </table>
</asp:Content>
