import { TestBed } from '@angular/core/testing';
import { DatosDat } from './datos-dat';

describe('DatosDat', () => {
  let service: DatosDat;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DatosDat);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
