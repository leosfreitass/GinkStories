import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import {HeaderComponent} from "../../components/header/header.component";

@Component({
  selector: 'app-home',
  imports: [HeaderComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

}
