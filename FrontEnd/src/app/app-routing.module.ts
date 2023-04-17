import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { CustomerComponent } from './components/customer/customer.component';
import { ReservationComponent } from './components/reservation/reservation.component';
import { PaymentComponent } from './components/payment/payment.component';
import { MaintenanceComponent } from './components/maintenance/maintenance.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { VehicleComponent } from './components/vehicle/vehicle.component';

const routes: Routes = [
  {
    path:'admin',
    component:DashboardComponent,
    children : [
      {
        path:'customer',
        component:CustomerComponent
      },
      {
        path:'reservation',
        component:ReservationComponent
      },
      {
        path:'payment',
        component:PaymentComponent
      },
      {
        path:'maintenance',
        component:MaintenanceComponent
      },
      {
        path:'inventory',
        component:InventoryComponent
      },
      {
        path:'vehicle',
        component:VehicleComponent
      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

