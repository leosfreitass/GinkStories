import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { SignupComponent } from './pages/signup/signup.component';
import { ExploreComponent } from './pages/explore/explore.component';
import { UserComponent } from './pages/user/user.component';
import { StoryComponent } from './pages/story/story.component';
import { ReadingComponent } from './pages/reading/reading.component';

export const routes: Routes = [
  {
    path: "",
    component: HomeComponent
  },
  {
    path: "home",
    component: HomeComponent
  },
  {
    path: "login",
    component: LoginComponent
  },
  {
    path: "signup",
    component: SignupComponent
  },
  {
    path: "explore",
    component: ExploreComponent
  },
  {
    path: "user",
    component: UserComponent
  },
  {
    path: "story",
    component: StoryComponent
  },
  {
    path: "reading",
    component: ReadingComponent
  }
];
