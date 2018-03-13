//Operadores de igualdade
var x = 0;
var teste = 1 == 1; //retorna um boolean
console.log(teste);
var teste1 = 1 == 2 //retorna false
console.log(teste1);
var teste2 = 2 == 2 //retorna true
console.log(teste2);
var teste3 = 2 != 2; //retorna false
console.log(teste3);

//operadores de igualdade que testam os tipos de dados

var teste4 = "Marcos" == "Marcos"; //true
var nome = "Marcos";
var pessoa = "Maria";
console.log(nome == pessoa); //false

var um = '1'; //string
var numum = 1; //number

var teste5 = um == numum;
console.log(teste5); //retorna true pq o js faz conversão de dados. Que loucura !!!
var teste6 = um === numum; //=== testa se é igual e se são do mesmo tipo
console.log(teste6); //false
var teste7 = um !== numum; //!== testa se são diferente e do mesmo tipo
console.log(teste7);

//Operadores relacionais

var menorQue = 2 < 3;//verifica se 2 é menor que 3;
console.log(menorQue);//true
var menorQue1 = 5 < 4;
console.log(menorQue1);//false
var menorQue2 = 10 < 10;
console.log("10 < 10? R: " + menorQue2);

var maiorQue = 5 > 4; //verifica se 5 é maior que 4
console.log("5 > 4? R: " + maiorQue);
var maiorQue1 = 2 > 3;
console.log("2 > 3? R: " + maiorQue1);
var maiorQue2 = 5 > 5;
console.log("5 > 5? R: " + maiorQue2);

var maiorIgualQ = 5 >= 4; //verifica se 5 é menor ou igual a 4;
console.log("5 >= 4? R: " + maiorIgualQ);
var maiorIgualQ1 = 2 >= 3
console.log("2 >= 3? R: " + maiorIgualQ1);
var maiorIgualQ2 = 5 >= 5;
console.log("5 >= 5? R: " + maiorIgualQ2);

var menorIgualQ = 2 <= 3; //verifica se 2 é menor ou igual a 3;
console.log("2 <= 3? R: " + menorIgualQ);
var menorIgualQ1 = 5 <= 4;
console.log("5 <= 4? R: " + menorIgualQ1);
var menorIgualQ2 = 10 <= 10;
console.log("10 <= 10? R: " + menorIgualQ2);
