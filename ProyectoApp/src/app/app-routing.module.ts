import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'; 
import { AuthRoutingModule } from './Pages/Auth/auth-routing.module';
import { SecurityRoutingModule } from './Pages/Security/security-routing.module';

const routes: Routes = [
   
];


@NgModule({

  imports: [
    RouterModule.forRoot(routes),
    AuthRoutingModule,
    SecurityRoutingModule
  ],

  exports: [RouterModule]
})

export class AppRoutingModule { }
