export class Customer {
  CustomerId: string;
  CustomerName: string;
  PhoneNumber: string;
  Address: string;
  Cnic: string;
  LicenseNumber: string;

  constructor(
    CustomerId: string,
    CustomerName: string,
    PhoneNumber: string,
    Address: string,
    Cnic: string,
    LicenseNumber: string
  ) {
    this.CustomerId = CustomerId;
    this.CustomerName = CustomerName;
    this.PhoneNumber = PhoneNumber;
    this.Address = Address;
    this.Cnic = Cnic;
    this.LicenseNumber = LicenseNumber;
  }
}
