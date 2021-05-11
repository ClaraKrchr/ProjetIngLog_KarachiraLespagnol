import { Component, Input, OnInit, VERSION } from '@angular/core';
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
  
  constructor(service: QuestionFactureService) {
    this.questions = service.getQuestions();
  }

  ngOnInit(): void {
  }

}
