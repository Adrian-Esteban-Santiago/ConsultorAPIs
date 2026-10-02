import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Apartado1 } from './apartado1';

describe('Apartado1', () => {
  let component: Apartado1;
  let fixture: ComponentFixture<Apartado1>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Apartado1],
    }).compileComponents();

    fixture = TestBed.createComponent(Apartado1);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
