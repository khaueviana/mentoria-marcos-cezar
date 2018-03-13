//criando variáveis de escopo global
var global;
var globalzinho = 1;
//logo, posso acessar em qualquer parte do código
console.log(global);
console.log(globalzinho);
function retornaGlobal(){
    return globalzinho;
}
console.log(retornaGlobal());

//variáveis de escopo local
function retornaLocal(){
    var local = "Não pode me acessar de fora da função";
    return local;
}
var resultado = retornaLocal();
console.log(resultado);
//console.log(local); gera erro pois local não é definida

//criar variáveis sem o var é um perigo
function teste(){
    x = 42;
    return x;
}
console.log(teste());
console.log(x); //agora posso acessar os dados de x, pois ele foi criado como global

//argumentos de função também são locais

function teste1 (arg){
    return arg;
}
console.log(teste1(2));
//console.log(arg); retorna um erro

/* variáveis devem ser criadas sempre no inicio de uma função
Quando o JS vai rodar um código, primeiro ele cria todas as variáveis com o valor undefined 
e depois associa os valores conforme a leitura do código, podendo criar erros. */

function teste2(){
    console.log(exemplo); //diz ser undefined pq exemplo foi apenas criada sem valor atribuido ainda

    var exemplo = "Apenas teste";
    return exemplo;
}

console.log(teste2());

//corrigindo isso
function teste3(){
    var exemplo = "Apenas teste";
    console.log(exemplo);

    return exemplo;
}
console.log(teste3());