var __spreadArrays = (this && this.__spreadArrays) || function () {
    for (var s = 0, i = 0, il = arguments.length; i < il; i++) s += arguments[i].length;
    for (var r = Array(s), k = 0, i = 0; i < il; i++)
        for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
            r[k] = a[j];
    return r;
};
console.log('Hello World!');
var message = 'Hello World!';
var sayHello = function (message) {
    console.log(message);
};
sayHello(message);
function Person(name) {
    this.name = name;
    this.sayHi = function () {
        var _this = this;
        setTimeout(function () {
            console.log('Hello my name is' + _this.name);
        }, 1000);
    };
}
var person = new Person('Chetan');
person.sayHi();
function factorial(number) {
    if (number <= 0) {
        return 1;
    }
    else {
        return (number * factorial(number - 1));
    }
}
;
console.log(factorial(6));
function buildPersonalData(_a) {
    var firstname = _a.firstname, lastname = _a.lastname;
    var address = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        address[_i - 1] = arguments[_i];
    }
    return firstname + " " + lastname + " " + address;
}
var partialAddress = ["Street Name", "Street Number", "Po Box"];
var firstname = 'Chetan', lastname = 'Patel';
var personData = {
    firstname: firstname,
    lastname: lastname
};
var address = __spreadArrays(partialAddress, ['Staples Center']);
console.log(buildPersonalData(personData, address));
