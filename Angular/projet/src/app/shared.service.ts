import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  // readonly APIUrl="/rest/api"
  // readonly APIUrl="http://localhost:60026/api/"
  readonly APIUrl = "https://localhost:44376/api/"
  readonly APIPhoto="https://localhost:44376/Photos"

  constructor(private http:HttpClient) { }

  getAllClients():Observable<any[]>{
    return this.http.get<any>(this.APIUrl + 'Clients/all/Client');
  }

  addClient(val:any){
    return this.http.post(this.APIUrl+'Clients/CreateClient',val);
  }

  updateClient(val:any){
    return this.http.put(this.APIUrl+'Clients/{id}/UpdateClient',val);
  }

  deleteClient(val:any){
    return this.http.delete(this.APIUrl+'Clients/' + val + '/DeleteClient');
  }


  getAllFactures():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'Factures/all/Facture');
  }

  addFacture(val:any){
    return this.http.post(this.APIUrl+'Factures/CreateFacture',val);
  }

  updateFacture(val:any){
    return this.http.put(this.APIUrl+'Factures/{id}/UpdateFacture',val);
  }

  deleteFacture(val:any){
    return this.http.delete(this.APIUrl+'Factures/' + val + '/DeleteClient');
  }


  getAllProduits():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'Produits/all/Produit');
  }

  addProduit(val:any){
    return this.http.post(this.APIUrl+'Produits/CreateProduit',val);
  }

  updateProduit(val:any){
    return this.http.put(this.APIUrl+'Produits/{id}/UpdateProduit',val);
  }

  deleteProduit(val:any){
    return this.http.delete(this.APIUrl+'Produits/' + val + '/DeleteProduit');
  }

  UploadPhoto(val:any){
    return this.http.post(this.APIUrl+'Produit/SaveFile',val);
  }
}
