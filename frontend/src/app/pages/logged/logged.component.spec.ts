import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoggedComponent } from './logged.component';

describe('LoggedComponent', () => {
  let component: LoggedComponent;
  let fixture: ComponentFixture<LoggedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LoggedComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LoggedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
