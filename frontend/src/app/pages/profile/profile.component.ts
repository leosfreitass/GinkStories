import { Component, OnInit } from '@angular/core';
import {HeaderComponent} from "../../components/header/header.component";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import { FormGroup, FormControl, Validators } from '@angular/forms';
import {CommonModule} from "@angular/common";
import PasswordValidator from '../../shared/validators/password-validator.validator';

@Component({
  selector: 'app-profile',
  imports: [HeaderComponent, FormsModule, ReactiveFormsModule, CommonModule],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.scss'
})
export class ProfileComponent implements OnInit{
  formValidation!: FormGroup;
  imagePreview: any;
  ngOnInit(): void {
    this.formValidation = new FormGroup({
      name: new FormControl ('', [Validators.required,Validators.minLength(2)]),
      email: new FormControl ('',[Validators.required,Validators.email]),
      password: new FormControl ('',[Validators.required,Validators.minLength(7),PasswordValidator.passwordStrength]),
    })
  }

  onImageChange(event: any){
    if (event.target.files && event.target.files[0]) {
      const file = event.target.files[0];
      const reader = new FileReader();
      reader.onload = e => {
        this.imagePreview= reader.result;
      };
      reader.readAsDataURL(file);
    }
  }
  get name() {
    return this.formValidation.get('name')!;
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
    console.log("formulário enviado");
    console.log(this.formValidation.value);
    console.log(this.imagePreview);
  }
}
