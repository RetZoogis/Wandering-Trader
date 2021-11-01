import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Router, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { SearchbarComponent } from './components/searchbar/searchbar.component';
import { ProductsComponent } from './components/products/products.component';
import { FooterComponent } from './components/footer/footer.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { GetComponent } from './components/inventory/get/get.component';
import { AddEditComponent } from './components/inventory/add-edit/add-edit.component';
import { OrderComponent } from './components/order/order.component';
import { SharedService } from './shared.service';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule,ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { GetorderComponent } from './components/order/getorder/getorder.component';
import { AddEditorderComponent } from './components/order/add-editorder/add-editorder.component';
import { DisplayproductComponent } from './components/displayproduct/displayproduct.component';
import { GetproductComponent } from './components/displayproduct/getproduct/getproduct.component';
import { NgbActiveModal, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SignupComponent } from './components/signup/signup.component';
import { SigninComponent } from './components/signin/signin.component';
import { CookieService } from 'ngx-cookie-service';
import { NgbModalModule } from '@ng-bootstrap/ng-bootstrap'
import { SidecheckoutComponent } from './components/sidecheckout/sidecheckout.component';




@NgModule({
  declarations: [
    AppComponent,
    SearchbarComponent,
    InventoryComponent,
    ProductsComponent,
    FooterComponent,
    GetComponent,
    AddEditComponent,
    OrderComponent,
    GetorderComponent,
    AddEditorderComponent,
    DisplayproductComponent,
    GetproductComponent,
    SignupComponent,
    SigninComponent,
    SidecheckoutComponent,

   

  ],


  imports: [ BrowserModule, AppRoutingModule, RouterModule,  HttpClientModule, FormsModule, ReactiveFormsModule, NgbModule, NgbModalModule ],
  providers: [SharedService, CookieService, NgbActiveModal],
  bootstrap: [AppComponent]
})
export class AppModule { }
