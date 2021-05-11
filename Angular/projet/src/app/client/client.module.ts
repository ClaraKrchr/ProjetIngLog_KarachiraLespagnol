import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { AppRoutingModule } from "../app-routing.module";
import { QuestionControlService } from "../_services";
import { QuestionClientService } from "../_services/questionClient.service";
import { AddEditClientComponent } from "./add-edit-client/add-edit-client.component";
import { ClientComponent } from "./client.component";
import { ShowClientComponent } from "./show-client/show-client.component";

@NgModule({
    declarations: [
        ClientComponent,
        ShowClientComponent,
        AddEditClientComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        NgbModule
    ],
    providers: [QuestionClientService, QuestionControlService],
})
export class ClientModule { }