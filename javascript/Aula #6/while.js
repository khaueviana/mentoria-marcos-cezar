/*
x = true;
como x tem o valor true, o código do bloco sempre é lido
while(x){
    alert("Oi, tudo bem");
}
logo esse código nunca é lido:
alert("Não");
*/

/*
x = 2;
como x é um truthy, ele é convertido pra true pois a condição do while é um contexto booleano
while(x){
    alert("oi");
}*/

while(0){
    console.log("Infelizmente eu nunca sou lido");
}
x = 1
while(x<=10){
    console.log(x);
    x++;
}
console.log("");
y = 0;
z = 10;
while(y<=5 && z>=5){
    console.log(z-y);
    y++;
    z--;
}