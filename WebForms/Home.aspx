<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebForm.Clientes" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Clientes</title>    
    <link href="~/CSS/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.8.3.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <script src="~/Scripts/jquery-3.7.1.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header m-0">
                <h2>Clientes</h2>
                <asp:Button ID="novoCliente" runat="server" CssClass="btn-novo" Text="Novo Cliente" OnClick="novoCliente_Click" />
            </div>

            <table class="table table-striped">
                <thead>
                    <tr>
                        <th style="width: 150px;">CPF</th>
                        <th style="width: 150px;">Nome</th>
                        <th style="width: 70px;">Data de Nascimento</th>
                        <th style="width: 80px;">Sexo</th>
                        <th style="width: 100px;">Estado Civil</th>
                        <th style="width: 100px;">CEP</th>
                        <th style="width: 150px;">Logradouro</th>
                        <th style="width: 50px;">Número</th>
                        <th style="width: 100px;">Complemento</th>
                        <th style="width: 80px;">Bairro</th>
                        <th style="width: 100px;">Cidade</th>
                        <th style="width: 50px;">UF</th>
                    </tr>
                </thead>
                <tbody>
                    <%--<asp:Repeater runat="server" ID="repeaterClientes">
                        <ItemTemplate>
                            <tr data-id='<%# Eval("Id") %>'>
                                <td><%# Eval("CPF") %></td>
                                <td><%# Eval("Nome") %></td>
                                <td><%# Convert.ToDateTime(Eval("DataNascimento")).ToString("dd/MM/yyyy") %></td>
                                <td><%# Eval("Sexo") %></td>
                                <td><%# Eval("EstadoCivil") %></td>
                                <td><%# Eval("endereco.CEP") %></td>
                                <td><%# Eval("endereco.Logradouro") %></td>
                                <td><%# Eval("endereco.Numero") %></td>
                                <td><%# Eval("endereco.Complemento") %></td>
                                <td><%# Eval("endereco.Bairro") %></td>
                                <td><%# Eval("endereco.Cidade") %></td>
                                <td><%# Eval("endereco.UF") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>--%>
                </tbody>
            </table>

<%--            <asp:DataPager ID="dataPager" runat="server" PagedControlID="repeaterClientes">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                </Fields>
            </asp:DataPager>--%>
        </div>
    </form>
</body>
</html>
