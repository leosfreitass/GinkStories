import {Component, OnInit} from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import {HeaderComponent} from "../../components/header/header.component";
import {FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators} from "@angular/forms";
import {CommonModule} from "@angular/common";

@Component({
  selector: 'app-login',
  imports: [RouterLink, RouterLinkActive, HeaderComponent,FormsModule,ReactiveFormsModule, CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent implements OnInit {
  formValidation!: FormGroup;


  ngOnInit(): void {
    this.formValidation = new FormGroup({
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl ('',[Validators.required, Validators.minLength(7)])
    })

    this.formValidation.get ('email')?.valueChanges.subscribe(value =>{
      console.log(value)
    })
  }

  get email() {
    return this.formValidation.get('email')!;
  }
  get password() {
    return this.formValidation.get('password')!;
  }

  submit(){
    if (this.formValidation.invalid) {
      console.log("invalido")
      return;
  }
    console.log ("Enviado")
    console.log (this.formValidation.value)

  }
}
