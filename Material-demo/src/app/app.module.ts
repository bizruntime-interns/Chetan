import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule} from './material/material.module';
import { FormsModule,ReactiveFormsModule  } from '@angular/forms';
import { DialogExampleComponent } from './dialog-example/dialog-example.component';
import { ScrollingModule } from '@angular/cdk/scrolling'

@NgModule({
  declarations: [
    AppComponent,
    DialogExampleComponent
  ],
  entryComponents:[DialogExampleComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
    ScrollingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
