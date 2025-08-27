<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="CapaPresentacion.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/stylebingo.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-header">
                        Sistema de juegos de Bingo
                    </div>
                    <div class="card-body">
                        <div class="row mt-3">
                            <div class="col-sm-12">
                                <div class="slider" reverse="true" style="
                                    --width: 200px;
                                    --height: 200px;
                                    --quantity: 9;
                                ">
                                    <div class="list">
                                        <div class="item" style="--position: 1"><img src="image/diagonal.png" alt=""></div>
                                        <div class="item" style="--position: 2"><img src="image/DiagonalD.png" alt=""></div>
                                        <div class="item" style="--position: 3"><img src="image/doblev.png" alt=""></div>
                                        <div class="item" style="--position: 4"><img src="image/Explocion.png" alt=""></div>
                                        <div class="item" style="--position: 5"><img src="image/lacloca.png" alt=""></div>
                                        <div class="item" style="--position: 6"><img src="image/lloca.png" alt=""></div>
                                        <div class="item" style="--position: 7"><img src="image/triplev.png" alt=""></div>
                                        <div class="item" style="--position: 8"><img src="image/slider2_8.png" alt=""></div>
                                        <div class="item" style="--position: 9"><img src="image/slider2_9.png" alt=""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
