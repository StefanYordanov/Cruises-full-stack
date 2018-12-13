import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SalesUnitDetailsService } from './sales-unit-details.service';
import { Observable } from '../../../node_modules/rxjs';
import { ISalesUnitDetails } from './sales-unit-details';

@Component({
    selector: 'app-sales-unit-details',
    templateUrl: './sales-unit-details.component.html',
    styleUrls: ['./sales-unit-details.component.css']
})
export class SalesUnitDetailsComponent implements OnInit {

    salesUnitDetailsList: ISalesUnitDetails[];

    constructor(private _route: ActivatedRoute,
        private _router: Router,
        private _salesUnitDetailsService: SalesUnitDetailsService) { }

    ngOnInit() {
        const id = parseInt(this._route.snapshot.paramMap.get('id'));
        this._salesUnitDetailsService.getSalesUnitDetails(2016, 1, id).subscribe(
            salesUnitDetailsList=> this.salesUnitDetailsList = salesUnitDetailsList
        )
    }

}
