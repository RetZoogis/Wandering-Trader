import { Component, OnInit } from '@angular/core';
import { SharedService } from './shared.service';
import { UserService } from './user/user.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.userService.init();
  }
  title = 'project2-app';


}
