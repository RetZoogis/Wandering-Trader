import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditorderComponent } from './add-editorder.component';

describe('AddEditorderComponent', () => {
  let component: AddEditorderComponent;
  let fixture: ComponentFixture<AddEditorderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditorderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditorderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
