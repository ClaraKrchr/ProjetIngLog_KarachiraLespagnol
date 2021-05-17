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
      id:0,
      // nom:"clara",
      // prenom:"",
      // mail:"",
      // dateCreation:"",
    }
    this.ModalTitle="Ajouter client";
    this.ActivateAddEditClientComponent=true;
  }

  editClick(item){
    this.client=item;
    this.ModalTitle="Edit Client";
    this.ActivateAddEditClientComponent=true;
  }

  closeClick(){
    this.ActivateAddEditClientComponent=false;
    this.refreshClientsList();
  }

  deleteClient(item){
    if(confirm('Êtes-vous sûr ?')){
      this.service.deleteClient(item.id).subscribe(data=>{
        alert(data.toString());
        this.refreshClientsList();
      })
    }
  }

  refreshClientsList(){
    this.service.getAllClients().subscribe(data=>{
      this.ClientsList=data;
    });
  }

}
