import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-fact',
  templateUrl: './show-fact.component.html',
  styleUrls: ['./show-fact.component.scss']
})
export class ShowFactComponent implements OnInit {

  constructor(private service: SharedService) { }

  FacturesList: any = [];
  ModalTitle: string;
  ActivateAddEditFactComponent: boolean;
  facture: any;

  ngOnInit(): void {
    this.refreshFacturesList();
  }

  addClick() {
    this.facture = {
      Id: 0,
      Client: "",
      Date: "",
      Paiement: false,
      DatePaiement: "",
      Prix: 0,
    }
    this.ModalTitle = "Add facture";
    this.ActivateAddEditFactComponent = true;
  }

  closeClick() {
    this.ActivateAddEditFactComponent = false;
    this.refreshFacturesList();
  }

  deleteFacture(item){
    if(confirm('Êtes-vous sûr ?')){
      this.service.deleteFacture(item.id).subscribe(data=>{
        alert(data.toString());
        this.refreshFacturesList();
      })
    }
  }

  refreshFacturesList() {
    this.service.getAllFactures().subscribe(data => {
      this.FacturesList = data;
    });
  }

}
