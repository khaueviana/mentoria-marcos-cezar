function myFunction(){
    return 1;
}
console.log(myFunction());

function myFunction1(){
    return "string";
}

console.log(myFunction1());

function myFunction2(){
    return true;
}

console.log(myFunction2());

function myFunction3(){
    return null;
}

console.log(myFunction3());

function myFunction4(){}
console.log(myFunction4());

function myFunction5(){
    return [1,2,3];
}

console.log(myFunction5());

function myFunction6(){
    return 1,2
}
console.log(myFunction6()); //retorna só o número 2
console.log(myFunction5()[0]);//retorna o primeiro item do array de retorno
console.log(myFunction5()[2]);
console.log(myFunction5()[6]);//retorna undefined pq o item não existe

function retornaObjeto (){
    return {
        prop:1,
        prop2:"Marcos",
        prop3: function(){
            return 'prop3';
        }
    }
}
console.log(retornaObjeto().prop3());

var values = retornaObjeto();
console.log(values);
console.log(values.prop2);
console.log(values.prop);

