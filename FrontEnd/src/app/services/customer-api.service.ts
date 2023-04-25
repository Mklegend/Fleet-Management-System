import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from '../models/Customer';

@Injectable({
  providedIn: 'root',
})
export class CustomerApiService {
  constructor(private http: HttpClient) {}

  getCustomers() {
    return this.http.get(
      'https://localhost:7091/api/Customer'
    ) as Observable<Customer[]>;
  }

  updateCustomer(formData: FormData) {
    return this.http.post('https://localhost:7091/api/Customer', formData);
  }

  deleteCustomer(id: string) {
    return this.http.delete(`https://localhost:7091/api/Customer?id=${id}`);
  }
}
