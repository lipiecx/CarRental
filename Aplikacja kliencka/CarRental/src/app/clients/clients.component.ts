import { Component, OnInit } from '@angular/core';
import { ClientService } from '../client.service';
import { Client } from '../client/client.component';

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.css']
})
export class ClientsComponent implements OnInit {

  clients: Client[] = [];

  constructor(private clientService:ClientService) { }

  ngOnInit(): void {

    this.get();
    console.log(this.clients);
    this.clientService.changes().subscribe(res=>{
    console.log(res);
    this.get();
    
    
    });
  }


  get()
{
this.clientService.getClients().subscribe(res=>this.clients=res);
}
}
