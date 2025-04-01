import { Component } from '@angular/core';
import {HeaderComponent} from "../../components/header/header.component";
import {RouterLink, RouterLinkActive} from "@angular/router";

@Component({
  selector: 'app-home',
  imports: [
    HeaderComponent,
    RouterLink,
    RouterLinkActive
  ],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

}
