import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Apartado2 } from './apartado2';

describe('Apartado2', () => {
  let component: Apartado2;
  let fixture: ComponentFixture<Apartado2>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Apartado2],
    }).compileComponents();

    fixture = TestBed.createComponent(Apartado2);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
