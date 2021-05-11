import { Injectable } from '@angular/core';

import {
    DropdownQuestion,
    QuestionBase,
    TextboxQuestion
} from '../_models/index'

@Injectable()
export class QuestionFactureService {

    // TODO: get from a remote source of question metadata
    // TODO: make asynchronous
    getQuestions() {

        const questions: QuestionBase<any>[] = [

            new DropdownQuestion({
                key: 'clientId',
                label: 'Client',
                options: [
                    { key: '1', value: 'Client1' },
                    { key: '2', value: 'Client2' },
                    { key: '3', value: 'Client3' },
                    { key: '4', value: 'Client4' }
                ],
                placeholder: 'Choisir un client',
                order: 1
            }),

            new TextboxQuestion({
                key: 'date',
                label: 'Date',
                type: 'date',
                order: 2
            }),

            new TextboxQuestion({
                key: 'paiement',
                label: 'Paiement',
                placeholder: 'Paiement',
                type: 'boolean',
                required: true,
                order: 3
            }),

            new TextboxQuestion({
                key: 'datePaiement',
                label: 'Date Paiement',
                type: 'date',
                order: 4
            }),

            new TextboxQuestion({
                key: 'prix',
                label: 'Prix',
                type: 'number',
                placeholder: 'Prix',
                order: 5
            }),

            new DropdownQuestion({
                key: 'produits',
                label: 'Produits',
                options: [
                    { key: '1', value: 'Produit1' },
                    { key: '2', value: 'Produit2' },
                    { key: '3', value: 'Produit3' },
                    { key: '4', value: 'Produit4' }
                ],
                placeholder: 'Choisir un ou des produits',
                multiple: true,
                order: 6
            })
        ];

        return questions.sort((a, b) => a.order - b.order);
    }
}