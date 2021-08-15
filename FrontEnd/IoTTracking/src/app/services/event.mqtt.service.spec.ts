/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { Event.mqttService } from './event.mqtt.service';

describe('Service: Event.mqtt', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [Event.mqttService]
    });
  });

  it('should ...', inject([Event.mqttService], (service: Event.mqttService) => {
    expect(service).toBeTruthy();
  }));
});
