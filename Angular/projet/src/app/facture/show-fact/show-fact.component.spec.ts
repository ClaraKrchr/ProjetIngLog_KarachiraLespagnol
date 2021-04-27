import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowFactComponent } from './show-fact.component';

describe('ShowFactComponent', () => {
  let component: ShowFactComponent;
  let fixture: ComponentFixture<ShowFactComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowFactComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowFactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
