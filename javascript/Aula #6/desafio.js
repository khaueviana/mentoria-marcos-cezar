/*
Vamos falar um pouco sobre "Futebol". Escolha um campeonato estadual qualquer
para começar o desafio.
Declare uma variável chamada `championship` que receberá o nome do campeonato,
e imprima o nome desse campeonato no console.
*/
var championship = 'Campeonato Carioca';
console.log(championship);

/*
Declare uma variável chamada `teams`, que receberá um array com 5 elementos.
Os elementos serão nomes de times do campeonato escolhido, e os nomes devem
estar na ordem em que eles aparecem na tabela no momento da solução desse
desafio.
*/
var teams = ['Vasco', 'Flamengo' , 'Cabofriense', 'Bangu', 'Volta Redonda'];

console.log( 'Times que estão participando do campeonato:', teams );

/*
Crie uma função chamada `showTeamPosition` com as seguintes características:
    - A função deve receber um número por parâmetro;
    - A função deve retornar a frase:
    "O time que está em [POSIÇÃO]º lugar é o [NOME DO TIME].";
    - Onde [POSIÇÃO] é o valor passado por parâmetro e [NOME DO TIME] é o time
    que está nessa posição no array criado acima com os nomes dos times.
    --------------
    Dica: lembre-se que arrays começam no índice zero, então a posição passada
    deve ser sempre um número a mais que o índice do array ;)
    --------------
    - A função só deve retornar a frase acima somente se o time estiver entre
    os 5 primeiros.
    - Se não houver time para a posição passada, deve retornar a mensagem:
    "Não temos a informação do time que está nessa posição."
*/
function showTeamPosition(posicao){
    if(posicao < 1 || posicao > 5){
        return 'Não temos a informação do time que está nessa posição';
    }
    
    return "O time que está em " + posicao + "º lugar é o " + teams[--posicao] + ".";
}
/*
Escolha 4 times do campeonato selecionado e mostre a posição dele, usando a
função acima. Entre esses 4, adicione 1 que não esteja entre os 5 primeiros.
*/
console.log(showTeamPosition(1)); //O time que está em 1º lugar é o Vasco.
console.log(showTeamPosition(2)); //O time que está em 2º lugar é o Flamengo.
console.log(showTeamPosition(5)); //O time que está em 5º lugar é o Volta Redonda.
console.log(showTeamPosition(4)); //O time que está em 4º lugar é o Bangu.
console.log(showTeamPosition(6)); //Não temos a informação do time que está nessa posição


/*
Mostre os números de 20 a 30 no console (inclusive o 30), usando a estrutura de
repetição "while".
*/
x = 20;
while (x<=30){
    console.log(x);
    x++;
}

/*
Crie uma função chamada `convertToHex`, com as seguintes características:
    - A função recebe uma cor por parâmetro, do tipo string. Exemplo: "red";
    - Escolha 5 cores que serão convertidas do nome da cor para o seu
    equivalente hexadecimal (pode ser qualquer tom);
    - Usando a estrutura switch, verifique se a cor passada por parâmetro é
    algum hexa escolhido. Se for, retorne a frase:
    "O hexadecimal para a cor [COR] é [HEXADECIMAL].";
    - Se a cor passada por parâmetro não estiver entre as selecionadas, mostre
    a frase:
    "Não temos o equivalente hexadecimal para [COR]."
*/
function convetToHex(cor){
    cores = {
        "azul": "#0000FF",
        "vermelho": "#FF0000",
        "amarelo": "#FFFF00",
        "preto": "#000000",
        "branco": "#FFFFFF"
    }
    switch(cor){
        case "azul":
        case "vermelho":
        case "amarelo":
        case "preto":
        case "branco":
            return "O hexadecimal para a cor " + cor + " é " + cores[cor] + ".";
        default:
            return "Não temos o equivalente hexadecimal para " + cor + ".";
    }
}
/*
Tente mostrar o hexadecimal de 8 cores diferentes usando a função criada acima.
*/
console.log(convetToHex('branco')); //O hexadecimal para a cor branco é #FFFFFF.
console.log(convetToHex('verde')); // Não temos o equivalente hexadecimal para verde.
console.log(convetToHex('vermelho')); // O hexadecimal para a cor vermelho é #FF0000.
console.log(convetToHex('rosa')); // Não temos o equivalente hexadecimal para rosa.
console.log(convetToHex('azul')); // O hexadecimal para a cor azul é #0000FF.
console.log(convetToHex('amarelo')); // O hexadecimal para a cor amarelo é #FFFF00.
console.log(convetToHex('preto')); // O hexadecimal para a cor preto é #000000.
console.log(convetToHex("roxo")); // Não temos o equivalente hexadecimal para roxo.