import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ClientService } from '../client.service';
import { Client } from '../client/client.component';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  form: FormGroup;
  private id: number;


  constructor(private fb: FormBuilder, private route: ActivatedRoute, private clientService: ClientService, private router: Router) { }

  ngOnInit(): void {
  
    const id = Number.parseInt(this.route.snapshot.paramMap.get('id'));
    if(id >= 0) {
      this.id = id;
      this.clientService.getClient(id).subscribe(res => this.createForm(res));
    } else {

      this.createForm(null);
    
    }
  }

  private createForm(client?: Client) {
    this.form = this.fb.group({
      surename: new FormControl(client?.surename),
      name: new FormControl(client?.name),
      pesel: new FormControl(client?.pesel),
      address:new FormControl(client?.address),
      telephone:new FormControl(client?.tel),
      wallet:new FormControl(client?.wallet)

    });

   

  }

  onSubmit(event) {
    if(this.id > 0) {
      this.clientService.update(this.id, this.form.value).subscribe(res => this.router.navigateByUrl('client'));
    } else {
      this.clientService.create(this.form.value).subscribe(res => this.router.navigateByUrl('client'));
    }

  }

}
