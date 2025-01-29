<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="otel_Registration.aspx.cs" Inherits="Ado.net.Hotel_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(img/3d.jpg);background-repeat:no-repeat;background-size:cover">
       <div  style="width:500px; padding:35px; margin:10% 30%;border-radius:15px; background-color:black;color:white;box-shadow:2px 2px 10px white;">       
    <form id="form1" runat="server" >
        
        <table align="center" style="background-color:black;" >
                 <tr>
                       <td colspan="2" align="center"><h2 style=" color:white;"><u>Registration form</u></h2></td>
                 </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">First Name  </td>
                    <td><asp:TextBox ID="txtFN" runat="server" /></td>
                    <td><asp:RequiredFieldValidator ID="rvF" runat="server" ControlToValidate="txtFN" ErrorMessage="First Name Field Can't Be Left Empty"   Display="Dynamic" ForeColor="White" SetFocusOnError="True" /></td>
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;"> Last Name </td>
                    <td><asp:TextBox ID="txtLN" runat="server" /></td>
                    <td><asp:RequiredFieldValidator ID="rvL" runat="server" ControlToValidate="txtLN" ErrorMessage="Last Name Field Can't Be Left Empty" Display="Dynamic" ForeColor="White" SetFocusOnError="True" /></td>
                </tr>
               <tr>
                   <td style=" color:cyan;font-size:18px;">Username </td>
                   <td><asp:TextBox  ID="txtusername" runat="server"/></td>
                   <td><asp:RequiredFieldValidator ID="rvUsername" runat="server" ControlToValidate="txtusername" ErrorMessage="Username Field Can't Be Left Empty" Display="Dynamic" ForeColor="White" SetFocusOnError="True" />
                      
                   </td>
               </tr>
                <tr>
                    <td> <label style=" color:cyan;font-size:18px;">Gender</label></td>
                    <td>
                        <asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="gender" style=" color:cyan;font-size:18px;"/>
                        <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="gender"  style=" color:cyan;font-size:18px;"/>
                        <asp:RadioButton ID="other" runat="server" Text="Other" GroupName="gender"  style=" color:cyan;font-size:18px;"/>
                    </td>
                    
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">Password </td>
                    <td><asp:TextBox ID="txtPassW" runat="server" TextMode="Password"  /></td>
                    <td><asp:RequiredFieldValidator ID="rvPaw" runat="server" ControlToValidate="txtPassW" ErrorMessage="Password Field Can't Be Left Empty" Display="Dynamic" ForeColor="White" SetFocusOnError="True" />
<%--                        <asp:RegularExpressionValidator ID="regExp" ControlToValidate="txtPassW" runat="server" ForeColor="White" SetFocusOnError="True"  Display="Dynamic" ErrorMessage="Min one Alphabet,numeric,Lowercase and spacial character" ValidationExpression="^[A-z]{1,}\S[a-z]{1,}[0-9]{1,}\@#$%&{1,2}\$" />--%>
                       
                    </td>
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">Confirm password </td>
                    <td> <asp:TextBox ID="Txtconf" runat="server" TextMode="Password" /></td>
                    <td><asp:RequiredFieldValidator ID="rvfConfpaw" ControlToValidate="Txtconf" runat="server" ErrorMessage=" Conform Password Field Can't Be Left Empty" Display="Dynamic" ForeColor="White" SetFocusOnError="True" />
                        <asp:CompareValidator ID="mayur" runat="server" ControlToValidate="Txtconf" ControlToCompare="txtPassW" type="String" Operator="Equal" ErrorMessage="Confirm password should match with password." Display="Dynamic"  ForeColor="White" SetFocusOnError="True" />
                    </td>
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">Email  </td>
                    <td><asp:TextBox ID="txtemail" runat="server" TextMode="Email" /></td>
                    <td><asp:RequiredFieldValidator ID="rvEmail" runat="server" Display="Dynamic" ControlToValidate="txtemail" ErrorMessage="Email Field Can't Be Left Empty" ForeColor="White" SetFocusOnError="True" /></td>
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">Phone </td>
                    <td> <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone" /></td>
                    <td><asp:RequiredFieldValidator ID="rvPhone" ControlToValidate="txtPhone" runat="server" ErrorMessage="Phone Field Can't Be Left Empty" Display="Dynamic" ForeColor="White" SetFocusOnError="True" /></td>
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">Address  </td>
                    <td><asp:TextBox ID="txtADD" runat="server" TextMode="MultiLine" /></td>
                    <td><asp:RequiredFieldValidator ID="rvAdd" runat="server" ControlToValidate="txtADD" Display="Dynamic" ErrorMessage="Address Field Can't Be Left Empty" ForeColor="White" SetFocusOnError="True" /></td>
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">Age  </td>
                    <td> <asp:TextBox ID="txtAge" runat="server" /> </td>
                    <td><asp:RequiredFieldValidator ID="rvAge" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Age Field Can't Be Left Empty" ForeColor="White" SetFocusOnError="True" /></td>
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;">Languages known </td>
                    <td>
                        <asp:CheckBox ID="cbEnglish" runat="server" Text="English" style=" color:cyan;font-size:18px;"/>
                        <asp:CheckBox ID="cbMarathi" runat="server" Text="Marathi" style=" color:cyan;font-size:18px;" />
                        <asp:CheckBox ID="cbHindi" runat="server" Text="Hindi"  style=" color:cyan;font-size:18px;"/>
                    </td>
                   
                </tr>
                <tr>
                    <td style=" color:cyan;font-size:18px;"><label for="ddlCountry">Country </label></td>
                    <td>
                           <asp:DropDownList ID="ddlCountry" runat="server">
                                    <asp:ListItem Text="Select Country" Value=""/>
                                    <asp:ListItem Text="India" Value="India"/>
                                    <asp:ListItem Text="Swedan" Value="Swedan"/>
                                    <asp:ListItem Text="jarmani" Value="jarmani"/>
                                    <asp:ListItem Text="Japan" Value="Japan"/>
                                    <asp:ListItem Text="USA" Value="USA"/>
                                    <asp:ListItem Text="Canada" Value="Canada"/>
                                    <asp:ListItem Text="Nepal" Value="Nepal"/>
                                    <asp:ListItem Text="Pakistan" Value="Pakistan"/>
                                    <asp:ListItem Text="Spain" Value="Spain"/>
                                     <asp:ListItem Text="Zambia" Value="Zambia"/>
                                     <asp:ListItem Text="Russia" Value="Russia"/>
                                     <asp:ListItem Text="Norway" Value="Norway"/>
                                     <asp:ListItem Text="Iceland" Value="Iceland"/>
                            </asp:DropDownList>
                     </td>
                     <td><asp:RequiredFieldValidator ID="rvddlCountry" ControlToValidate="ddlCountry" ErrorMessage="please select Country" runat="server" Display="Dynamic" ForeColor="White" SetFocusOnError="True" /></td>
                </tr>
                <tr>
                    <td align="right" rowspan="2"> <asp:Button ID="btnreg" runat="server" Text="Register" ForeColor="White" style="background-color:brown" OnClick="btnreg_Click" Width="70px"  Height="30px"/></td>
                    <td align="left" rowspan="2"><asp:Button ValidationGroup="loginGroup" ID="btnlogin" runat="server" Text="Login" ForeColor="White"  style="background-color:brown" Width="70px"  Height="30px" OnClick="btnlogin_Click" /></td>
                </tr>
            </table>
     
    </form>
        </div>
</body>
</html>
