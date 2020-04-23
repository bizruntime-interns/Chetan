enum Editor {
    MARVEL,
    DC
}

interface Hero{
    name:string;
    CreationYear:number;
}

abstract class SuperHero implements Hero {

    static LABEL='Hero:';

    readonly name:string;

    constructor(
        name: string,
        public editor: Editor,
        public CreationYear: number) {
            this.name=name;

    }


    static createMessage(hero:SuperHero):string{
        return `
            ${SuperHero.LABEL}
            ${hero.name}
            ${Editor[hero.editor]}
            ${hero.CreationYear}
        `;
    }

    // /*private*/ CreateMessage(){
    //     return `
    //         Super hero:
    //         ${this.name}
    //         ${Editor[this.editor]}
    //         ${this.CreationYear}
    //         `;
    // }

}

interface CanFly{
    fly(message:string):void;
}


class FlyingHero extends SuperHero implements CanFly{
    fly(message: string){
        console.log(message+ this.CreationYear);
    }
    
    //Method override

    CreateMessage(){
        return `
            flying hero:
            ${this.name}
            ${Editor[this.editor]}
            ${this.CreationYear}
            `;
    }
}

const greenLantern= new FlyingHero('silver Age Green  lantern',Editor.MARVEL,1959);

console.log(greenLantern.CreateMessage());

const superman = new FlyingHero('Superman', Editor.DC, 1938);



//superman.fly('Up and Away');

//console.log(superman.CreateMessage());

//console.log("Superman", superman);

 //superman.name="Superman";
 //superman.editor=Editor.DC;
 //superman.CreationYear=1938;
