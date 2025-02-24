import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import {HeaderComponent} from "../../components/header/header.component";

@Component({
  selector: 'app-login',
  imports: [RouterLink, RouterLinkActive, HeaderComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {

}
