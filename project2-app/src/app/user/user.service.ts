import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { User } from '../components/interfaces/user';
import { SharedService } from '../shared.service';
import { filter, shareReplay } from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private userSubject: BehaviorSubject<User | null> = new BehaviorSubject<User | null>(null);
  user$: Observable<User | null> = this.userSubject.asObservable().pipe(shareReplay());

  constructor(private sharedService: SharedService) {
  }

  init(): void {
    const serializedUser: string | null = localStorage.getItem('user');
    if (serializedUser) {
      const localUser: User = JSON.parse(serializedUser)
      this.userSubject.next(localUser);
    }
  }


  logIn(email: string, pass: string) {
    this.sharedService.LoginUser({
      email,
      pass

    }).subscribe(user => {
      console.log(user);
      this.userSubject.next(user);
      localStorage.setItem('user', JSON.stringify(user))

    });
  }
  logOut() {
    this.userSubject.next(null);
    localStorage.clear();
  }
}

export interface LogInRequest {
  email: string;
  pass: string;
}