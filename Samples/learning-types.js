var message = 'Hello World!';
var person = {
    name: {
        lastName: 'Patel'
    }
};
//--------------------------------------------
var fullName = ['chetan', 'patel'];
var counters = [0, 1, 2];
var tuple = ['chetan', 18];
//--------------------------------------------
var PlayerPosition;
(function (PlayerPosition) {
    PlayerPosition[PlayerPosition["Guard"] = 0] = "Guard";
    PlayerPosition[PlayerPosition["Forward"] = 1] = "Forward";
    PlayerPosition[PlayerPosition["Center"] = 2] = "Center";
})(PlayerPosition || (PlayerPosition = {}));
var chetan = ['Chetan', PlayerPosition.Guard];
var rahul = ['Rahul', PlayerPosition.Center];
var krishna = ['Krishna', PlayerPosition.Forward];
var players = [chetan, rahul, krishna];
console.log(players);
//-----------------------------------------------------------------
var _ = require('lodash');
var colors = ["Red", "Blue", "Green"];
var firstColor = _.first(colors);
console.log(firstColor);
