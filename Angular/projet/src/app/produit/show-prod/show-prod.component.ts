import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-prod',
  templateUrl: './show-prod.component.html',
  styleUrls: ['./show-prod.component.scss']
})
export class ShowProdComponent implements OnInit {

  constructor(private service:SharedService) { }

  ProduitsList: any=[];

  ngOnInit(): void {
    this.refreshProduitsList();
  }

  refreshProduitsList(){
    this.service.getAllProduits().subscribe(data=>{
      this.ProduitsList=data;
    });
  }

}
