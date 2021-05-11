import { Component, Input, OnInit, VERSION } from '@angular/core';
import { QuestionProduitService } from 'src/app/_services/questionProduit.service';

@Component({
  selector: 'app-add-edit-prod',
  templateUrl: './add-edit-prod.component.html',
  styleUrls: ['./add-edit-prod.component.scss']
})
export class AddEditProdComponent implements OnInit {

  @Input() produit: any;
  questions: any[];
  version = VERSION.full;
  
  constructor(service: QuestionProduitService) {
    this.questions = service.getQuestions();
  }

  ngOnInit(): void {
  }

}
