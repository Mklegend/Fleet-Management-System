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
import { NzIconModule } from 'ng-zorro-antd/icon';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { CustomerComponent } from './pages/customer/customer.component';
import { InventoryComponent } from './pages/inventory/inventory.component';
import { MaintenanceComponent } from './pages/maintenance/maintenance.component';
import { PaymentComponent } from './pages/payment/payment.component';
import { ReservationComponent } from './pages/reservation/reservation.component';
import { VehicleComponent } from './pages/vehicle/vehicle.component';
import { CustomerFormComponent } from './components/customer-form/customer-form.component';
import { NzDrawerService } from 'ng-zorro-antd/drawer';
import { NzInputModule } from 'ng-zorro-antd/input';
import {NzButtonModule} from 'ng-zorro-antd/button'
import { NzTableModule } from 'ng-zorro-antd/table';
import { NzDividerModule } from 'ng-zorro-antd/divider';
import { ReactiveFormsModule } from '@angular/forms';
import { NzFormModule } from 'ng-zorro-antd/form';
import { NzNotificationModule } from 'ng-zorro-antd/notification';

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
    CustomerFormComponent,
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
    NzIconModule,
    NzInputModule,
    NzButtonModule,
    NzTableModule,
    NzDividerModule,
    ReactiveFormsModule,
    NzFormModule,
    NzNotificationModule
  ],
  providers: [{ provide: NZ_I18N, useValue: en_US }, NzDrawerService],
  bootstrap: [AppComponent],
})
export class AppModule {}
