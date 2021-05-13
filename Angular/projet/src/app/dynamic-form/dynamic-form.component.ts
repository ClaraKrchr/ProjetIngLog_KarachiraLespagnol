import { Component, OnInit, Input } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { QuestionBase } from '../_models';
import { QuestionControlService } from '../_services';


@Component({
  selector: 'app-dynamic-form',
  templateUrl: './dynamic-form.component.html',
  styleUrls: ['./dynamic-form.component.scss']
})
export class DynamicFormComponent implements OnInit {

  @Input() questions: QuestionBase<any>[] = [];
  form: FormGroup;
  payLoad = '';

  fieldsData: string[];

  @Input() set fields(data: string[]) {
    this.setFormValues(data);
    this.fieldsData = data;
  }

  get fields() {
    return this.fieldsData;
  }

  constructor(private qcs: QuestionControlService) { }

  ngOnInit() {
    this.form = this.qcs.toFormGroup(this.questions);
  }

  onSubmit() {
    // this.payLoad = this.form.value;
    this.setFormValues(this.form.value);
  }

  public setFormValues(data: string[]){
    if (data) {
      this.form = new FormGroup({});
      data.forEach(item => {
        this.form.addControl(item, new FormControl());
      });
    }
    this.form.reset();
  }

}
