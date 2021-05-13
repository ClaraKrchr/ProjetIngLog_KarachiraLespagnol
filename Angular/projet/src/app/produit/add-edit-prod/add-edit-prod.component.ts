import { Component, Input, OnInit, VERSION } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { QuestionProduitService } from 'src/app/_services/questionProduit.service';

@Component({
  selector: 'app-add-edit-prod',
  templateUrl: './add-edit-prod.component.html',
  styleUrls: ['./add-edit-prod.component.scss']
})
export class AddEditProdComponent implements OnInit {

  @Input() produit: any;
  questions: any[];
  version = VERSION.full;

  id: string;
  nom: string;
  stock: string;
  photo: string;
  prix: string;
  
  constructor(question: QuestionProduitService,
    private service: SharedService) {
    this.questions = question.getQuestions();
  }

  ngOnInit(): void {
    this.id = this.produit.id;
    this.nom = this.produit.nom;
    this.stock = this.produit.stock;
    this.photo = this.produit.photo;
    this.prix = this.produit.prix;
  }

  addProduit() {
    var val = {
      id: this.id,
      nom: this.nom,
      stock: this.stock,
      photo: this.photo,
      prix: this.prix
    };
    this.service.addProduit(val).subscribe(res => {
      alert(res.toString());
    });
  }

  updateProduit() {
    var val = {
      id: this.id,
      nom: this.nom,
      stock: this.stock,
      photo: this.photo,
      prix: this.prix
    };
    this.service.updateProduit(val).subscribe(res => {
      alert(res.toString());
    });
  }

}
