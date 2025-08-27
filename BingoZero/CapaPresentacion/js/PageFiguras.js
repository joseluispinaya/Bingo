
// Array global para guardar las figuras creadas
let figuras = [];

// columnas del cartón
const columnas = ["B", "I", "N", "G", "O"];

function registrarFigura() {
    let figura = [];

    columnas.forEach(col => {
        for (let fila = 0; fila < 5; fila++) {
            let id = col + fila;
            let checkbox = document.getElementById(id);

            if (!checkbox) continue; // por si acaso falta alguno (ej: N2 en tu HTML)

            // ignorar la casilla del centro (N2)
            if (id === "N2") continue;

            if (checkbox.checked) {
                figura.push({
                    Columna: col,
                    Fila: fila
                });
            }
        }
    });

    if (figura.length === 0) {
        swal("Mensaje", "Debes seleccionar al menos una casilla para crear una figura.", "warning");
        return;
    }

    var request = {
        eFigurasBingo: {
            NombreFigura: $("#txtNombre").val(),
            Descripcion: $("#txtDescripcion").val()
        },
        RequestList: figura
    };

    $.ajax({
        type: "POST",
        url: "PageFiguras.aspx/GuardarFigura",
        data: JSON.stringify(request),
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        beforeSend: function () {
            $("#loadinn").LoadingOverlay("show");
        },
        success: function (response) {
            $("#loadinn").LoadingOverlay("hide");
            if (response.d.Estado) {
                swal("Mensaje", response.d.Mensaje, "success");
            } else {
                swal("Mensaje", response.d.Mensaje, "warning");
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            $("#loadinn").LoadingOverlay("hide");
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        }
    });
}

$('#btnCrearfigura').on('click', function () {
    registrarFigura();
});

function verFigura() {

    var request = {
        idFigura: 1
    };

    $.ajax({
        type: "POST",
        url: "PageFiguras.aspx/ObtenerFigura",
        data: JSON.stringify(request),
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {
            if (response.d.Estado) {
                var figura = response.d.Data;
                //console.log("Figura recibida:", figura);

                if (figura && figura.length > 0) {
                    let texto = "[\n  " + figura.map(f => JSON.stringify(f)).join(",\n  ") + "\n]";
                    $("#estructurajuegolo").val(texto);
                    //document.getElementById("estructurajuego").value = texto;
                } else {
                    $("#estructurajuegolo").val("");
                    //document.getElementById("estructurajuego").value = "[]";
                }

                //$("#estructurajuegolo").val(activo.Comentario);
            } else {
                swal("Mensaje", response.d.Mensaje, "warning");
            }

        }
    });
}

function verFiguraPrue() {

    var request = {
        idFigura: 1
    };

    $.ajax({
        type: "POST",
        url: "PageFiguras.aspx/ObtenerFiguraPrue",
        data: JSON.stringify(request),
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {

            //let texto = "[\n  " + figura.map(f => JSON.stringify(f)).join(",\n  ") + "\n]";

            $("#estructurajuegolo").val(JSON.stringify(response.d));
            // si quieres recorrerlo:
            //response.d.forEach(function (item) {
            //    console.log(item[0], item[1]);
            //});

        }
    });
}

$('#btnNuevo').on('click', function () {
    verFiguraPrue();
});