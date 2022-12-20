<%@ PAGE Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addDipendente.aspx.cs" Inherits="esercizioWebForm.addDipendente" %>

<ASP:CONTENT ID="Content1" ContentPlaceHolderID="head" runat="server">
</ASP:CONTENT>
<ASP:CONTENT ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row justify-content-between align-items-center">

            <div class=" col-3 d-flex flex-column justify-content-between ">

                <ASP:LABEL ID="Label1" runat="server" Text="Label" Visible="false" ForeColor="Red"></ASP:LABEL>
             
                <ASP:LABEL ID="lblNome" runat="server" Text="Nome:"></ASP:LABEL>
                <ASP:TEXTBOX ID="txtNome" runat="server"></ASP:TEXTBOX>

                <ASP:LABEL ID="lblCognome" runat="server" Text="Cognome:"></ASP:LABEL>
                <ASP:TEXTBOX ID="txtCognome" runat="server"></ASP:TEXTBOX>


                <ASP:LABEL ID="lblINDIRIZZO" runat="server" Text="Indirizzo:" CssClass="form-label"></ASP:LABEL>
                <ASP:TEXTBOX ID="TXTINDIRIZZO" runat="server"></ASP:TEXTBOX><br />


                <ASP:LABEL ID="lblcf" runat="server" Text="Codice Fiscale:"></ASP:LABEL>
                <ASP:TEXTBOX ID="Textcf" runat="server"></ASP:TEXTBOX>

                <div>
                    <ASP:LABEL ID="lblconiugato" runat="server" Text="Coniugato?"></ASP:LABEL>
                    <ASP:CHECKBOX ID="CheckBox1" runat="server" />
                </div>

                <ASP:LABEL ID="lblfigli" runat="server" Text="figli:"></ASP:LABEL>
                <ASP:TEXTBOX ID="Textfigli" runat="server"></ASP:TEXTBOX>

                <ASP:LABEL ID="lblmansione" runat="server" Text="mansione:"></ASP:LABEL>
                <ASP:TEXTBOX ID="Textmansione" runat="server"></ASP:TEXTBOX><br />

                <ASP:BUTTON ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />

            </div>
            <div class="col-6">
             <img src=".\Models\img\giphy.gif" class="img-fluid border-end border-top" alt="...">
        </div>
        </div>
    </div>



</ASP:CONTENT>


