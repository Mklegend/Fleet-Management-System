export class Customer {
  customerId: string;
  customerName: string;
  phoneNumber: string;
  address: string;
  cnic: string;
  licenseNumber: string;

  constructor(
    customerId: string,
    customerName: string,
    phoneNumber: string,
    address: string,
    cnic: string,
    licenseNumber: string
  ) {
    this.customerId = customerId;
    this.customerName = customerName;
    this.phoneNumber = phoneNumber;
    this.address = address;
    this.cnic = cnic;
    this.licenseNumber = licenseNumber;
  }
}
