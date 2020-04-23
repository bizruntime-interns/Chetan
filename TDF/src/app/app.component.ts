import { Component } from '@angular/core';
import { EnrollmentService } from './enrollment.service'
import { User } from './user';
import { from } from 'rxjs';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  topics=['Angular','React','View'];
  topicHasError=true;
  submitted=false;

  userModel=new User('','chtenba@g.com',647,'default','morning',true);
  errorMsg: '';
  constructor(private _enrollmentService:EnrollmentService){}

  validateTopic(value){
    if(value==='default'){
      this.topicHasError=true;
    } else {
      this.topicHasError=false;
    }
  }

  onSubmit(){
    this.submitted=true;
    this._enrollmentService.enroll(this.userModel)
    .subscribe(
      data=>console.log('success!',data),
      error=>this.errorMsg=error.statusText
    )
  }

}
