import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DeleteComponent } from './components/delete/delete.component';
import { InsertComponent } from './components/insert/insert.component';
import { ListComponent } from './components/list/list.component';
import { UpdateComponent } from './components/update/update.component';


const routes: Routes = [
  {path:'', redirectTo:'list', pathMatch:'full'},
  {path:'list', component: ListComponent},
  {path:'insert', component: InsertComponent},
  {path:'update/:businessEntityID/:phoneNumberTypeID', component: UpdateComponent},
  {path:'delete/:businessEntityID/:phoneNumberTypeID', component: DeleteComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
