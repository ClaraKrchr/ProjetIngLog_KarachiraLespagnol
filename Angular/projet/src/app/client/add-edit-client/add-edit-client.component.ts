import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-edit-client',
  templateUrl: './add-edit-client.component.html',
  styleUrls: ['./add-edit-client.component.scss']
})
export class AddEditClientComponent implements OnInit {

  constructor() { }

  @Input() client:any;

  ngOnInit(): void {
  }

}
