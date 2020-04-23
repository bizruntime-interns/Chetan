var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Editor;
(function (Editor) {
    Editor[Editor["MARVEL"] = 0] = "MARVEL";
    Editor[Editor["DC"] = 1] = "DC";
})(Editor || (Editor = {}));
var SuperHero = /** @class */ (function () {
    function SuperHero(name, editor, CreationYear) {
        this.editor = editor;
        this.CreationYear = CreationYear;
        this.name = name;
    }
    SuperHero.createMessage = function (hero) {
        return "\n            " + SuperHero.LABEL + "\n            " + hero.name + "\n            " + Editor[hero.editor] + "\n            " + hero.CreationYear + "\n        ";
    };
    SuperHero.LABEL = 'Hero:';
    return SuperHero;
}());
var FlyingHero = /** @class */ (function (_super) {
    __extends(FlyingHero, _super);
    function FlyingHero() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    FlyingHero.prototype.fly = function (message) {
        console.log(message + this.CreationYear);
    };
    //Method override
    FlyingHero.prototype.CreateMessage = function () {
        return "\n            flying hero:\n            " + this.name + "\n            " + Editor[this.editor] + "\n            " + this.CreationYear + "\n            ";
    };
    return FlyingHero;
}(SuperHero));
var greenLantern = new FlyingHero('silver Age Green  lantern', Editor.MARVEL, 1959);
console.log(greenLantern.CreateMessage());
var superman = new FlyingHero('Superman', Editor.DC, 1938);
//superman.fly('Up and Away');
//console.log(superman.CreateMessage());
//console.log("Superman", superman);
//superman.name="Superman";
//superman.editor=Editor.DC;
//superman.CreationYear=1938;
