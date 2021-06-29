import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ClientService } from '../client.service';


export interface Client {
id:number;
surename:string;
name:string;
pesel:string;
address:string;
tel:string;
wallet:number;
}

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {
   
  @Input()client:Client;
  @Output() outputEmitter = new EventEmitter();
  constructor(private clientService:ClientService,private router: Router,private route:ActivatedRoute) { }

  ngOnInit() {
  
if(this.client == null) {
      const id = Number.parseInt(this.route.snapshot.paramMap.get('id'));
      if(id >0) {
        this.clientService.getClient(id).subscribe(res => this.client = res);
      }

   }
  
  }


onUpdate(){

  this.router.navigateByUrl('client/' +this.client.id + '/update');
}


onDelete() {
  this.clientService.delete(this.client.id).subscribe(() => console.log('delete client'));
}

  }


  