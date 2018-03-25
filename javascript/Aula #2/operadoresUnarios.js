var numero3 = +3;
console.log(numero3);//retorna o número 3
console.log(typeof(numero3));//retorna number

var string3 = +"3";
console.log(string3); //retorna o número 3 sem ""
console.log(typeof(string3));//retorna number pois o + é um operador unário que faz essa conversão quando o conteúdo de uma string é um número

var teste = +"dsads";
console.log(teste); //retorna NaN
console.log(typeof(teste));//retorna um number, então NaN é do tipo number

var concatenado = "mar" + "cos";
console.log(concatenado); //retorna "marcos", pois o sinal de mais concatena(junta) as duas strings
console.log(typeof(concatenado));//retorna string

var concatenado1 = 3 + "3";
console.log(concatenado1); //retorna 33, outra seja ele tratou o 3 number como string e concatenou com "3"
console.log(typeof(concatenado1));//retorna string pois houve uma conversão do 3 number para string

var concatenado2 = "3" + 3;
console.log(concatenado2); //mesmo resultado visto em cima
console.log(typeof(concatenado2));

var numero3negativo = -3;
console.log(numero3negativo); //retorna menos 3, pois o sinal de - deixa o número negativo
console.log(typeof(numero3negativo));

var string3negativa = -"3";
console.log(string3negativa); //retorna -3 sem ""
console.log(typeof(string3negativa));//retorna number, logo, houve uma conversão de string para number com esse operador unário

var teste1 = "Mar" - "cos";
console.log(teste1); //retorna NaN pois não é possível realizar operações matemática com tipos que não são números
console.log(typeof(teste1));

var teste2 = "3" - 2;
console.log(teste2); //retorna o resultado da operações 3 - 2 =1
console.log(typeof(teste2));//retorna number, ou seja, o js converte a string para number para realizar a operação;

var teste3 = 3 - "2";
console.log(teste3); //mesmo resultado visto em cima
console.log(typeof(teste3));