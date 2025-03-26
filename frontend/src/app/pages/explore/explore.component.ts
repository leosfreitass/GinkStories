import { Component } from '@angular/core';
import { HeaderComponent } from '../../components/header/header.component';
import { WorkComponent } from '../../components/work/work.component';

@Component({
  selector: 'app-explore',
  imports: [ HeaderComponent, WorkComponent ],
  templateUrl: './explore.component.html',
  styleUrl: './explore.component.scss'
})
export class ExploreComponent {

}

