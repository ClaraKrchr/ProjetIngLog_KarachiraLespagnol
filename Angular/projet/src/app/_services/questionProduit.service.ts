import { Injectable } from '@angular/core';

import {
  QuestionBase,
  TextboxQuestion
} from '../_models/index'

@Injectable()
export class QuestionProduitService {

  // TODO: get from a remote source of question metadata
  // TODO: make asynchronous
  getQuestions() {

    const questions: QuestionBase<any>[] = [

      new TextboxQuestion({
        key: 'nom',
        label: 'Nom',
        placeholder: 'Nom',
        required: true,
        order: 1
      }),

      new TextboxQuestion({
        key: 'stock',
        label: 'Stock',
        placeholder: 'Stock',
        type: 'number',
        required: true,
        order: 2
      }),

      new TextboxQuestion({
        key: 'photo',
        label: 'Photo',
        placeholder: 'Photo',
        order: 3
      }),

      new TextboxQuestion({
        key: 'prix',
        label: 'Prix',
        type: 'number',
        placeholder: 'Prix',
        order: 4
      })
    ];

    return questions.sort((a, b) => a.order - b.order);
  }
}