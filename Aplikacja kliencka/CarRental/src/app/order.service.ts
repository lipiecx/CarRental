import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Order } from './order/order.component';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  private aktualizacja: BehaviorSubject<Order[]> = new BehaviorSubject<Order[]>([]);
  constructor(public http: HttpClient) { }

  changes():Observable<Order[]>{

    return this.aktualizacja.asObservable();
  }

    getOrders(): Observable<Order[]>
    {
      return this.http.get<Order[]>("https://localhost:44314/api/Order/getAll");

      
    
    }
}
