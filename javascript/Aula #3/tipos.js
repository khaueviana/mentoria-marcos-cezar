//tipos primitivos
var numeroreal = 1.5; //number
console.log(typeof(numeroreal)); //retorna o tipo da variável
var numerointeiro = 2; //number
console.log(typeof(numerointeiro));

var texto = 'kdjadjsa'; //string
console.log(typeof(texto));

var bool = true; //boolean
console.log(typeof(bool));

var naoDefinido; //undefined
console.log(typeof(naoDefinido));

//objetos

var carro = {cor:"preto",portas: 4, modelo: "BMW" };
console.log(carro);
console.log(typeof(carro));

var cachorro = {late:true,raca:"viralata",cor:"Marrom",idade:1}
console.log(cachorro);
console.log(typeof(cachorro));

var marcos = {nome:"Marcos",idade:20};
console.log(marcos);
console.log(typeof(marcos));

//lendo propriedade dos objetos
console.log(carro.cor);
console.log(carro.modelo);

console.log(cachorro.raca);
console.log(cachorro.late);

console.log(marcos.idade);
console.log(marcos.nome);
console.log("---------------------------------------------------------------------------");
console.log(marcos["nome"]); //outra maneira de se ler uma propriedade
console.log(cachorro["cor"]);
console.log(carro['portas']);
console.log("---------------------------------------------------------------------------");

//funções são objetos de primeira clase
var soma = function(x,y){
    return x+y;
}
console.log(soma);

console.log(soma(20,123));