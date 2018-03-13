function teste(num){
    switch(num){
        case 1:
            console.log("Esse é o número um");
            break;
        case 2:
            console.log("Esse é o número dois");
            break;
        case 3:
            console.log("Esse é o número três");
            break;
        default:
            console.log("Eu não esperava esse número");
    }
}

teste(1); //"Esse é o número um"
teste(2); //"Esse é o número dois" 
teste(3); //"Esse é o número três"
teste(4); //"Eu não esperava esse número"

console.log('');

function teste2(num){
    switch (num) {
        case 1:
            console.log("Esse é o número um"); //ele entra aqui porém não tem a palavra chave break
        case 2:
            console.log("Esse é o número dois"); //Mesmo o número não sendo o dois, ele entra aqui
            break; //Ele iria entrar no seguinte case, porém aqui há a palavra break
        case 3:
            console.log("Esse é o número três");
            break;
        default:
            console.log("Eu não esperava esse número");
    }
}
teste2(1); //"Esse é o número um Esse é o número dois"

function teste3(num){
    switch (num) {
        case 1:
            console.log("Esse é o número um"); //ele entra aqui porém não tem a palavra chave break
        case 2:
            console.log("Esse é o número dois"); //Mesmo o número não sendo o dois, ele entra aqui
        case 3:
            console.log("Esse é o número três"); //mesmo ele não sendo o 3, ele entra aqui
        default:
            console.log("Eu não esperava esse número"); //só para aqui pq era o último
    }
}
teste3(1); /*
Esse é o número um
Esse é o número dois
Esse é o número três
Eu não esperava esse número*/

console.log("");

function teste4(num){
    switch (num) {
        case 1:
            console.log("Esse é o número um");
            break;
        default: //vemos que o default pode estar em qualquer posição dentro do switch
            console.log("Eu não esperava esse número");
        case 2:
            console.log("Esse é o número dois"); 
            break;
        case 3:
            console.log("Esse é o número três");       
    }
}
teste4(1); //"Esse é o número um"
teste4(4); //"Eu não esperada esse número"
teste4(2); //"Esse é o número dois" 
teste4(3); //"Esse é o número três"
console.log('');

function teste5(fruta){
    switch (fruta) {
        case "Banana": //Os tipos que são comparados podem ser todos além do tipo number
        case "Laranja":
            console.log("Eu adoro Banana ou Laranja"); //Vemos que podemos ter o resultado igual pra mais de uma case
            break;
        case "Abacaxi":
        case "Limão":
            console.log("Acho limão e abacaxi muito azedos");
            break;
        default:
            console.log("Queria comer goiaba, mas será que lá dentro tem o bicho da goiaba");
    }
}

teste5("Banana");
teste5("Abacaxi");
teste5("Laranja");
teste5("Tomate");