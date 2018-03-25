//para criar uma variável se utiliza a palavra chave var
var x; //variável sem atribuição é undefined

x = 0; //atribuindo o valor zero a variável x

//JS aceita vários tipos de valores

x = 1; //mudando o valor de x;

x = 1.2; //number
console.log(typeof(x));//retorn number

x = "Hello World" //string  que é uma sequência de caracteres dentro de "" ou ''
console.log(typeof(x));//retorna string

x = true //valor booleano true ou false
console.log(typeof(x));//retorn boolean

x = null //valor nulor

console.log(typeof(x)); //retorna um objeto

x=undefined;

console.log(typeof(x)) //retorna undefined

x = {} //atribuindo um objeto com {}
//atribuição toda em apenas um objeto
x = {
    altura: 1.87,
    peso: 90
} //atribuindo propriedades ao objeto x
console.log(typeof(x));
console.log(x);
console.log(x.altura); //pegando o atributo do objeto

x.altura = 1.90; //mudando a propriedade altura
console.log(x);

var numeros = []; //criando um array vazio
console.log(numeros);

numeros = [1,2,3,4,5,6]; //atribuindo valores
console.log(numeros);

console.log(numeros[0]); //acessando o primeiro elemento pelo índice zero
//os indices vão de 0 até o tamanho do array-1

console.log(x["altura"]); //outra forma de acessar o atributo por notação de array


