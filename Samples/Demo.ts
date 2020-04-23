console.log('Hello World!');

//---------------------------------------

const message = 'Hello World!'

const sayHello = (message) => {
    console.log(message);
};


sayHello(message);

//---------------------------------------

function Person(name: any) {
    this.name = name;
    this.sayHi = function () {
        setTimeout(() => {
            console.log('Hello my name is' + this.name);
        }, 1000)
    }
}

const person: any = new Person('Chetan');
person.sayHi();

//-----------------------------------------------------------------

function factorial(number: number) {
    if (number <= 0) {
        return 1;
    } else {
        return (number * factorial(number - 1));
    }
};
console.log(factorial(6));

//----------------------------------------------------------------------------------

import { buildPersonalData } from "./buildPersonData";

const partialAddress = ["Street Name", "Street Number", "Po Box"];
const firstname = 'Chetan',
    lastname = 'Patel';

const personData = {
    firstname,
    lastname
};

const address = [...partialAddress, 'Staples Center'];


debugger;

console.log(buildPersonalData(personData, address));

//----------------------------------------------------------------------------------

