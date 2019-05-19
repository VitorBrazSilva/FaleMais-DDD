

function GetOrigem(val) {
    $.ajax({
        method: "GET",
        url: "/Tarifa/GetDestino",
        data: { dddOrigem: val }
    })
        .done(function (data) {
            $("#ddd_destino").empty();
            $("#ddd_destino").append('<option value>Selecione...</option>');
            $.each(data, function (index, element) {
                $("#ddd_destino").append('<option value="' + element + '"> DDD ' + element + '</option>');
            });
        });
}