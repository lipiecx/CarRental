import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { OrderService } from '../order.service';

export interface Order
{
  id:number;
  idClient:number;
  idCar:number;
  OrderData:Date;
  ReturnDate:Date;
  Price:number;
}

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  orders:Order[]=[];
  constructor(private orderService:OrderService,private router: Router,private route:ActivatedRoute) { }

  ngOnInit() {

   
    this.get();
    this.orderService.changes().subscribe(res=>{
    console.log(res);
    this.get();
    setTimeout(()=>console.log(this.orders),2000);
    });
}

get()
{
this.orderService.getOrders().subscribe(res=>this.orders=res);
}

}
