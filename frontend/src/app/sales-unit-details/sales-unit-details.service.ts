import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { ISalesUnitDetails } from './sales-unit-details';

@Injectable({
    providedIn: 'root'
})
export class SalesUnitDetailsService {
    private _salesUnitsDetailsUrl = 'https://localhost:44305/api/GetBookingsGrouped/';
    constructor(private _http: HttpClient) { }

    getSalesUnitDetails(year: number, quarter: number, id: number): Observable<ISalesUnitDetails[]> {
        return this._http.get<ISalesUnitDetails[]>
        (this._salesUnitsDetailsUrl + year + '/' + quarter + '/' + id)
        .pipe(
            tap(data => console.log('All: ' + JSON.stringify(data))),
            catchError(this.handleError), );
        
      }
      
      private handleError(err) {
        let errorMessage = '';
        if (err.error instanceof Error) {
          errorMessage = `An error occurred: ${err.error.message}`;
        } else {
          errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
        }
        console.error(errorMessage);
        return throwError(errorMessage);
      }

}
