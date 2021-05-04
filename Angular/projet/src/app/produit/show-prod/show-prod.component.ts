import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-prod',
  templateUrl: './show-prod.component.html',
  styleUrls: ['./show-prod.component.scss']
})
export class ShowProdComponent implements OnInit {

  constructor(private service: SharedService) { }

  ProduitsList: any = [];
  ModalTitle: string;
  ActivateAddEditProdComponent: boolean;
  produit: any;

  ngOnInit(): void {
    this.refreshProduitsList();
  }

  addClick() {
    this.produit = {
      Id: 0,
      Nom: "",
      Stock: 0,
      Photo: "",
      Prix: 0,
    }
    this.ModalTitle = "Add produit";
    this.ActivateAddEditProdComponent = true;
  }

  closeClick() {
    this.ActivateAddEditProdComponent = false;
    this.refreshProduitsList();
  }

  refreshProduitsList() {
    this.service.getAllProduits().subscribe(data => {
      this.ProduitsList = data;
    });
  }

}
