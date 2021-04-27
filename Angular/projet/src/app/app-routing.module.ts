import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {ClientComponent} from './client/client.component';
import {FactureComponent} from './facture/facture.component';
import {ProduitComponent} from './produit/produit.component';


const routes: Routes = [
{path:'client', component:ClientComponent},
{path:'facture', component:FactureComponent},
{path:'produit', component:ProduitComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
