import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { BuilderPage } from './builder';

@NgModule({
  declarations: [
    BuilderPage,
  ],
  imports: [
    IonicPageModule.forChild(BuilderPage),
  ],
})
export class BuilderPageModule {}
