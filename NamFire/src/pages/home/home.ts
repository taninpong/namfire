import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { BuilderPage } from '../builder/builder';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController) {

  }
  goToMyPage() {
    // go to the MyPage component
    this.navCtrl.push(BuilderPage);
  }

}
