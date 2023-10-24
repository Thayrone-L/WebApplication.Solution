<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="WebForm.Clientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cliente</title>
    <link href="~/CSS/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.8.3.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <script src="~/Scripts/jquery-3.7.1.min.js"></script>
</head>
<body>
    <div class="container">
    <form id="form1" runat="server">
        <div class="header m-0">
            <h2 class="titulo">Cliente</h2>
            <a href="<%= ResolveUrl("~/Home/Index") %>" class="btn-voltar">Voltar</a>
        </div>
        <asp:HiddenField ID="Id" runat="server" />
        <div class="row row-inputs m-0">
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="CPFLabel" runat="server" CssClass="control-label" AssociatedControlID="CPF">CPF</asp:Label>
                <asp:TextBox ID="CPF" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CPFValidator" runat="server" ControlToValidate="CPF" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 4; width: 80%;">
                <asp:Label ID="NomeLabel" runat="server" CssClass="control-label" AssociatedControlID="Nome">Nome</asp:Label>
                <asp:TextBox ID="Nome" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NomeValidator" runat="server" ControlToValidate="Nome" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row row-inputs m-0">
            <div style="flex: 1.5; width: 25%;">
                <asp:Label ID="RGLabel" runat="server" CssClass="control-label" AssociatedControlID="RG">RG</asp:Label>
                <asp:TextBox ID="RG" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RGValidator" runat="server" ControlToValidate="RG" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 0.8; width: 10%;">
                <asp:Label ID="DataExpedicaoLabel" runat="server" CssClass="control-label" AssociatedControlID="DataExpedicao">Data de expedicao</asp:Label>
                <asp:TextBox ID="DataExpedicao" runat="server" CssClass="form-control" ClientIDMode="Static" Text='<%# Bind("DataExpedicao") %>' />
                <asp:RequiredFieldValidator ID="DataExpedicaoValidator" runat="server" ControlToValidate="DataExpedicao" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 1.2; width: 40%;">
                <asp:Label ID="OrgaoExpedicaoLabel" runat="server" CssClass="control-label" AssociatedControlID="OrgaoExpedicao">Órgão expeditor</asp:Label>
                <asp:DropDownList ID="OrgaoExpedicao" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Selecione um orgão expeditor" Value="" />
                    <asp:ListItem Text="SSP/AC" Value="AC" />
                    <asp:ListItem Text="SSP/AL" Value="AL" />
                    <asp:ListItem Text="SSP/AP" Value="AP" />
                    <asp:ListItem Text="SSP/AM" Value="AM" />
                    <asp:ListItem Text="SSP/BA" Value="BA" />
                    <asp:ListItem Text="SSPDS/CE" Value="CE" />
                    <asp:ListItem Text="SSP/DF" Value="DF" />
                    <asp:ListItem Text="SESP/ES" Value="ES" />
                    <asp:ListItem Text="SSP/GO" Value="GO" />
                    <asp:ListItem Text="SSP/MA" Value="MA" />
                    <asp:ListItem Text="SSP/MT" Value="MT" />
                    <asp:ListItem Text="SSP/MS" Value="MS" />
                    <asp:ListItem Text="SSP/MG" Value="MG" />
                    <asp:ListItem Text="SSP/PA" Value="PA" />
                    <asp:ListItem Text="SSP/PB" Value="PB" />
                    <asp:ListItem Text="SSP/PR" Value="PR" />
                    <asp:ListItem Text="SSP/PE" Value="PE" />
                    <asp:ListItem Text="SSP/PI" Value="PI" />
                    <asp:ListItem Text="SSP/RJ" Value="RJ" />
                    <asp:ListItem Text="SESED/RN" Value="RN" />
                    <asp:ListItem Text="SSP/RS" Value="RS" />
                    <asp:ListItem Text="SESDEC/RO" Value="RO" />
                    <asp:ListItem Text="SESP/RR" Value="RR" />
                    <asp:ListItem Text="SSP/SC" Value="SC" />
                    <asp:ListItem Text="SSP/SP" Value="SP" />
                    <asp:ListItem Text="SSP/SE" Value="SE" />
                    <asp:ListItem Text="SSP/TO" Value="TO" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="OrgaoExpedicaoValidator" runat="server" ControlToValidate="OrgaoExpedicao" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 0.8; width: 10%;">
                <asp:Label ID="UfExpedicaoLabel" runat="server" CssClass="control-label" AssociatedControlID="UfExpedicao">UF Expedição</asp:Label>
                <asp:TextBox ID="UfExpedicao" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UfExpedicaoValidator" runat="server" ControlToValidate="UfExpedicao" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row row-inputs m-0">
            <div style="flex: 0.3; width: 10%;">
                <asp:Label ID="DataNascimentoLabel" runat="server" CssClass="control-label" AssociatedControlID="DataNascimento">Data de nascimento</asp:Label>
                <asp:TextBox ID="DataNascimento" runat="server" CssClass="form-control" ClientIDMode="Static" Text='<%# Bind("DataNascimento") %>' />
                <asp:RequiredFieldValidator ID="DataNascimentoValidator" runat="server" ControlToValidate="DataNascimento" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 0.3; width: 10%;">
                <asp:Label ID="SexoLabel" runat="server" CssClass="control-label" AssociatedControlID="Sexo">Sexo</asp:Label>
                <asp:DropDownList ID="Sexo" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Selecione o Sexo" Value="" />
                    <asp:ListItem Text="Masculino" Value="Masculino" />
                    <asp:ListItem Text="Feminino" Value="Feminino" />
                    <asp:ListItem Text="Outro" Value="Outro" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="SexoValidator" runat="server" ControlToValidate="Sexo" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="EstadoCivilLabel" runat="server" CssClass="control-label" AssociatedControlID="EstadoCivil">Estado civil</asp:Label>
                <asp:TextBox ID="EstadoCivil" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="EstadoCivilValidator" runat="server" ControlToValidate="EstadoCivil" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <h2 class="titulo">Endereço do Cliente</h2>
        <div class="row row-inputs m-0">
            <div style="flex: 1; width: 90%;">
                <asp:Label ID="CEPLabel" runat="server" CssClass="control-label">CEP</asp:Label>
                <div class="input-group m-0 p-0">
                    <asp:TextBox ID="CEP" runat="server" CssClass="form-control m-0" ClientIDMode="Static" />
                    <span class="input-group-text align-items-center"><i class="fa fa-search" id="buscaCep"></i></span>
                </div>
                <asp:RequiredFieldValidator ID="CEPValidator" runat="server" ControlToValidate="CEP" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="LogradouroLabel" runat="server" CssClass="control-label">Logradouro</asp:Label>
                <asp:TextBox ID="Logradouro" runat="server" CssClass="form-control" ClientIDMode="Static" />
                <asp:RequiredFieldValidator ID="LogradouroValidator" runat="server" ControlToValidate="Logradouro" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="NumeroLabel" runat="server" CssClass="control-label">Número</asp:Label>
                <asp:TextBox ID="Numero" runat="server" CssClass="form-control" ClientIDMode="Static" />
                <asp:RequiredFieldValidator ID="NumeroValidator" runat="server" ControlToValidate="Numero" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row row-inputs m-0">
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="ComplementoLabel" runat="server" CssClass="control-label">Complemento</asp:Label>
                <asp:TextBox ID="Complemento" runat="server" CssClass="form-control" ClientIDMode="Static" />
                <asp:RequiredFieldValidator ID="ComplementoValidator" runat="server" ControlToValidate="Complemento" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="BairroLabel" runat="server" CssClass="control-label">Bairro</asp:Label>
                <asp:TextBox ID="Bairro" runat="server" CssClass="form-control" ClientIDMode="Static" />
                <asp:RequiredFieldValidator ID="BairroValidator" runat="server" ControlToValidate="Bairro" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="CidadeLabel" runat="server" CssClass="control-label">Cidade</asp:Label>
                <asp:DropDownList ID="CidadeSelect" runat="server" CssClass="form-control" ClientIDMode="Static">
                    <asp:ListItem Text="Selecione uma cidade" Value="" />
                </asp:DropDownList>
                <asp:TextBox ID="CidadeText" runat="server" CssClass="form-control" ClientIDMode="Static" style="display: none" />
                <asp:RequiredFieldValidator ID="CidadeValidator" runat="server" ControlToValidate="CidadeText" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
            <div style="flex: 1; width: 10%;">
                <asp:Label ID="UfLabel" runat="server" CssClass="control-label">UF</asp:Label>
                <asp:DropDownList ID="UF" runat="server" CssClass="form-control" ClientIDMode="Static">
                    <asp:ListItem Text="Selecione um estado" Value="" />
                    <asp:ListItem Text="Acre" Value="AC" />
                    <asp:ListItem Text="Alagoas" Value="AL" />
                    <asp:ListItem Text="Amapá" Value="AP" />
                    <asp:ListItem Text="Amazonas" Value="AM" />
                    <asp:ListItem Text="Bahia" Value="BA" />
                    <asp:ListItem Text="Ceará" Value="CE" />
                    <asp:ListItem Text="Distrito Federal" Value="DF" />
                    <asp:ListItem Text="Espírito Santo" Value="ES" />
                    <asp:ListItem Text="Goiás" Value="GO" />
                    <asp:ListItem Text="Maranhão" Value="MA" />
                    <asp:ListItem Text="Mato Grosso" Value="MT" />
                    <asp:ListItem Text="Mato Grosso do Sul" Value="MS" />
                    <asp:ListItem Text="Minas Gerais" Value="MG" />
                    <asp:ListItem Text="Pará" Value="PA" />
                    <asp:ListItem Text="Paraíba" Value="PB" />
                    <asp:ListItem Text="Paraná" Value="PR" />
                    <asp:ListItem Text="Pernambuco" Value="PE" />
                    <asp:ListItem Text="Piauí" Value="PI" />
                    <asp:ListItem Text="Rio de Janeiro" Value="RJ" />
                    <asp:ListItem Text="Rio Grande do Norte" Value="RN" />
                    <asp:ListItem Text="Rio Grande do Sul" Value="RS" />
                    <asp:ListItem Text="Rondônia" Value="RO" />
                    <asp:ListItem Text="Roraima" Value="RR" />
                    <asp:ListItem Text="Santa Catarina" Value="SC" />
                    <asp:ListItem Text="São Paulo" Value="SP" />
                    <asp:ListItem Text="Sergipe" Value="SE" />
                    <asp:ListItem Text="Tocantins" Value="TO" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="UFValidator" runat="server" ControlToValidate="UF" CssClass="text-danger" ErrorMessage="Campo obrigatório">*</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="btn-container">
        <asp:Button ID="btnCreateCliente" runat="server" Text="Avançar" OnServerClick="btnCreateCliente_Click" CssClass="btn-avancar" />
        </div>
    </form>
   </div>
</body>
</html>
