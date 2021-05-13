import { Component, Input, OnInit, VERSION } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { QuestionClientService } from 'src/app/_services/questionClient.service';

@Component({
  selector: 'app-add-edit-client',
  templateUrl: './add-edit-client.component.html',
  styleUrls: ['./add-edit-client.component.scss']
})
export class AddEditClientComponent implements OnInit {

  @Input() client: any;
  questions: any[];
  version = VERSION.full;

  id: string;
  nom: string;
  prenom: string;
  mail: string;
  date: string;

  constructor(question: QuestionClientService,
    private service: SharedService) {
    this.questions = question.getQuestions();
  }

  ngOnInit(): void {
    this.id = this.client.id;
    this.nom = this.client.nom;
    this.prenom = this.client.prenom;
    this.mail = this.client.mail;
    this.date = this.client.date;
  }

  addClient() {
    var val = {
      id: this.id,
      nom: this.nom,
      prenom: this.prenom,
      mail: this.mail,
      date: this.date
    };
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
