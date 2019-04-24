
$(function () {


    $(".btnEliminar").on("click", eliminarCategoria);
    $("#btnAceptar").on("click", function () {
        window.location = $("#url").val();
    });
});

function eliminarCategoria(e) {
    e.preventDefault();
    $("#url").val($(this).attr("href"));
    var nombre = $(this).data("nombre");
    $("#modal").find(".modal-body").text("¿Está seguro de que desea suprimir la categoría [" + nombre + "]?");
    $("#modal").modal("show");
}