<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformeEdu.aspx.cs" Inherits="GestionHojasDeVida.Reports.InformeEdu" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: #000000;
}

li {
    float: right;
}

li a {
    display: block;
    color: white;
    font-family: Arial;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}

li a:hover {
    background-color: #111;
}
</style>
    <style type="text/css">


        .auto-style34 {
            width: 327px;
        }
        .auto-style45 {
            width: 345px;
            height: 20px;
        }
        .auto-style48 {
            width: 335px;
            height: 20px;
        }
        .auto-style51 {
            width: 495px;
            height: 20px;
        }
        .auto-style46 {
            width: 345px;
            height: 42px;
        }
        .auto-style47 {
            height: 42px;
        }
        .auto-style52 {
            width: 495px;
            height: 42px;
        }
        .auto-style26 {
            height: 20px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div style="background-color: #000000" >
            &nbsp;&nbsp;&nbsp;
             <ul>
                 <asp:Label ID="Label5" runat="server" Font-Names="Advertising Script" Font-Size="XX-Large" ForeColor="White" Text=".     Hojas de Vida"></asp:Label>
                   <li><a href="../../Views/UsuarioLoginDTO/Main.cshtml">Salir</a></li>
                 
                 <li><a href="../InformeA/InformeA.aspx">Por Area</a></li>
                 <li><a href="../InformeE/InformeE.aspx">Por Salario</a></li>
                 
                  <li><a href="../InformeEduc/InformeEdu.aspx">Por Educacion</a></li>
  
</ul>
            <br />
        </div>
        <br />
        <br />
        <table style="border-left: 2px solid #1A4752; border-right: 2px solid #1A4752; border-top: 2px solid #1A4752; width: 20%; border-radius: 8px; background-color: #31869B; border-bottom-color: #1A4752; border-bottom-width: 2px; margin-left: 318px;">
            <tr>
                <td ;class="auto-style34" class="auto-style34" style="text-align: left">
                    <asp:Label ID="Label4" runat="server" Font-Names="Aharoni" Font-Size="14pt" ForeColor="White" Text="Informe Empleados Area y Educacion"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="border: 2px solid #1A4752; margin: auto; width: 60%; height: 87px; border-radius: 8px">
            <tr>
                <td class="auto-style45"></td>
                <td class="auto-style48"></td>
                <td class="auto-style26"></td>
                <td class="auto-style51"></td>
            </tr>
            <tr>
                <td class="auto-style46" style="text-align: right">
                    <asp:Label ID="lblId6" runat="server" Font-Bold="True" Font-Names="Aharoni" Font-Size="14pt" ForeColor="Black" Text="Area:"></asp:Label>
                &nbsp;
                    <asp:DropDownList ID="cmbTecnicos" runat="server" Font-Names="Tw Cen MT" Font-Size="10pt" Height="19px" Width="184px" DataSourceID="Areas" DataTextField="DESCRIP_AREA" DataValueField="ID_AREA">
                        <asp:ListItem>a</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="Areas" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionGestionHv %>" SelectCommand="SELECT * FROM [AREA]"></asp:SqlDataSource>
                    </td>
                <td class="auto-style47" colspan="3" style="text-align: left">
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblId4" runat="server" Font-Bold="True" Font-Names="Aharoni" Font-Size="14pt" ForeColor="Black" Text="Nivel Educativo:"></asp:Label>
                &nbsp;<asp:DropDownList ID="cmbTecnicos0" runat="server" Font-Names="Tw Cen MT" Font-Size="10pt" Height="19px" Width="184px">
                        <asp:ListItem>TECNICO</asp:ListItem>
                        <asp:ListItem>PROFESIONAL</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/buscar.jpg" OnClick="ImageButton1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style46" style="text-align: right">
                    &nbsp;</td>
                <td class="auto-style47" colspan="2" style="text-align: left">
                    &nbsp;</td>
                <td class="auto-style52" style="text-align: left">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26" colspan="4">
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="Reports\InformeEduc\InformeEduAre.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
                </td>
            </tr>
            <tr>
                <td class="auto-style26" colspan="4">&nbsp;</td>
            </tr>
        </table>
    
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConexionGestionHv %>" SelectCommand="SP_INFORME_EDU_AREA" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="cmbTecnicos" DefaultValue="5" Name="AREA" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="cmbTecnicos0" DefaultValue="TECNICO" Name="ESTUDIO" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
