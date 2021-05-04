import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-edit-fact',
  templateUrl: './add-edit-fact.component.html',
  styleUrls: ['./add-edit-fact.component.scss']
})
export class AddEditFactComponent implements OnInit {

  constructor() { }

  @Input() facture: any;

  ngOnInit(): void {
  }

}
