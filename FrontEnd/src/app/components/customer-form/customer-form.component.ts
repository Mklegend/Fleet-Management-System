import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NzNotificationService } from 'ng-zorro-antd/notification';
import { Customer } from 'src/app/models/Customer';
import { CustomerApiService } from 'src/app/services/customer-api.service';
import { AbstractControl, ValidatorFn } from '@angular/forms';

@Component({
  selector: 'app-customer-form',
  templateUrl: './customer-form.component.html',
  styleUrls: ['./customer-form.component.css'],
})
export class CustomerFormComponent implements OnInit {
  form: FormGroup;
  @Input() customer: Customer;
  @Input() close!: () => void;
  constructor(
    private customerApi: CustomerApiService,
    private notification: NzNotificationService
  ) {
    this.customer = {} as Customer;
    this.form = new FormGroup({
      customerName: new FormControl('', [Validators.required]),
      phoneNumber: new FormControl('', [Validators.required]),
      address: new FormControl('', [Validators.required]),
      cnic: new FormControl('', [Validators.required,this.cnicValidator()]),
      licenseNumber: new FormControl('', [Validators.required,this.licenseNumberValidator()]),
    });
  }

  cnicValidator(): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } | null => {
      const cnicRegex = /^(\d{5})-?(\d{7})-?(\d{1})$/;
      const cnic = control.value;
      if (cnic && !cnicRegex.test(cnic)) {
        return { cnic: { value: cnic } };
      }
      return null;
    };
  }

  licenseNumberValidator(): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } | null => {
      const licenseRegex = /^[A-Z]{2}-\d{2}-\d{5}$/;
      const license = control.value;
      if (license && !licenseRegex.test(license)) {
        return { 'licenseNumber': { value: license } };
      }
      return null;
    };
  }

  ngOnInit() {
    this.form.get('customerName')?.setValue(this.customer.customerName);
    this.form.get('phoneNumber')?.setValue(this.customer.phoneNumber);
    this.form.get('address')?.setValue(this.customer.address);
    this.form.get('cnic')?.setValue(this.customer.cnic);
    this.form.get('licenseNumber')?.setValue(this.customer.licenseNumber);
  }

  submitForm(): void {
    if (this.form.valid) {
      console.log('submit', this.form.value);
      let formData = new FormData();
      if (this.customer.customerId) {
        formData.append('customerId', this.customer.customerId);
      }
      formData.append('customerName', this.form.get('customerName')?.value);
      formData.append('phoneNumber', this.form.get('phoneNumber')?.value);
      formData.append('address', this.form.get('address')?.value);
      formData.append('cnic', this.form.get('cnic')?.value);
      formData.append('licenseNumber', this.form.get('licenseNumber')?.value);

      this.customerApi.updateCustomer(formData).subscribe((res) => {
        if (res == true) {
          console.log('Customer Updated Successfully !');
          this.notification.create(
            'success',
            'Success',
            'Customer has been Updated Succesfully !'
          );
          this.close();
        }
      });
    } else {
      Object.values(this.form.controls).forEach((control) => {
        if (control.invalid) {
          control.markAsDirty();
          control.updateValueAndValidity({ onlySelf: true });
        }
      });
    }
  }
}
