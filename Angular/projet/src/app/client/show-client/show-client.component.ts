import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-show-client',
  templateUrl: './show-client.component.html',
  styleUrls: ['./show-client.component.scss']
})
export class ShowClientComponent implements OnInit {

  constructor(private service:SharedService) { }

  ClientsList: any=[];

  ngOnInit(): void {
    this.refreshClientsList();
  }

  refreshClientsList(){
    this.service.getAllClients().subscribe(data=>{
      this.ClientsList=data;
    });
  }

}
