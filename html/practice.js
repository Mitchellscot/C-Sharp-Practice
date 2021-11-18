/*jshint esversion: 6 */
console.log("Hello Mitchell");

let size = 16;

let result = '';
for(var i = 0; i < size; i++) {
//create odd line
    if (i % 2 != 0) {
        for (var j=0; j < size; j++) {
            if (j % 2 != 0) {
            result += ' ';
        }
            else if  (j % 2 === 0){
            result += '#';
        }
    }
        result += '\n'
    }
// create even line
    else if (i % 2 === 0) {
        for (var k = 0; k < size; k++) {
            if (k % 2 != 0) {
            result += '#';
        }
            else if  (k % 2 === 0){
            result += ' ';
        }
    }
        result += '\n'
    }
}
console.log(result);

// correct answer, although lengthy
/*
let result = '';
for(var index = 0; index < 8; index++) {
//create odd line
    if (index % 2 !== 0) {
for (var i=0; i < 8; i++) {
    if (i % 2 != 0) {
            result += ' ';
        }
    else if  (i % 2 === 0){
            result += '#';
        }
    }
result += '\n'
    }
    else if (index % 2 === 0) {
// create even line
for (var i = 0; i < 8; i++) {
    if (i % 2 != 0) {
            result += '#';
        }
    else if  (i % 2 === 0){
            result += ' ';
        }
    }
result += '\n'
    }
}
console.log(result);
*/

/*for(var i = 1; i < 101; i++) {
    if (i % 3 === 0 && i % 5 === 0) {
        console.log('FizzBuzz')
    }
    else if(i % 3 === 0){
        console.log('Fizz');
    }
    else if (i % 5 === 0) {
        console.log('Buzz');
    }
    else console.log(i);
}*/

/*
let s = '';
for(var i=0; s.length < 7; i++) {
    console.log(s += '!');
}*/