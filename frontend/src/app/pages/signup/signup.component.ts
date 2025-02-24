import { Component} from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import {HeaderComponent} from "../../components/header/header.component";

@Component({
  selector: 'app-signup',
  imports: [RouterLink, RouterLinkActive, HeaderComponent],
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.scss'
})
export class SignupComponent {

}
