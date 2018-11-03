import { ChangeModels } from './../../app/models';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  changeModels: ChangeModels = new ChangeModels;
  pay: number;
  amount: number;

  constructor(public navCtrl: NavController, public http: HttpClient) {
    this.pay = 0;
    this.amount = 0;
  }

  ionViewDidEnter() {

  }

  Calculate() {
    this.http.get<ChangeModels>("http://localhost:5000/api/Values/" + this.pay + "/" + this.amount)
      .subscribe(data => {
        this.changeModels = data
        console.log(this.changeModels);
      });
  }


}
