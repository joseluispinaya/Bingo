<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="PageFiguras.aspx.cs" Inherits="CapaPresentacion.PageFiguras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/crearjugada.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="card">
                <div class="card-header text-center">
                    Crear Jugadas
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class="col-sm-4">
                            <h6 class="text-center mb-3">Registre Jugadas</h6>

                            <div class="row">
                                <div class="col-sm-12 d-flex justify-content-center">
                                    <table>
                                        <tbody>
                                            <tr>
                                                <th>B</th>
                                                <th>I</th>
                                                <th>N</th>
                                                <th>G</th>
                                                <th>O</th>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <input type="checkbox" value="" id="B0">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="I0">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="N0">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="G0">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="O0">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <input type="checkbox" value="" id="B1">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="I1">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="N1">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="G1">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="O1">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <input type="checkbox" value="" id="B2">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="I2">
                                                </td>
                                                <td></td>
                                                <td>
                                                    <input type="checkbox" value="" id="G2">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="O2">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <input type="checkbox" value="" id="B3">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="I3">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="N3">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="G3">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="O3">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <input type="checkbox" value="" id="B4">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="I4">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="N4">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="G4">
                                                </td>
                                                <td>
                                                    <input type="checkbox" value="" id="O4">
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>

                        </div>
                        <div class="col-sm-8" id="loadinn">
                            <h6 class="text-center mb-3">Registro de Figuras</h6>

                            <div class="row">
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <label for="txtNombre">Nombre Figura</label>
                                        <input type="text" class="form-control form-control-sm" id="txtNombre" name="Nombre">
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <label for="txtDescripcion">Descripcion</label>
                                        <input type="text" class="form-control form-control-sm" id="txtDescripcion" name="Descripcion">
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="estructurajuegolo">Estructura del juego</label>
                                <textarea class="form-control" id="estructurajuegolo" rows="3"></textarea>
                            </div>

                            <div class="row justify-content-center g-3 mt-3">
                                <div class="col-auto">
                                    <button type="button" id="btnCrearfigura" class="btn btn-success btn-sm">Guardar Figura</button>
                                </div>

                                <div class="col-auto">
                                    <button type="button" id="btnNuevo" class="btn btn-danger btn-sm">Ver figura</button>
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
    <script src="js/PageFiguras.js" type="text/javascript"></script>
</asp:Content>
