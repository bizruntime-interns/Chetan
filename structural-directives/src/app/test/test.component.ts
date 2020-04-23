import { Component, OnInit, Input, Output,EventEmitter } from '@angular/core';


@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  @Input() public parentData;
  @Output() public childEvent = new EventEmitter(); 

  public color="orange";
  public colors=["red","orange","yellow","blue"];

  constructor() { }

  ngOnInit(): void {
  }

  fireEvent(){
    this.childEvent.emit('Hey Chetan patel');
  }

}
