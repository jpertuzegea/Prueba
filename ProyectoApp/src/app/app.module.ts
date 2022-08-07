import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component'; 
import { SecurityModule } from './Pages/Security/security.module'; 
import { SharedModule } from './Pages/Shared/shared.module'; 
import { AuthModule } from './Pages/Auth/auth.module';

@NgModule({
   
  declarations: [
    AppComponent, 
  ],
   
  imports: [
    BrowserModule,
    AppRoutingModule,    
    SecurityModule,
    AuthModule,   
    SharedModule 
  ],

  providers: [],

  bootstrap: [AppComponent]
})

export class AppModule { }
