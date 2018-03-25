var myvar = function(){
    return "variável myvar";
}
console.log(myvar);
console.log(myvar());

var pessoa = {nome:"Marcos",idade:20, altura:1.70, peso:65};
console.log(pessoa);

//pessoa = { sexo:"Masculino"}; não fazer isso pois apagaria tudo
//adicionando outras propriedades ao objeto
pessoa.cor = "pardo";
console.log(pessoa);
console.log(pessoa.cor);
//adc métodos
pessoa.andar = function(){
    return "Pessoa andando";
}
console.log(pessoa);
console.log(pessoa.andar);
console.log(pessoa.andar());

console.log(pessoa.idade);

pessoa.aniversario = function(){
    pessoa.idade++;
}
console.log(pessoa);
pessoa.aniversario();
console.log(pessoa);
pessoa.sobrenome = "Cezar";
pessoa.nomeCmpleto = function(){
    return pessoa.nome + ' ' + pessoa.sobrenome;
}
console.log(pessoa.nomeCmpleto());