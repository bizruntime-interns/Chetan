import { Component } from '@angular/core';
import { FormBuilder,Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private fb:FormBuilder){}

  registractionForm=this.fb.group({
    userName:['',[Validators.required,Validators.minLength(3)]],
    password:[''],
    confirmPassword:[''],
    address:this.fb.group({
      city:[''],
      state:[''],
      postalCode:['']
    })
  })
  // registractionForm=new FormGroup({
  //   userName: new FormControl('Chetan'),
  //   password: new FormControl(''),
  //   confirmPassword: new FormControl(''),
  //   address:new FormGroup({
  //     city:new FormControl(''),
  //     state:new FormControl(''),
  //     postalCode:new FormControl('')
  //   })
  // });



  LoadApiData(){
    // patchvalue can be used in place of setvalue
    this.registractionForm.setValue({
      userName: 'Chetan',
      password: 'PPP',
      confirmPassword: 'PPP',
      address:{
        city:'Raichur',
        state:'Karnataka',
        postalCode:'584102'
      }
    });
  }
}
