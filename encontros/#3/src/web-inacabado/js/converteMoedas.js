function numeroParaReal(numero){
    var numeroFormatado = numero.toFixed(2);
    numeroFormatado = numeroFormatado.replace('.',',');
    tamanho = numeroFormatado.length - 4;
    posicoes = [];
    contador = 0
    if(parseInt(tamanho/3) >= 0){
        for (var i=1;i<=parseInt(tamanho/3);i++){
            numero = i*3 -3+1;
            posicoes.push(numero);
        }
        for(var i=0; i<=posicoes.length-1;i++){
            posicaoatual = posicoes[i] + contador;
            m = numeroFormatado.substring(0,posicaoatual);
            n = numeroFormatado.substring(posicaoatual);
            numeroFormatado = m +'.'+n;
            contador += 1;
        }
    }
    numeroFormatado = "R$ " + numeroFormatado;
    return numeroFormatado;
}
function realParaNumero(texto){
    texto = texto.replace('.','');
    texto = texto.replace('R$ ','');
    texto = texto.replace(',','.');
    var numeroGerado = parseFloat(texto);
    return numeroGerado;
}
