//testando ternário
console.log(0 ? 'truthy':'falsy');
console.log(1 ? 'truthy' : 'falsy');

//ternário pode ser passado para uma variável.
var horario = 11;
var pessoa = {sexo:"Masculino"};
var idade = 14;

var juventude = idade>12 ? "Jovem" : "Rapaz";
console.log(juventude);

var sexo = pessoa.sexo === "Feminino" ? "a" : "o";
console.log(sexo);

var chegandoComEducacao = "Bom " + (horario>=12 ? "tarde" : "dia");
console.log(chegandoComEducacao);

//usando multiplos ternários
var verificador1 = false;
var verificador2 = 0;

var resposta = verificador1 ? "não passou" : verificador2 ? "não passou" : "passou";
console.log(resposta);

//fazendo uma operação com o operador ternário
var temAlguemMelhorQueOVinDiesel = false;
temAlguemMelhorQueOVinDiesel ? resposta = "Tem" : resposta = "Não tem";
console.log(resposta);

//fazendo mais de uma instrução com o operador ternário

temAlguemMelhorQueOVinDiesel ? (alert("Tem"), alert("Sim")) : (alert("Não"), alert("tem")); //tem que separar os valores por ,

//atribuindo valor fazendo mais de uma instrução

resposta = temAlguemMelhorQueOVinDiesel ? ("Não", alert("OI"), "Tem") : ("Tem", alert('tudo sussa?'), "Não tem"); //o ultimo valor dentro da () que é passado pra variável.
console.log(resposta);