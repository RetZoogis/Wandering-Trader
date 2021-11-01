import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClient } from '@angular/common/http';
import { SidecheckoutComponent } from './sidecheckout.component';
import { SharedService } from 'src/app/shared.service';
import { Observable, of } from 'rxjs';


describe('SidecheckoutComponent', () => {
  let component: SidecheckoutComponent;
  let fixture: ComponentFixture<SidecheckoutComponent>;

  beforeEach(async () => {
    let fakeSvc = {
      ListInventory(): Observable<any[]> {
        return of([]);
      }
    }
    
    await TestBed.configureTestingModule({
      declarations: [ SidecheckoutComponent ],
      providers: [ {provide:HttpClient, useValue: { get: () => null }}, { provide: SharedService, useValue: fakeSvc } ]
      
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SidecheckoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
