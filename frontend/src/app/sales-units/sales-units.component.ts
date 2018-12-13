import { Component, OnInit } from '@angular/core';
import { SalesUnitsService } from './sales-units.service';
import { ISalesUnit } from './sales-unit';

@Component({
    selector: 'app-sales-units',
    templateUrl: './sales-units.component.html',
    styleUrls: ['./sales-units.component.css']
})
export class SalesUnitsComponent implements OnInit {

    salesUnits: ISalesUnit[] = [];
    constructor(private _salesUnitsService: SalesUnitsService) { }

    ngOnInit() {
        this._salesUnitsService.getSalesUnits(2016, 1).subscribe(
            salesUnits =>{
                this.salesUnits = salesUnits;
            }
        );
    }

}
