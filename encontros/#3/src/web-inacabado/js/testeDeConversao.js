var numero = realParaNumero("R$ 1.500,00");
var texto = numeroParaReal(1997.80);

if (numero === 1500 && texto === "R$ 1.997,80"){
    console.log('conversão está funfando');
}else{
    console.log('conversão tá ruim');
}