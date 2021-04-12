import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerModel = false;
  userEndpoint = 'https://localhost:5001/api/users';

  constructor() { }

  ngOnInit(): void {
  }

  // tslint:disable-next-line:typedef
  registerToggle() {
    this.registerModel = !this.registerModel;
  }

  // tslint:disable-next-line:typedef
  cancelRegisterModel(event: boolean) {
    this.registerModel = event;
  }
}
