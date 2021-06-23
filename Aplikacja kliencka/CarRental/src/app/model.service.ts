import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Model } from './model/model.component';

@Injectable({
  providedIn: 'root'
})
export class ModelService {

  private aktualizacja: BehaviorSubject<Model[]> = new BehaviorSubject<Model[]>([]);
  constructor(public http: HttpClient) { }

  changes():Observable<Model[]>{

    return this.aktualizacja.asObservable();
  }

    getModels(): Observable<Model[]>
    {
      return this.http.get<Model[]>("https://localhost:44314/api/Model/getAll");

      
    
    }
}
