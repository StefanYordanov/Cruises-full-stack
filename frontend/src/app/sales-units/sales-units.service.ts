import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';

import { ISalesUnit } from './sales-unit';

@Injectable()
export class SalesUnitsService {
  private _salesUnitsUrl = 'https://localhost:44305/api/GetBookingsGrouped/';

  constructor(private _http: HttpClient) { }

  getSalesUnits(year: number, quarter: number): Observable<ISalesUnit[]> {
    return this._http.get<ISalesUnit[]>(this._salesUnitsUrl + year + '/' + quarter).pipe(
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
