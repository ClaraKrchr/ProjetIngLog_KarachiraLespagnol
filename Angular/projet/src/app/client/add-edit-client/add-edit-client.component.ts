import { Component, Input, OnInit, VERSION } from '@angular/core';
import { DynamicFormComponent } from 'src/app/dynamic-form/dynamic-form.component';
import { SharedService } from 'src/app/shared.service';
import { QuestionControlService } from 'src/app/_services';
import { QuestionClientService } from 'src/app/_services/questionClient.service';

@Component({
  selector: 'app-add-edit-client',
  templateUrl: './add-edit-client.component.html',
  styleUrls: ['./add-edit-client.component.scss']
})
export class AddEditClientComponent extends DynamicFormComponent implements OnInit{

  @Input() client: any;
  questions: any[];
  version = VERSION.full;

  id: string;
  nom: string;
  prenom: string;
  mail: string;
  date: Date;

  // fields = [];

  constructor(question: QuestionClientService,
    private service: SharedService,
    protected qcs: QuestionControlService) {
    super(qcs);
    this.questions = question.getQuestions();
  }

  ngOnInit() {
    this.id = this.client.id;
    this.nom = this.client.nom;
    this.prenom = this.client.prenom;
    this.mail = this.client.mail;
    this.date = this.client.dateCreation;
  }

  addClient() {
    var val = {
      id: this.id,
      nom: this.questions.values.name,
      prenom: this.questions.values.name,
      mail: this.mail,
      date: this.date
    };
    // val.nom = "coucou";
    val.nom = this.form.value("nom");
    this.service.addClient(val).subscribe(res => {
      alert(res.toString());
    });
  }

  updateClient() {
    var val = {
      id: this.id,
      nom: this.nom,
      prenom: this.prenom,
      mail: this.mail,
      date: this.date
    };
    this.service.updateClient(val).subscribe(res => {
      alert(res.toString());
    });
  }

}
