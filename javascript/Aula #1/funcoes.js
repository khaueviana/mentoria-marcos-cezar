function nome (){}
//criando uma função
nome(); //invocando a função
console.log(nome()); // retorna undefined pq não tem nada dentro da função
//digitar o nome da função sem () retorna a função

var x = 1;
function soma(){
    x = x + 1;
}

function qualquer(){
    var marcos = "Marcos";
}
console.log(qualquer()) //retorna undefined
function qualquer2 (){
    var marcos = "Marcos";
    return marcos;
}
console.log(qualquer2()) //retorna "Marcos"

var y = 4;
function cinco(){
    return 5;
}
y += cinco();
console.log(y);

//funções com argumentos/parâmetros

function soma(x,y){
    return x + y;
}

var soma = soma(1,2);
console.log(soma);
