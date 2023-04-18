import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { CustomerComponent } from './pages/customer/customer.component';
import { InventoryComponent } from './pages/inventory/inventory.component';
import { MaintenanceComponent } from './pages/maintenance/maintenance.component';
import { PaymentComponent } from './pages/payment/payment.component';
import { ReservationComponent } from './pages/reservation/reservation.component';
import { VehicleComponent } from './pages/vehicle/vehicle.component';

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

