import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Observable, of } from 'rxjs';
import { SharedService } from 'src/app/shared.service';
import { GetorderComponent } from './getorder.component';

describe('GetorderComponent', () => {
  let component: GetorderComponent;
  let fixture: ComponentFixture<GetorderComponent>;
  let fakeSvc = {
    ListOrders(): Observable<any[]> {
      return of([]);
    }
  }

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetorderComponent ],
      imports: [ CommonModule ],
      providers: [ {provide:HttpClient, useValue: { get: () => null }}, { provide: SharedService, useValue: fakeSvc } ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetorderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
