import { Component, OnChanges, SimpleChanges } from '@angular/core';
import { FormControl } from '@angular/forms';
import { NzDrawerService } from 'ng-zorro-antd/drawer';
import { NzNotificationService } from 'ng-zorro-antd/notification';
import { CustomerFormComponent } from 'src/app/components/customer-form/customer-form.component';
import { Customer } from 'src/app/models/Customer';
import { CustomerApiService } from 'src/app/services/customer-api.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css'],
})
export class CustomerComponent {
  dataSet: Customer[];
  filteredDataSet: Customer[];
  pageIndex: number = 1;
  itemsPerPage:number = 7;
  totalItems: number = 10;
  search: FormControl;
  constructor(
    private notification: NzNotificationService,
    private drawer: NzDrawerService,
    private customerApi: CustomerApiService
  ) {
    this.search = new FormControl('');
    this.search.valueChanges.subscribe(() => {
      const startIndex = (this.pageIndex - 1) * this.itemsPerPage;
      const endIndex = startIndex + this.itemsPerPage;
      this.filteredDataSet = this.dataSet
        .slice(startIndex, endIndex)
        .filter((customer) => {
          return customer.customerName
            .toLowerCase()
            .includes(this.search.value.toLowerCase());
        });
    });

    // this.dataSet = [
    //   {
    //     CustomerId: '',
    //     CustomerName: 'Jhon Doe',
    //     PhoneNumber: '0987-9220-333',
    //     Address:
    //       'Somewhere on Earth , Right side of the equator south to the north pole',
    //     Cnic: '21312324-24234-234',
    //     LicenseNumber: '23423-4234-3243',
    //   },
    //   {
    //     CustomerId: '',
    //     CustomerName: 'Drake Morson',
    //     PhoneNumber: '0987-9220-333',
    //     Address:
    //       'Somewhere on Earth , Right side of the equator south to the north pole',
    //     Cnic: '21312324-24234-234',
    //     LicenseNumber: '23423-4234-3243',
    //   }
    // ];
    this.dataSet = [];
    this.filteredDataSet = [];
  }

  ngOnInit() {
    this.getCustomers();
  }

  pageIndexChanged(pageIndex: number): void {
    this.pageIndex = pageIndex;
    const startIndex = (this.pageIndex - 1) * this.itemsPerPage;
    const endIndex = startIndex + this.itemsPerPage;
    this.filteredDataSet = this.dataSet.slice(startIndex, endIndex);
  }

  getCustomers() {
    const startIndex = (this.pageIndex - 1) * this.itemsPerPage;
    const endIndex = startIndex + this.itemsPerPage;
    this.customerApi.getCustomers().subscribe((customers) => {
      this.dataSet = customers;
      this.filteredDataSet = this.dataSet.slice(startIndex, endIndex);
      this.totalItems = this.dataSet.length;
      console.log(customers);
    });
  }

  // Function for Opening Drawer to Add a Customer
  addCustomer() {
    const drawerRef = this.drawer.create({
      nzTitle: 'Add Customer',
      nzContent: CustomerFormComponent,
      nzContentParams: {
        close: () => {
          this.getCustomers();
          drawerRef.close();
        },
      },
    });
  }
  deleteCustomer(id: string) {
    this.customerApi.deleteCustomer(id).subscribe((res) => {
      if (res == true) {
        this.notification.create(
          'success',
          'Success',
          'Customer has been Deleted !'
        );
        console.log('Customer deleted Successfully !');
      }
      this.getCustomers();
    });
  }
  editCustomer(customer: Customer) {
    const drawerRef = this.drawer.create({
      nzTitle: 'Add Customer',
      nzContent: CustomerFormComponent,
      nzContentParams: {
        customer: customer,
        close: () => {
          this.getCustomers();
          drawerRef.close();
        },
      },
    });
  }
}
