import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable} from 'rxjs';
import { Client } from './client/client.component';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private aktualizacja: BehaviorSubject<Client[]> = new BehaviorSubject<Client[]>([]);
  constructor(public http: HttpClient) { }

  changes():Observable<Client[]>{

    return this.aktualizacja.asObservable();
  }

    getClients(): Observable<Client[]>
    {
      return this.http.get<Client[]>("https://localhost:44314/api/Client/getAll");

  
    }


    getClient(id:number): Observable<Client>{
      return this.http.get<Client>("https://localhost:44398/api/Client/"+id);
    }
  


}

