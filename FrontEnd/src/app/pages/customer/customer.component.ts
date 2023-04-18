import { Component,OnChanges, SimpleChanges } from '@angular/core';
import { FormControl } from '@angular/forms';
import { NzDrawerService } from 'ng-zorro-antd/drawer';
import { CustomerFormComponent } from 'src/app/components/customer-form/customer-form.component';
import { Customer } from 'src/app/models/Customer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css'],
})
export class CustomerComponent {
  dataSet: Customer[];
  filteredDataSet:Customer[];
  search:FormControl;
  constructor(private drawer:NzDrawerService) {
    this.search = new FormControl("")
    this.search.valueChanges.subscribe(()=>{
      this.filteredDataSet = this.dataSet.filter(customer=>{
        return customer.CustomerName.toLowerCase().includes(this.search.value.toLowerCase());
      })
    })
    
    this.dataSet = [
      {
        CustomerId: '',
        CustomerName: 'Jhon Doe',
        PhoneNumber: '0987-9220-333',
        Address:
          'Somewhere on Earth , Right side of the equator south to the north pole',
        Cnic: '21312324-24234-234',
        LicenseNumber: '23423-4234-3243',
      },
      {
        CustomerId: '',
        CustomerName: 'Drake Morson',
        PhoneNumber: '0987-9220-333',
        Address:
          'Somewhere on Earth , Right side of the equator south to the north pole',
        Cnic: '21312324-24234-234',
        LicenseNumber: '23423-4234-3243',
      }
    ];
    this.filteredDataSet = this.dataSet;
  }

  // Function for Opening Drawer to Add a Customer
  addCustomer(){
    const drawerRef = this.drawer.create({
      nzTitle: 'Add Customer',
      nzContent: CustomerFormComponent
    });
  }
  editCustomer(customer:Customer){
    const drawerRef = this.drawer.create({
      nzTitle: 'Add Customer',
      nzContent: CustomerFormComponent,
      nzContentParams:{
        customer:customer
      }
    });
  }
}
