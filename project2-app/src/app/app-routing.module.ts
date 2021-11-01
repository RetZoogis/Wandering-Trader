import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InventoryComponent } from './components/inventory/inventory.component';
import { ProductsComponent } from './components/products/products.component';
import { OrderComponent } from './components/order/order.component';
import { DisplayproductComponent } from './components/displayproduct/displayproduct.component';
import { SidecheckoutComponent } from './components/sidecheckout/sidecheckout.component';

import { SearchbarComponent } from './components/searchbar/searchbar.component';
import { SignupComponent } from './components/signup/signup.component';

import { SigninComponent } from './components/signin/signin.component';



const routes : Routes = [

  {path:'searchbar', component: SearchbarComponent},
  {path:'inventory',component: InventoryComponent},
  {path:'order',component:OrderComponent},
  {path:'product',component:DisplayproductComponent},
  {path:'sidecheckout', component:SidecheckoutComponent},
  {path: 'inventory', component:InventoryComponent},
  
  {path: 'User/create/false', component:SignupComponent},
  {path: 'User/create/true', component:SigninComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
