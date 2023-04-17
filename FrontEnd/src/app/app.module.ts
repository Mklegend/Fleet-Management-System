import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NZ_I18N } from 'ng-zorro-antd/i18n';
import { en_US } from 'ng-zorro-antd/i18n';
import { registerLocaleData } from '@angular/common';
import en from '@angular/common/locales/en';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { IconsProviderModule } from './icons-provider.module';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { CustomerComponent } from './components/customer/customer.component';
import { ReservationComponent } from './components/reservation/reservation.component';
import { PaymentComponent } from './components/payment/payment.component';
import { MaintenanceComponent } from './components/maintenance/maintenance.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { VehicleComponent } from './components/vehicle/vehicle.component';

registerLocaleData(en);

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    CustomerComponent,
    ReservationComponent,
    PaymentComponent,
    MaintenanceComponent,
    InventoryComponent,
    VehicleComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    IconsProviderModule,
    NzLayoutModule,
    NzMenuModule,
    NzIconModule
  ],
  providers: [
    { provide: NZ_I18N, useValue: en_US }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
