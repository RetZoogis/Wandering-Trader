import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { Category } from '../../interfaces/category';


import { FormBuilder, FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-get',
  templateUrl: './get.component.html',
  styleUrls: ['./get.component.css']
})

export class GetComponent implements OnInit {

  form: FormGroup = new FormGroup ( 
    {
      subject: new FormControl('hello hello')
    });

  constructor(private service :SharedService, private formBuilder: FormBuilder) { }

  InventoryList:any=[];

  categories: Category[] | null = null ;

  ngOnInit(): void {
    this.refreshinvList();
    this.GetCategory();
    
    // this.form = this.formBuilder.group({
    //   subject:['']
    // });

  }

 
  refreshinvList()
  {
    this.service.ListInventory().subscribe(data=>{
this.InventoryList = data;

    });
  }  


  GetCategory()
  {
    this.service.ListCategory().subscribe((categories) => {
      this.categories = categories;
    });

  }

// get f() { return this.form.controls; }


  onSubmit()
  {
    
    this.service.AddCategory(this.form.value).subscribe(
      res => {
        alert("Category  successfully added!");
      });
}
}
