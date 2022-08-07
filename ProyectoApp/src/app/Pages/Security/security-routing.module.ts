import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'; 
import { MainSecurityComponent } from './main-security.component';
import { PermisionsComponent } from './permisions/permisions.component';
import { RolsComponent } from './rols/rols.component';
import { UsersComponent } from './users/users.component';


const routes: Routes = [

  {
    path: 'Securit', component: MainSecurityComponent,
    children: [
      { path: 'Permimsions', component: PermisionsComponent },
      { path: 'Rols', component: RolsComponent },
      { path: 'Users', component: UsersComponent },
    ]
  }
   
];


@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class SecurityRoutingModule { }
