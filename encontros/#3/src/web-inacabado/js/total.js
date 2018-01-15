var $input_quantidade = document.querySelector('#qt');
var $output_total = document.querySelector("#total");

$input_quantidade.oninput =  calculaEMostraTotal;

function calculaEMostraTotal(){
    var quantidade = $input_quantidade.value;
     var valorUnitarioTexto = document.querySelector("#preco").textContent;
     var valorUnitarioNumero = realParaNumero(valorUnitarioTexto);

     var total = numeroParaReal(quantidade * valorUnitarioNumero);
     $output_total.value = total;
}