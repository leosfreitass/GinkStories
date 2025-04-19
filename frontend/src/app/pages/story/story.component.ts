import { Component } from '@angular/core';
import { HeaderComponent } from '../../components/header/header.component';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-story',
  imports: [
    HeaderComponent, 
    RouterLink, 
    RouterLinkActive 
  ],
  templateUrl: './story.component.html',
  styleUrl: './story.component.scss'
})
export class StoryComponent {

}
