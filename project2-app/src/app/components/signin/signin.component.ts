import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { NgbModal, ModalDismissReasons, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { LogInRequest, UserService } from 'src/app/user/user.service';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})


export class SigninComponent implements OnInit {

  constructor(private service: UserService, private formBuilder: FormBuilder, public modal: NgbActiveModal) { }

  form: FormGroup = new FormGroup(
    {
      id!: new FormControl(''),
      fullName: new FormControl(''),
      pass: new FormControl(''),
      email: new FormControl(''),
      dateJoined!: new FormControl(''),
      isAdmin!: new FormControl('')
    });


  ngOnInit(): void {

  }

  onSubmit() {
    const request: LogInRequest = {
      
      email: this.form.value.email,
      pass: this.form.value.pass
    }
    this.service.logIn(request.email, request.pass);
    this.modal.close(200);

  }
}
