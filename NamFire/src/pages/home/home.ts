import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { BuilderPage } from '../builder/builder';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController,public http: HttpClient) {

  }
  builder() {
    // go to the MyPage component
    this.navCtrl.push("BuilderPage");
  }

}
