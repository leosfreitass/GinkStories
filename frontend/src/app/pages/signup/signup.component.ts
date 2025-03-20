import { Component, OnInit} from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import {HeaderComponent} from "../../components/header/header.component";
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import PasswordValidator from '../../shared/validators/password-validator.validator';

@Component({
  selector: 'app-signup',
  imports: [RouterLink, RouterLinkActive, HeaderComponent, ReactiveFormsModule, FormsModule, CommonModule],
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.scss'
})
export class SignupComponent implements OnInit{

  formValidation!: FormGroup;

  ngOnInit(): void {
    this.formValidation = new FormGroup({
      firstName: new FormControl ('', [Validators.required,Validators.minLength(2)]),
      lastName: new FormControl ('',[Validators.required,Validators.minLength(2)]),
      email: new FormControl ('',[Validators.required,Validators.email]),
      password: new FormControl ('',[Validators.required,Validators.minLength(7),PasswordValidator.passwordStrength]),
      confirmPassword: new FormControl ('',[Validators.required,PasswordValidator.matchPassword])
    })



  }

  get firstName () {
    return this.formValidation.get('firstName')!;
  }

  get lastName (){
    return this.formValidation.get('lastName')!;
  }

  get email (){
    return this.formValidation.get('email')!;
  }

  get password (){
    return this.formValidation.get('password')!;
  }

  get confirmPassword () {
    return this,this.formValidation.get('confirmPassword')!;
  }


  submit (){
    if(this.formValidation.invalid){
      console.log("invalido")
      return;
    }
    console.log("enviado")
    console.log(this.formValidation.value)
  }

  debug (){
    console.log(this.formValidation.controls)
  }
}
