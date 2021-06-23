import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Car } from './car/car.component';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  private aktualizacja: BehaviorSubject<Car[]> = new BehaviorSubject<Car[]>([]);
  constructor(public http: HttpClient) { }

  changes():Observable<Car[]>{

    return this.aktualizacja.asObservable();
  }

    getCars(): Observable<Car[]>
    {
      return this.http.get<Car[]>("https://localhost:44314/api/Car/getAll");

      
    
    }
}
