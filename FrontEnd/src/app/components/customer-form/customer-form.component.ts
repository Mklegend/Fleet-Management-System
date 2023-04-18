import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Customer } from 'src/app/models/Customer';

@Component({
  selector: 'app-customer-form',
  templateUrl: './customer-form.component.html',
  styleUrls: ['./customer-form.component.css']
})
export class CustomerFormComponent implements OnInit {
  form:FormGroup;
  @Input() customer:Customer;
  constructor(){
    this.customer = {} as Customer;
    this.form = new FormGroup({
      customerName:new FormControl("",[Validators.required]),
      phoneNumber:new FormControl("",[Validators.required]),
      address:new FormControl("",[Validators.required]),
      cnic:new FormControl("",[Validators.required]),
      licenseNumber:new FormControl("",[Validators.required])
    })
  }
  ngOnInit(){
    this.form.get("customerName")?.setValue(this.customer.CustomerName);
    this.form.get("phoneNumber")?.setValue(this.customer.PhoneNumber);
    this.form.get("address")?.setValue(this.customer.Address);
    this.form.get("cnic")?.setValue(this.customer.Cnic);
    this.form.get("licenseNumber")?.setValue(this.customer.LicenseNumber);
  }
  
  submitForm(): void {
    if (this.form.valid) {
      console.log('submit', this.form.value);
    } else {
      Object.values(this.form.controls).forEach(control => {
        if (control.invalid) {
          control.markAsDirty();
          control.updateValueAndValidity({ onlySelf: true });
        }
      });
    }
  }
}
