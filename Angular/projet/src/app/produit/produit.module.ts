import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { AppRoutingModule } from "../app-routing.module";
import { QuestionControlService } from "../_services";
import { QuestionProduitService } from "../_services/questionProduit.service";
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
    ],
    providers: [QuestionProduitService, QuestionControlService],
})
export class ProduitModule { }