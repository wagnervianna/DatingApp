import { createHostListener } from '@angular/compiler/src/core';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrModule, ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { AccountService } from '../services/account.service';
import { User } from '../_models/user';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(public accountService: AccountService, private router: Router, private toastr: ToastrService) { }

  ngOnInit(): void {
  }
  // tslint:disable-next-line:typedef
  login() {
    this.accountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/members');
    });
  }
  // tslint:disable-next-line:typedef
  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }
}
