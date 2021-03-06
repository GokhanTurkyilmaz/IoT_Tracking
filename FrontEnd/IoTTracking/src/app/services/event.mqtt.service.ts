import { EventEmitter, Injectable } from '@angular/core';
import { IMqttMessage, IOnConnectEvent, MqttService } from 'ngx-mqtt';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EventMqttService {
private endpoint:string
constructor(private _mqttService:MqttService) {
  this.endpoint='event'
 }

 topic(deviceId: string): Observable<IMqttMessage> {
  let topicName = `/${this.endpoint}/${deviceId}`;     
  return this._mqttService.observe(topicName);
}

}
