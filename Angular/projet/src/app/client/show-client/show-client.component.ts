import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-client',
  templateUrl: './show-client.component.html',
  styleUrls: ['./show-client.component.scss']
})
export class ShowClientComponent implements OnInit {

  constructor(private service:SharedService) { }

  ClientsList: any=[];
  ModalTitle: string;
  ActivateAddEditClientComponent: boolean;
  client: any;

  ngOnInit(): void {
    this.refreshClientsList();
  }

  addClick(){
    this.client={
      Id:0,
      Nom:"",
      Prenom:"",
      Mail:"",
      DateCreation:"",
    }
    this.ModalTitle="Add client";
    this.ActivateAddEditClientComponent=true;
  }

  closeClick(){
    this.ActivateAddEditClientComponent=false;
    this.refreshClientsList();
  }

  refreshClientsList(){
    this.service.getAllClients().subscribe(data=>{
      this.ClientsList=data;
    });
  }

}
