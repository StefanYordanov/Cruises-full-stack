import { TestBed, inject } from '@angular/core/testing';

import { SalesUnitsService } from './sales-units.service';

describe('SalesUnitsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SalesUnitsService]
    });
  });

  it('should be created', inject([SalesUnitsService], (service: SalesUnitsService) => {
    expect(service).toBeTruthy();
  }));
});
