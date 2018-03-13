var x = 3;
var y = 7;

if(x === 3){
    y = 3;
}
console.log(y);

if(x === y && y === 3){
    x= 5;
    y = 2;
}
console.log("X " + x);
console.log("Y " + y);

if(x === 5 || y === 1){
    x = 1;
    y = 1;
}
console.log("X " + x);
console.log("Y " + y);
if( x===2){
    x = 5;
    y = 5;
}
console.log("X " + x);
console.log("Y " + y);

//else
if( x === 2){
    y = 2;
}else{
    y = 10;
}
console.log("X " + x);
console.log("Y " + y);

//else if
if(x === 2 ){
    y = 2;
}else if(y === 3){
    x = 3;
}else if(x === y){
    x = 10;
    y = 100;
}else{
    x = 0;
    y = 0;
}
console.log("X " + x);
console.log("Y " + y);