import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { RouterModule } from '@angular/router';



@NgModule({

  declarations: [
    HeaderComponent,
    FooterComponent,
    NavbarComponent
  ],

  // Se debe exportar todos los componentes del modulo e importarl el SharedModule en app-module
  exports: [
    HeaderComponent,
    FooterComponent,
    NavbarComponent
  ],

  imports: [
    CommonModule,
    RouterModule
  ],


})
export class SharedModule { }
