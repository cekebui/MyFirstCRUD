<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       <div style ="font-size:x-large" align="center">Student Info Manage Form</div>
       <table class="nav-justified">
           <tr>
               <td style="width: 77px">&nbsp;</td>
               <td style="width: 114px">Student ID</td>
               <td>
                   <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="286px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 77px">&nbsp;</td>
               <td style="width: 114px">Student Name</td>
               <td>
                   <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="286px"></asp:TextBox>
                   <asp:Button ID="Button5" runat="server" BackColor="#CC33FF" Font-Size="Medium" ForeColor="White" OnClick="Button5_Click" Text="Get" />
               </td>
           </tr>
           <tr>
               <td style="width: 77px">&nbsp;</td>
               <td style="width: 114px">Adress</td>
               <td>
                   <asp:DropDownList ID="DropDownList1" runat="server">
                       <asp:ListItem Value="0">Pilih Satu</asp:ListItem>
                       <asp:ListItem>Malaysia</asp:ListItem>
                       <asp:ListItem>Korea</asp:ListItem>
                       <asp:ListItem>Japan</asp:ListItem>
                       <asp:ListItem>Indonesia</asp:ListItem>
                   </asp:DropDownList>
               </td>
           </tr>
           <tr>
               <td style="width: 77px">&nbsp;</td>
               <td style="width: 114px">Age</td>
               <td>
                   <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="286px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 77px">&nbsp;</td>
               <td style="width: 114px">Contact</td>
               <td>
                   <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" Width="286px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td style="width: 77px; height: 33px"></td>
               <td style="width: 114px; height: 33px"></td>
               <td style="height: 33px">
                   <asp:Button ID="Button1" runat="server" BackColor="#CC33FF" Font-Size="Medium" ForeColor="White" OnClick="Button1_Click" Text="Insert" Width="71px" />
&nbsp;
                   <asp:Button ID="Button2" runat="server" BackColor="#CC33FF" Font-Size="Medium" ForeColor="White" OnClick="Button2_Click1" Text="Update" />
&nbsp;
                   <asp:Button ID="Button3" runat="server" BackColor="#CC33FF" Font-Size="Medium" ForeColor="White" OnClick="Button3_Click" Text="Delete" OnClientClick="return confirm('Padam data ini?');" />
&nbsp;
                   <asp:Button ID="Button4" runat="server" BackColor="#CC33FF" Font-Size="Medium" ForeColor="White" OnClick="Button4_Click" Text="Search" />
               &nbsp;
                   <asp:Button ID="Button6" runat="server" BackColor="#CC33FF" Font-Size="Medium" ForeColor="White" OnClick="Button6_Click" Text="Clear" />
               </td>
           </tr>
           <tr>
               <td style="width: 77px">&nbsp;</td>
               <td style="width: 114px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td style="width: 77px">&nbsp;</td>
               <td style="width: 114px">&nbsp;</td>
               <td>
                   <asp:GridView ID="GridView1" runat="server" Width="432px">
                   </asp:GridView>
               </td>
           </tr>
       </table>
       <br />

   </div>
</asp:Content>
