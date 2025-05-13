import { Component, OnInit } from '@angular/core';
import {RouterLink, RouterLinkActive, Router} from "@angular/router";
import {NgIf} from "@angular/common";

@Component({
  selector: 'app-header',
  imports: [
    RouterLink,
    RouterLinkActive,
    NgIf,
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent implements OnInit {
  currentUrl: string = '';
  buttonVisibility: { [key: string]: string[] } = {
    login: ['/signup','/','/index'],
    signup: ['/login','/','/index'],

  }
  constructor(public router: Router) {
    this.router.events.subscribe(() =>{
      this.currentUrl = this.router.url;
    })
  }

  shouldShow(button: string) : boolean {
    return this.buttonVisibility[button]?.includes(this.currentUrl);
  }

  ngOnInit() {
  }
}
