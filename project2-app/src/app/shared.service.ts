import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from './components/interfaces/category';
import { User } from './components/interfaces/user';
import { LogInRequest } from './user/user.service';
import { Product } from './components/interfaces/product';
import { Order } from './components/interfaces/order';
import { UserService } from './user/user.service';



@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl="https://localhost:44357/api";

  constructor(private https:HttpClient) { }

  ListInventory():Observable<any[]>{
    return this.https.get<any>(this.APIUrl+'/inventory');
  }

  ListUser():Observable<any[]>{
    return this.https.get<any>(this.APIUrl+'/User');
  }

  LoginUser(logInRequest : LogInRequest):Observable<User>{
    return this.https.post<User>(this.APIUrl+'/User/false', logInRequest);
  }



  ListCategory():Observable<Category[]> {
    return this.https.get<Category[]>( this.APIUrl+'/category');
  }

  
  AddCategory(category : Category):Observable<Category> {
    return this.https.post<Category>(this.APIUrl + '/category',category)
  }
  addProduct(product : Product):Observable<Product> {
    console.log(product);
    return this.https.post<Product>(this.APIUrl+'/product', product)
  }

  RegisterUser(user : User):Observable<User> {
    return this.https.post<User>(this.APIUrl+'/User/true', user);
  }

  ListOrders():Observable<any[]>{
    return this.https.get<any>(this.APIUrl+'/order');
  }

  ListProduct():Observable<any[]>{
    return this.https.get<any>(this.APIUrl+'/Product');
  }

  addInventory(val:any){
    return this.https.post(this.APIUrl+'/inventory',val);
  }

  GetUserOrder(id: number){
    console.log(id);
    return this.https.get<Order>(`${this.APIUrl}/order/${id}/false`);

  }

  DeleteProduct(id: number){
    return this.https.delete<Product>(`${this.APIUrl}/Product/${id}`);
  }

}
