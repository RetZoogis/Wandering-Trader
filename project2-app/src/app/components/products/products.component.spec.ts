import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ProductsComponent } from './products.component';
import { Observable, of } from 'rxjs';
import { SharedService } from 'src/app/shared.service';

describe('ProductsComponent', () => {
  let component: ProductsComponent;
  let fixture: ComponentFixture<ProductsComponent>;

  beforeEach(async () => {
    let fakeSvc = {
      ListInventory(): Observable<any[]> {
        return of([]);
      }
    }

    await TestBed.configureTestingModule({
      declarations: [ ProductsComponent ],
      providers: [
        { provide: SharedService, useValue: fakeSvc }
      ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
