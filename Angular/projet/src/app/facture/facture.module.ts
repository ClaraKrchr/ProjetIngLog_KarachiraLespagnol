import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { AppRoutingModule } from "../app-routing.module";
import { AddEditFactComponent } from "./add-edit-fact/add-edit-fact.component";
import { FactureComponent } from "./facture.component";
import { ShowFactComponent } from "./show-fact/show-fact.component";

@NgModule({
    declarations: [
        FactureComponent,
        ShowFactComponent,
        AddEditFactComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        NgbModule
    ]
})
export class FactureModule { }