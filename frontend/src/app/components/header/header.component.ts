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
  constructor(public router: Router) {
  }

  ngOnInit() {
  }
}
