var listaDeFrutas = ["Pêra", "Uva", "Maçã", "Banana"];

var Marcos = {
    nome: "Marcos",
    filmeFavorito: "Exterminador do futuro 2",
    idade: 20,
    comidasFavoritas: ["pizza","hamburguer"]
}

var retornaArrayEObjetos = function(arg){
    return arg;
};

var retornaOPrimeiroValor = function(arg){
    return arg[0];
};

var retornaNome = function(arg){
    return arg.nome;
};

var retornaIdade = function(arg){
    return arg["idade"];
}

var segundaComidaFavorita = function(arg){
    return arg.comidasFavoritas[1];
}
//testes

console.log(retornaArrayEObjetos(listaDeFrutas)); //retorna o conteúdo de listaDeFrutas
console.log(retornaArrayEObjetos(Marcos)); //retorna o objeto Marcos
console.log(retornaArrayEObjetos("ndasjdiosa"));//vemos que retorna qualquer tipo de argumento que for passado
console.log(retornaArrayEObjetos(function(){}));

console.log(retornaOPrimeiroValor(listaDeFrutas)); //retorna Pêra :)
console.log(retornaOPrimeiroValor(Marcos)); //retorna undefined pois não tem essa propriedade no objeto
console.log(retornaOPrimeiroValor(1)); //retorna undefined também
console.log(retornaOPrimeiroValor("uhaudhusda")); //retorna a primeira letra
console.log(retornaOPrimeiroValor(true)); //undefined
console.log(retornaOPrimeiroValor(function(){}))//undefined

console.log(retornaNome(Marcos)); //retorna meu nome
console.log(retornaNome(listaDeFrutas)); //retorna undefined pq não tem essa propriedade
console.log(retornaNome("iduashud")); //undefined
console.log(retornaNome(true)); //undefined
console.log(retornaNome(1)); //undefined
console.log(retornaNome({Rio:"De Janeiro"}));//undefined

console.log(retornaIdade(listaDeFrutas));//undefined
console.log(retornaIdade(Marcos)); //20
console.log(retornaIdade(true)); //undefined
console.log(retornaIdade(1)); //undefined
console.log(retornaIdade("dhsa")); //undefined
console.log(retornaIdade(function (){})); //undefined
console.log(retornaIdade({Rio:"De Janeiro"})) //undefined

console.log(segundaComidaFavorita(Marcos)); //hamburguer
