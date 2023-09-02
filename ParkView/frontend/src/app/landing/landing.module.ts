import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SectionAComponent } from './section-a/section-a.component';
import { PageLandingComponent } from './page-landing/page-landing.component';



@NgModule({
  declarations: [
    SectionAComponent,
    PageLandingComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [PageLandingComponent]
})
export class LandingModule { }
