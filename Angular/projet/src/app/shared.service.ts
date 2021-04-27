import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl="https://localhost:44376/api"
  readonly APIPhoto="https://localhost:44376/Photos"

  constructor(private http:HttpClient) { }

  // getClientList():Observable<any[]>{
  //   return this.http.get<any>(this.APIUrl+'/department');
  // }

  addClient(val:any){
    return this.http.post(this.APIUrl+'/CreateClient',val);
  }

  updateClient(val:any){
    return this.http.put(this.APIUrl+'/Clients/{id}/UpdateClient',val);
  }

  deleteClient(val:any){
    return this.http.delete(this.APIUrl+'/Clients/{id}/DeleteClient'+val);
  }


  // getEmpList():Observable<any[]>{
  //   return this.http.get<any>(this.APIUrl+'/Employee');
  // }

  addFacture(val:any){
    return this.http.post(this.APIUrl+'/CreateFacture',val);
  }

  updateFacture(val:any){
    return this.http.put(this.APIUrl+'/Factures/{id}/UpdateFacture',val);
  }

  deleteFacture(val:any){
    return this.http.delete(this.APIUrl+'/Factures/{id}/DeleteClient'+val);
  }


  // getEmpList():Observable<any[]>{
  //   return this.http.get<any>(this.APIUrl+'/Employee');
  // }

  addProduit(val:any){
    return this.http.post(this.APIUrl+'/CreateProduit',val);
  }

  updateProduit(val:any){
    return this.http.put(this.APIUrl+'/Produits/{id}/UpdateProduit',val);
  }

  deleteProduit(val:any){
    return this.http.delete(this.APIUrl+'/Produits/{id}/DeleteProduit'+val);
  }

  UploadPhoto(val:any){
    return this.http.post(this.APIUrl+'/Produit/SaveFile',val);
  }
}
