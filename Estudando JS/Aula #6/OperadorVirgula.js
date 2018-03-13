//declarando variáveis em apenas uma linha cada
var a = 5;
console.log(a);
var b = "Oi"; 
console.log(b);

var c, d = 3, e; //realizando várias atribuições em apenas uma expressão
console.log(c); //retorna undefined, pois a variável foi criada sem nada
console.log(d); //retorna 3 que era o conteúdo da var
console.log(e); //retorna undefined

function teste (){
    x = 0;
    return (x++, x); //primeiro é realizada a expressão que incrementa a variável e depois como só pode haver um retorno e o retorno é sempre a ultima expressão o resultado é x
}
console.log(teste());//retorna 1

function teste1 (){
    var x = 1;
    var y = 2;
    var z = 3;
    return x,y,z; //retorna sempre a última expressão
}

console.log(teste1()); //retorna  3

function teste2(){
    var x = 1,y = 2,z = 3;
    return x;
}
console.log(teste2()); //retorna 1
/*console.log(y); 
    retorna um erro, pois a variável y não está definida fora do escopo da função
    isso se dá ao fato da palavra var em:
    var x = 1,y = 2,z = 3;
    ser compartilhada por todas as expressões se tornando o mesmo que:
    var x = 1;
    var y = 2;
    var z = 3;
*/

for (var i=0,j=10; i<=5; i++,j--){
    console.log(j-i);
}

