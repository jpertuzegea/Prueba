import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PermisionsComponent } from './permisions/permisions.component';
import { UsersComponent } from './users/users.component';
import { RolsComponent } from './rols/rols.component'; 
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { SharedModule } from '../Shared/shared.module';
import { MainSecurityComponent } from './main-security.component'; 



@NgModule({

  declarations: [
    MainSecurityComponent,
    PermisionsComponent,
    UsersComponent,
    RolsComponent, 
  ],

  imports: [
    RouterModule,
    BrowserModule,
    CommonModule,
    SharedModule, 
  ],

  exports: [
    PermisionsComponent,
    UsersComponent,
    RolsComponent, 
  ],

})
export class SecurityModule { }
