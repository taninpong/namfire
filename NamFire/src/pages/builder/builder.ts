import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams} from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@IonicPage()
@Component({
  selector: 'page-builder',
  templateUrl: 'builder.html',
})
export class BuilderPage {

  constructor(public navCtrl: NavController, public navParams: NavParams,public http: HttpClient) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad BuilderPage');
  }
  room(){
    this.navCtrl.push("RoomPage");
  }
  back(){
    this.navCtrl.pop();
  }
}
