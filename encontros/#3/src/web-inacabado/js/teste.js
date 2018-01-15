/*//tipos de dados
//string
var nome = "Marquinhos";
console.log(nome);
console.log(nome.length);
nome = nome.replace('quinhos','cos');
console.log(nome);

//number
//qualquer tipo de numero é number
var idade= 20;
var ano = '2017';
ano = parseInt(ano);

var altura = '1.70';
altura = parseFloat(altura);
altura = altura.toFixed(2);

//bolean
var verdadeiro = true;
var falso = false;

//concetenação
//string com string
var primeiroNome = 'Marcos';
var segundoNome = " Paulo";
var nome= primeiroNome+segundoNome;

//string com outro tipo
var n1 = 2;
var n2 = 3;

//exemplos
console.log(n1 + nome+n2);
//exemplo2
console.log(n1+n2+nome);
//#3
console.log(nome+n1+n2);
//#4
console.log(nome+(n1+n2));
//#5
console.log(nome+n1*n2);

//NaN - Not a number - para os leigos: Não és um número
console.log(10-'e');
// algo interessante
console.log(NaN == NaN);//?
console.log(isNaN(NaN));


//Exercícios da apostila
//#1
for (var i=1; i<=10; i++){
    if (i%2!=0){
        console.log(i)
    }
}
//#2
var soma= 0
for (var i=1; i<=100; i++){
    soma += i
}
console.log(soma);
//#3
var pessoas=["Marcos", "Jose","João","Sebastiao","Antonio"];
pessoas.forEach(nome => {
    if (nome.length ==4){
        console.log(nome)
    }
});
//Comparações
var n1 = 10;
var n2 = 10;
var n3 = "10";
console.log(n1==n2); //true
console.log(n1!=n2); //false
console.log(n1==n3);//true pq javascript é maluco e converte string pra number em teste de igualdade e comparações
console.log(n1===n3);//false pq ele tá comparando objetos agora;
console.log(n1!==n3);
*/
//condicionais
var idade = 16;
var nacionalidade = 'brasileiro';
var identidadeFalsa = false;

if (idade >= 16 && nacionalidade == 'brasileiro'){
    console.log('pode votar :(');
}else{
    console.log("não pode votar");
}
if (idade >=18 || identidadeFalsa == true){
    console.log('pode beber');
}else{
    console.log("não pode beber :'(");
}