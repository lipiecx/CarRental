import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ModelService } from '../model.service';

export interface Model{
  id:number;
  brand:string;
  Capacity:string;
  HorsePower:number;
  
  }
@Component({
  selector: 'app-model',
  templateUrl: './model.component.html',
  styleUrls: ['./model.component.css']
})
export class ModelComponent implements OnInit {

  models:Model[]=[];
  constructor(private modelService:ModelService,private router: Router,private route:ActivatedRoute) { }

  ngOnInit() {

   
    this.get();
    console.log(this.models);
    this.modelService.changes().subscribe(res=>{
    console.log(res);
    this.get();
    setTimeout(()=>console.log(this.models),2000);
    });
}

get()
{
this.modelService.getModels().subscribe(res=>this.models=res);
}
}
