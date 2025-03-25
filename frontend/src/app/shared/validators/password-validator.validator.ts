import { AbstractControl, ValidationErrors } from "@angular/forms";

function passwordStrength (control: AbstractControl) : ValidationErrors | null {
  const password = control.value;

  const hasUpperCase = /[A-Z]/.test(password);
  const hasLowerUpperCase = /[a-z]/.test(password);
  const hasNumericChar = /[0-9]/.test(password);

  const isPasswordValid = hasUpperCase && hasLowerUpperCase && hasNumericChar;

  const validationErrors = {
    hasUpperCase: !hasUpperCase,
    hasLowerUpperCase: !hasLowerUpperCase,
    hasNumericChar: !hasNumericChar
  }
  return isPasswordValid ? null : validationErrors;
}

function matchPassword (control: AbstractControl):ValidationErrors | null{
  const confirmPassword = control.value;
  const password = control?.parent?.get('password')?.value;

  if(!password) return null;

  return confirmPassword === password ? null : {mismatch: true};
}

const PasswordValidator = {
  passwordStrength,
  matchPassword
};

export default PasswordValidator;
