import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ClientService } from '../client.service';


export interface Client {
id:number;
Surename:string;
Name:string;
Pesel:string;
Address:string;
Tel:number;
Wallet:number;

}

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {
   
  
  clients:Client[]=[];
  constructor(private clientService:ClientService,private router: Router,private route:ActivatedRoute) { }

  ngOnInit() {

   
    this.get();
    console.log(this.clients);
    this.clientService.changes().subscribe(res=>{
    console.log(res);
    this.get();
    setTimeout(()=>console.log(this.clients),2000);
    
    });
 
}
get()
{
this.clientService.getClients().subscribe(res=>this.clients=res);
}


  }