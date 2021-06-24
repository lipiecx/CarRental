import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CarService } from '../car.service';

export interface Car {
  id:number;
  idModel:number;
  registration;
  isAvailable:boolean;
  
  }

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css']
})
export class CarComponent implements OnInit {

   
  cars:Car[]=[];
  constructor(private carService:CarService,private router: Router,private route:ActivatedRoute) { }

  ngOnInit() {

     setTimeout(()=>console.log(this.cars),100);
    this.get();
    console.log(this.cars);
    this.carService.changes().subscribe(res=>{
    console.log(res);
    this.get();
  
    });
}

get()
{
this.carService.getCars().subscribe(res=>this.cars=res);
}

}
