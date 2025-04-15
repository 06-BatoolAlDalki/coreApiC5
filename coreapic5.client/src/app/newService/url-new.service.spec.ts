import { TestBed } from '@angular/core/testing';

import { UrlNewService } from './url-new.service';

describe('UrlNewService', () => {
  let service: UrlNewService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UrlNewService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
