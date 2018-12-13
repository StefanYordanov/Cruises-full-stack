import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { SalesUnitsComponent } from './sales-units/sales-units.component';
import { SalesUnitsService } from './sales-units/sales-units.service';
import { SalesUnitDetailsComponent } from './sales-unit-details/sales-unit-details.component';

@NgModule({
  declarations: [
    AppComponent,
    SalesUnitsComponent,
    SalesUnitDetailsComponent,
    
  ],
  imports: [
    RouterModule.forRoot([
        { path: '', component: SalesUnitsComponent },
        { path: 'salesUnits/details/:id', component: SalesUnitDetailsComponent }
    ]),
    CommonModule,
    BrowserModule,
    HttpClientModule,
  ],
  exports:[
      CommonModule
  ],
  providers: [SalesUnitsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
