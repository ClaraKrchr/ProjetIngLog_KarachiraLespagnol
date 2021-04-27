import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditFactComponent } from './add-edit-fact.component';

describe('AddEditFactComponent', () => {
  let component: AddEditFactComponent;
  let fixture: ComponentFixture<AddEditFactComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddEditFactComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditFactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
