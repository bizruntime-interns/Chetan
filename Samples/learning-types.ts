 let message:string='Hello World!';

 //-----------------------------------------

 type HasName={
     fristName?:string,
     lastName:string;
 }

 type HasAddress={
     streetName:string;
 }

 type Person={
     name: HasName,
     address?: HasAddress
 }

 let person:Person={
     name:{
         lastName:'Patel'
     }
 }

 //--------------------------------------------

 let fullName=['chetan','patel']
 
 let counters:number[]=[0,1,2]

 type PlayerTuple=[string,number]

 let tuple:PlayerTuple=['chetan',18]

 //--------------------------------------------

 enum PlayerPosition{
     Guard,
     Forward,
     Center
 }

 type player=[string,PlayerPosition];

 let chetan:player=['Chetan',PlayerPosition.Guard]

 let rahul:player=['Rahul',PlayerPosition.Center]

 let krishna:player=['Krishna',PlayerPosition.Forward]

 let players:player[]=[chetan,rahul,krishna]

 console.log(players)


 //-----------------------------------------------------------------

import * as _ from 'lodash';

 const colors=["Red","Blue","Green"];

 const firstColor=_.first(colors);

 console.log(firstColor);
