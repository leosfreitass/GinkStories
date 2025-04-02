import { Component } from '@angular/core';
import {HeaderComponent} from "../../components/header/header.component";
import {RouterLink, RouterLinkActive} from "@angular/router";
import {FeedComponent} from "../../components/feed/feed.component";

@Component({
  selector: 'app-home',
  imports: [
    HeaderComponent,
    RouterLink,
    RouterLinkActive,
    FeedComponent
  ],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

}
