import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { AppRoutingModule } from "../app-routing.module";
import { AddEditProdComponent } from "./add-edit-prod/add-edit-prod.component";
import { ProduitComponent } from "./produit.component";
import { ShowProdComponent } from "./show-prod/show-prod.component";

@NgModule({
    declarations: [
        ProduitComponent,
        ShowProdComponent,
        AddEditProdComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        NgbModule
    ]
})
export class ProduitModule { }