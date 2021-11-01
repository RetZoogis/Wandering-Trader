import { Component, OnInit, Input } from '@angular/core';
import {NgbModal, ModalDismissReasons, NgbActiveModal} from '@ng-bootstrap/ng-bootstrap';
import { SharedService } from 'src/app/shared.service';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})

export class SignupComponent implements OnInit {


  constructor( private service :SharedService, private formBuilder: FormBuilder, public modal: NgbActiveModal) { }

  form: FormGroup = new FormGroup ( 
    {
      fullName: new FormControl(''),
      pass: new FormControl(''),
      email: new FormControl('')
    });
    



  ngOnInit(): void {
    this.form = this.formBuilder.group({
      fullName:[''],
      pass: [''],
      email: ['']
    })
    
  }

  get f() { return this.form.controls; }

  onSubmit()
  {
    this.service.RegisterUser(this.form.value).subscribe(
      res => {
        this.modal.close(200);
        // this.modal.dismiss(200);
        console.log("Adding user to DB")  
      });
}
}
