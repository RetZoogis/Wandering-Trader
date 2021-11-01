import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  constructor(private service :SharedService) { }

  OrderList:any=[];

  ngOnInit(): void {
    this.RefreshOrderList();
  }

  RefreshOrderList()
  {
    this.service.ListOrders().subscribe(data=>{
this.OrderList = data;

    });
  }  
}
