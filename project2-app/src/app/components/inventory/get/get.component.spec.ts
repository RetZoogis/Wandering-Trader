import { ComponentFixture, TestBed } from '@angular/core/testing';
import { GetComponent } from './get.component';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { SharedService } from 'src/app/shared.service';

describe('GetComponent', () => {
  let component: GetComponent;
  let fixture: ComponentFixture<GetComponent>;
  let fakeSvc = {
    ListInventory(): Observable<any[]> {
      return of([]);
    }
  }

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ CommonModule ],
      declarations: [ GetComponent ],
      providers: [ {provide: HttpClient, useValue: { get: () => null }}, { provide: SharedService, useValue: fakeSvc } ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
