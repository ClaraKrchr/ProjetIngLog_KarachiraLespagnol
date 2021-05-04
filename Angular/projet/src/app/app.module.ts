import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientComponent } from './client/client.component';
import { FactureComponent } from './facture/facture.component';
import { ProduitComponent } from './produit/produit.component';
import { ShowClientComponent } from './client/show-client/show-client.component';
import { AddEditClientComponent } from './client/add-edit-client/add-edit-client.component';
import { ShowProdComponent } from './produit/show-prod/show-prod.component';
import { AddEditProdComponent } from './produit/add-edit-prod/add-edit-prod.component';
import { ShowFactComponent } from './facture/show-fact/show-fact.component';
import { AddEditFactComponent } from './facture/add-edit-fact/add-edit-fact.component';
import { SharedService } from './shared.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
// import { DynamicFormComponent } from './dynamic-form/dynamic-form.component';
// import { DynamicFormQuestionComponent } from './dynamic-form-question/dynamic-form-question.component';

@NgModule({
  declarations: [
    AppComponent,
    ClientComponent,
    FactureComponent,
    ProduitComponent,
    ShowClientComponent,
    AddEditClientComponent,
    ShowProdComponent,
    AddEditProdComponent,
    ShowFactComponent,
    AddEditFactComponent
    // DynamicFormComponent,
    // DynamicFormQuestionComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
