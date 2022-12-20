<%@ PAGE Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="esercizioWebForm.home" %>

<ASP:CONTENT ID="Content1" ContentPlaceHolderID="head" runat="server">
</ASP:CONTENT>
<ASP:CONTENT ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container m-0">

        <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel" data-interval="600">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="img-carousel" src="https://images.pexels.com/photos/159358/construction-site-build-construction-work-159358.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">
                </div>
                <div class="carousel-item">
                    <img class="img-carousel" src="https://images.pexels.com/photos/2219024/pexels-photo-2219024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">
                </div>
                <div class="carousel-item">
                    <img class="img-carousel" src="https://images.pexels.com/photos/271667/pexels-photo-271667.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1">
                </div>
            </div>
        </div>



        <ASP:LABEL ID="LabelErr" runat="server" ForeColor="Red"></ASP:LABEL>
        <div class="d-flex row p-4">
            <ASP:REPEATER ID="RepeaterListaDipendenti" runat="server" ItemType="esercizioWebForm.Models.dipendente">

                <ITEMTEMPLATE>
                    <div class="col-2 card card-body align-items-start border-1 g-5 m-2 p-2">
                        <p class=" display-5 hover-shadow"><%#Item.Nome%> <%#Item.Cognome%></p>
                        <p class="  hover-shadow ">Indirizzo: <%#Item.Indirizzo%></p>
                        <p class="  hover-shadow ">C.F: <%#Item.CF%></p>
                        <p class="  hover-shadow"><%#Item.statoMatrimonio%></p>
                        <p class="  hover-shadow ">Numero dei figli: <%#Item.figli%></p>
                        <p class="  hover-shadow"><%#Item.Mansione%></p>
                    </div>

                </ITEMTEMPLATE>

            </ASP:REPEATER>
        </div>

    </div>

</ASP:CONTENT>
