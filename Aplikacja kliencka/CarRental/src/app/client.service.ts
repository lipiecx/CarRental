import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable} from 'rxjs';
import { Client } from './client/client.component';
import { map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  private aktualizacja: BehaviorSubject<String> = new BehaviorSubject<String>('');
  constructor(public http: HttpClient) { }

  changes():Observable<String>{

    return this.aktualizacja.asObservable();
  }

    getClients(): Observable<Client[]>
    {
      return this.http.get<Client[]>("https://localhost:44314/api/Client/getAll");

  
    }

    getClient(id: number): Observable<Client>{
      return this.http.get<Client>("https://localhost:44314/api/Client/"+id);
    }
    
  
    delete(id: number): Observable<void> {
      return this.http.delete<boolean>("https://localhost:44314/api/Client/" + id.toString())
      .pipe(
        map(res => {
        return;
      }),
      tap(res => this.aktualizacja.next('Delete Clienta!')));
    }

    update(id: number, client: Client): Observable<Client> {
      return this.http.put<Client>("https://localhost:44314/api/Client/" + id, client )
      .pipe(tap(
        res => this.aktualizacja.next('Zmodyfikowano clienta z id = ' + id + '!')
      ));
    }

    create(client: Client): Observable<Client> {
      return this.http.post<Client>("https://localhost:44314/api/Client", client)
      .pipe(tap(
        res => this.aktualizacja.next('Dodano clienta')
      ));
    }

}

