import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-fact',
  templateUrl: './show-fact.component.html',
  styleUrls: ['./show-fact.component.scss']
})
export class ShowFactComponent implements OnInit {

  constructor(private service:SharedService) { }

  FacturesList: any=[];

  ngOnInit(): void {
    this.refreshFacturesList();
  }

  refreshFacturesList(){
    this.service.getAllFactures().subscribe(data=>{
      this.FacturesList=data;
    });
  }

}
