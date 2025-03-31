import { Routes } from '@angular/router';
import { IndexComponent } from './pages/index/index.component';
import { LoginComponent } from './pages/login/login.component';
import { SignupComponent } from './pages/signup/signup.component';
import { ExploreComponent } from './pages/explore/explore.component';
import { UserComponent } from './pages/user/user.component';
import {HomeComponent} from "./pages/home/home.component";

export const routes: Routes = [
  {
    path: "",
    component: IndexComponent
  },
  {
    path: "index",
    component: IndexComponent
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
    path: "home",
    component: HomeComponent
  }
];
