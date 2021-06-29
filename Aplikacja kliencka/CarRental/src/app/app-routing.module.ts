import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarComponent } from './car/car.component';
import { ClientComponent } from './client/client.component';
import { ClientsComponent } from './clients/clients.component';
import { FormComponent } from './form/form.component';
import { MenuComponent } from './menu/menu.component';
import { ModelComponent } from './model/model.component';
import { OrderComponent } from './order/order.component';

const routes: Routes = [
  { path: '',component:MenuComponent},
  {path:'client',children:[

    {path:'',component:ClientsComponent},
    {path:'id',component:ClientComponent},
    { path: 'create', component: FormComponent},
    { path: ':id/update', component: FormComponent},

  ]},
  {path:'order',children:[

    {path:'',component:OrderComponent}
  ]},
  {path:'model',children:[

    {path:'',component:ModelComponent}
  ]},
  {path:'car',children:[

    {path:'',component:CarComponent}
  ]},



];

@NgModule({
  imports: [RouterModule.forRoot(routes,{
    paramsInheritanceStrategy: 'always'
})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
