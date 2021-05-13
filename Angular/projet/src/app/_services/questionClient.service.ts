import { Injectable } from '@angular/core';

import {
  QuestionBase,
  TextboxQuestion
} from '../_models/index'

@Injectable()
export class QuestionClientService {

  // TODO: get from a remote source of question metadata
  // TODO: make asynchronous
  getQuestions() {

    const questions: QuestionBase<any>[] = [

      new TextboxQuestion({
        key: 'nom',
        label: 'nom',
        placeholder: 'Nom',
        required: true,
        order: 1
      }),

      new TextboxQuestion({
        key: 'prenom',
        label: 'prenom',
        placeholder: 'Prénom',
        required: true,
        order: 2
      }),

      new TextboxQuestion({
        key: 'mail',
        label: 'Email',
        type: 'email',
        placeholder: 'Mail',
        order: 3
      }),

      new TextboxQuestion({
        key: 'dateCreation',
        label: 'Date',
        type: 'date',
        order: 4
      })
    ];

    return questions.sort((a, b) => a.order - b.order);
  }
}