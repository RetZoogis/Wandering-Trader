import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-getproduct',
  templateUrl: './getproduct.component.html',
  styleUrls: ['./getproduct.component.css']
})
export class GetproductComponent implements OnInit {

  constructor(private service :SharedService) { }

  ProductList:any=[];

  ngOnInit(): void {
    this.RefreshProductList();

  }

  RefreshProductList()
  {
    this.service.ListProduct().subscribe(data=>{
this.ProductList = data;

    });
  }  

}
