import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import {appRoutes} from './routes'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './navBar/navBar.component';
import { DeviceSettingsComponent } from './deviceSettings/DeviceSettings.component';
import { PersonsComponent } from './persons/persons.component';
import { TagsComponent } from './tags/tags.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { IMqttServiceOptions,MqttModule, MqttService } from 'ngx-mqtt';
import { environment  as env } from '../environments/environment.prod';


// const MQTT_SERVICE_OPTIONS:IMqttServiceOptions={
//   hostname:env.mqtt.server,
//   port:env.mqtt.port,
//   protocol:(env.mqtt.protocol==="wss") ? "wss":"ws",
//   path:'',

// }
export const MQTT_SERVICE_OPTIONS: IMqttServiceOptions = {
  hostname: 'test.mosquitto.org',
  port: 8081,
  path: '/mqtt'
};


@NgModule({
  declarations: [					
    AppComponent,
      NavBarComponent,
      DeviceSettingsComponent,
      PersonsComponent,
      TagsComponent,
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes),
    BrowserAnimationsModule,
    MqttModule.forRoot(MQTT_SERVICE_OPTIONS)
  ],
  providers: [MqttService],
  bootstrap: [AppComponent]
})
export class AppModule { }
