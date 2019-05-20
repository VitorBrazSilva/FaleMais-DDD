

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

function Calcular() {
    var origem = $("#ddd_origem").val();
    var destino = $("#ddd_destino").val();
    var tempoPlano = $("#plano").val();
    var tempoGasto = $("#tempo_ligacao").val();
    $.ajax({
        method: "GET",
        url: "/Tarifa/Calcular",
        data: { origem: origem, destino: destino, tempoPlano: tempoPlano, tempoGasto: tempoGasto }
    })
        .done(function (data) {

            $("#resultCalculo").empty();

            $("#resultCalculo").append(`
                <table class="table">
                    <thead class="thead-dark">
                    <tr>
                        <th scope="col">Origem</th>
                        <th scope="col">Destino</th>
                        <th scope="col">Tempo</th>
                        <th scope="col">Plano FaleMais</th>
                        <th scope="col">Com FaleMais</th>
                        <th scope="col">Sem FaleMais</th>
                    </tr>
                    </thead>
                    <tbody>
                    <tr>
                        <td>${data.Origem}</td>
                        <td>${data.Destino}</td>
                        <td>${data.Tempo}</td>
                        <td>${data.Plano}</td>
                        <td>R$ ${data.CalculoComPlano.toFixed(2)}</td>
                        <td>R$ ${data.CalculoSemPlano.toFixed(2)}</td>
                    </tr>
                    </tbody>
                </table>
            `);            
        });
}