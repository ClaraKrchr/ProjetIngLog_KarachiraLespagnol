import { Component, Input, OnInit, VERSION } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { QuestionFactureService } from 'src/app/_services/questionFacture.service';

@Component({
  selector: 'app-add-edit-fact',
  templateUrl: './add-edit-fact.component.html',
  styleUrls: ['./add-edit-fact.component.scss']
})
export class AddEditFactComponent implements OnInit {

  @Input() facture: any;
  questions: any[];
  version = VERSION.full;

  id: string;
  client: string;
  date: string;
  paiement: string;
  datePaiement: string;
  prix: string;

  constructor(question: QuestionFactureService,
    private service: SharedService) {
    this.questions = question.getQuestions();
  }

  ngOnInit(): void {
    this.id = this.facture.id;
    this.client = this.facture.client;
    this.date = this.facture.date;
    this.paiement = this.facture.paiement;
    this.datePaiement = this.facture.datePaiement;
    this.prix = this.facture.prix;
  }

  addFacture() {
    var val = {
      id: this.id,
      client: this.client,
      date: this.date,
      paiement: this.paiement,
      datePaiement: this.datePaiement,
      prix: this.prix
    };
    this.service.addFacture(val).subscribe(res => {
      alert(res.toString());
    });
  }

  updateFacture() {
    var val = {
      id: this.id,
      client: this.client,
      date: this.date,
      paiement: this.paiement,
      datePaiement: this.datePaiement,
      prix: this.prix
    };
    this.service.updateFacture(val).subscribe(res => {
      alert(res.toString());
    });
  }

}
