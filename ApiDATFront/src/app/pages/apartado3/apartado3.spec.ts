import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Apartado3 } from './apartado3';

describe('Apartado3', () => {
  let component: Apartado3;
  let fixture: ComponentFixture<Apartado3>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Apartado3],
    }).compileComponents();

    fixture = TestBed.createComponent(Apartado3);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
