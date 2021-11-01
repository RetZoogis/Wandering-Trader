import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-getorder',
  templateUrl: './getorder.component.html',
  styleUrls: ['./getorder.component.css']
})
export class GetorderComponent implements OnInit {

  constructor(private service :SharedService) { }

  OrderList:any=[];
  ProductList:any=[];

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

}
