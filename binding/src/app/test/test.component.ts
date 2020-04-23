import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl:'./test.component.html',
  styleUrls:['./test.component.css'],
})
export class TestComponent implements OnInit {

  public name = 'PATEL';
  public myId = "testId";
  public SuccessClass = "text-success";
  public hasError = true;
  public isSpecial = true;
  public titleStyle={
    color:"blue",
    fontStyle:"italic"
  }
  public messageClasses = {
    "text-success": !this.hasError,
    "text-danger": this.hasError,
    "text-special": this.isSpecial
  }

  public Name="";

  public greeting="";
  public siteUrl=window.location.href;

  constructor() { }

  ngOnInit(): void {
  }

  greetUser() {
    return "Hello" + this.name;
  }

  onClick(event){
    console.log(event);
    this.greeting="welcome";
  }

  logMessage(value){
    console.log(value)
  }

}
