function verifica(argumento){
    if(argumento) {
        return console.log(argumento + " é truthy");
    }
    else{
        return console.log(argumento + " é falsy");
    }
}
//valores falsy
verifica(0);
verifica(-0);
verifica('');
verifica("");
verifica(NaN);
verifica(null);
verifica(document.all);
verifica(undefined);
verifica(false);
//Valores truth que são infinitos pois são todos os outros
verifica(1);
verifica(-1);
verifica(2);
verifica(true);
verifica([]);
verifica([1]);
verifica("rapaaaz");
verifica("Show!");
verifica("Achou que ia ser falsy? Achou errado, otário!");
verifica(4.73);
verifica(42);
verifica({});

//usando "!" pra inverter uns valores insanos

console.log(!1);
console.log(!2);
console.log(!0);
console.log(!'');

//agora usando "!!" que faz a inversão da inversão que torna não invertido. Sacou qual é a da parada?
console.log(!!true);
console.log(!!false);
console.log(!!0);
console.log(!!1);