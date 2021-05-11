import { Component, Input, OnInit, VERSION } from '@angular/core';
import { QuestionClientService } from 'src/app/_services/questionClient.service';

@Component({
  selector: 'app-add-edit-client',
  templateUrl: './add-edit-client.component.html',
  styleUrls: ['./add-edit-client.component.scss']
})
export class AddEditClientComponent implements OnInit {

  @Input() client:any;
  questions: any[];
  version = VERSION.full;
  
  constructor(service: QuestionClientService) {
    this.questions = service.getQuestions();
  }

  ngOnInit(): void {
  }

}
