import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { Product } from '../interfaces/product';


@Component({
  selector: 'app-sidecheckout',
  templateUrl: './sidecheckout.component.html',
  styleUrls: ['./sidecheckout.component.css']
})
export class SidecheckoutComponent implements OnInit {



  constructor(private service :SharedService) { }
  OrderList:any=[];
  ProductList:any=[];
  InventoryList: any=[];

  ngOnInit(): void {
    this.RefreshOrderList();

 

    this.RefreshProductList();

  }

  RefreshOrderList()
  {
    this.service.ListOrders().subscribe(data=>{
this.OrderList = data;

    });
  }  

  RefreshProductList()
  {
    this.service.ListProduct().subscribe(data=>{
this.ProductList = data;

    });
  }  

  deleteProduct(dataItem : Product)
  {
  
    const id = Number(dataItem.id);
    debugger;

    this.service.DeleteProduct(id).subscribe(data=>{
     
        
      alert("Product has been deleted!");
    });
  }

}
