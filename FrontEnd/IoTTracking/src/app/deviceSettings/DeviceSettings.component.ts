import { Component, OnInit, HostListener, EventEmitter, ViewChild, TemplateRef } from '@angular/core';
import { Injectable } from '@angular/core';
import { AlertifyService } from '../services/alertify.service';

import {
  NgbModal,
  ModalDismissReasons,
  NgbModalOptions,
} from '@ng-bootstrap/ng-bootstrap';
import * as _ from 'lodash';
import { IMqttMessage, IOnConnectEvent, MqttConnectionState, MqttService } from 'ngx-mqtt';
import { EventMqttService } from '../services/event.mqtt.service';
import { Subscription } from 'rxjs';
import { Console } from 'console';

declare var $: any;

var url = '../../../externalLibrary/redips-drag-min.js';

@Component({
  selector: 'app-DeviceSettings',
  templateUrl: './DeviceSettings.component.html',
  styleUrls: ['./DeviceSettings.component.css'],
})
export class DeviceSettingsComponent implements OnInit {
  @ViewChild('mymodal') mymodal : TemplateRef<any>
  closeResult: string;
  modalOptions: NgbModalOptions;
  events: any[];
  private deviceId: string;
  subscription: Subscription;
  message: string;
  status: Array<string> = [];
  constructor(
    private alertifyService: AlertifyService,
    private modalService: NgbModal,
    private readonly eventMqtt: EventMqttService,
    private _mqttService:MqttService,
    
  ) {
    this.modalOptions = {
      backdrop: 'static',
      backdropClass: 'customBackdrop',
    };

    this._mqttService.state.subscribe((s:MqttConnectionState)=>{
      const status = s === MqttConnectionState.CONNECTED ? 'CONNECTED' : 'DISCONNECTED';
      if(status=='CONNECTED'){
        this.alertifyService.success("MQTT CONNECTION IS: "+status.toString())
      }
      if(status=='DISCONNECTED'){
        this.alertifyService.error("MQTT CONNECTION IS:"+status.toString())
      }
            this.status.push(`Mqtt client connection status: ${status}`);
            
    });

     this.subscription = this._mqttService.observe('BARFAS').subscribe((message: IMqttMessage) => {
       this.message = message.payload.toString();
       this.unsafePublish('BARFAS/UHF00003','2424413e3eA2009AC8')
       this.alertifyService.success("Incoming message value "+message.payload.toString())
     });
   
  }

  ngOnInit() {
    //2424413e3eA2009AC8
    //2424413e3eA20F6D30
    this.unsafePublish('BARFAS/UHF00003','2424413e3eA20F6D30')
    //this.subscribeToTopic();
    this.loadVisJsScript();
    this.loadScripts();
    this.alertifyService.success(
      'Cihaz Eklemek İçin, eklemek istediğiniz cihazı sürükleyerek tabloya bırakınız.'
    );
  }

  //this function used for the load of script files
  loadScripts() {
    const dynamicScripts = [
      'http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js',
      'http://ajax.googleapis.com/ajax/libs/jqueryui/1.9.2/jquery-ui.min.js',
    ];
    for (let i = 0; i < dynamicScripts.length; i++) {
      const node = document.createElement('script');
      node.src = dynamicScripts[i];
      node.type = 'text/javascript';
      node.async = false;
      node.charset = 'utf-8';
      document.getElementsByTagName('head')[0].appendChild(node);
    }
  }

  //load the css file
  loadVisJsScript() {
    let link = document.createElement('link');
    link.type = 'stylesheet';
    link.href =
      'https://cdnjs.cloudflare.com/ajax/libs/bootstrap-modal/2.2.6/css/bootstrap-modal.css';
    document.getElementsByTagName('head')[0].appendChild(link);
  }

  myClickFunction(event) {
    //just added console.log which will display the event details in browser on click of the button.
    if (event.srcElement.id == 'ac0') {
      let tableDataid = '#' + event.srcElement.id;
      console.log(event.srcElement.id);

      this.openModal();
      $(tableDataid).on('click', function () {

      });
    }
  }
  openModal(){
    this.modalService.open(this.mymodal);
  }


   ngOnDestroy(): void {
     if (this.subscription) {
       this.subscription.unsubscribe();
     }
   }

  private subscribeToTopic() {
    this.deviceId='UHF00002'
    this.subscription = this.eventMqtt
      .topic(this.deviceId)
      .subscribe((data: IMqttMessage) => {
        let item = JSON.parse(data.payload.toString());
        console.log(item);
        debugger;
        this.events.push(item);
      });
  }

  public unsafePublish(topic: string, message: string): void {
    this._mqttService.unsafePublish(topic, message, {qos: 0, retain: false});
  }

  // public ngOnDestroy() {
  //   this.subscription.unsubscribe();
  // }
}
