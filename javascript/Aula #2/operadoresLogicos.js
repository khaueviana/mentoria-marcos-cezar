var x = 3; 
var y = 7;

console.log(x===3);//true;
console.log(y===5);//false;
console.log(y==="7");//false
console.log(y===7); //true

//e = &&
console.log(x === 3 && y === 7); // Retorna true, pois x é igual a 3 e y é igual a 7
console.log(x === 3 && y === 4); //false

// ou = ||
console.log(x === 3 || y === 3); //retorna true

//not = !
console.log(!x === 3); //retorna false