import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common'; 
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { SharedModule } from '../Shared/shared.module';
import { MainQuerysComponent } from './main-querys.component';



@NgModule({
  declarations: [
    MainQuerysComponent, 
  ],

  imports: [
    RouterModule,
    BrowserModule,
    CommonModule,
    SharedModule,
  ],

  exports: [
    
  ],
})
export class QueryModule { }
