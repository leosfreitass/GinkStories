import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { SignupComponent } from './pages/signup/signup.component';
import { ExploreComponent } from './pages/explore/explore.component';
import { UserComponent } from './pages/user/user.component';
import {LoggedComponent} from "./pages/logged/logged.component";

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
    path: "logged",
    component: LoggedComponent
  }
];
