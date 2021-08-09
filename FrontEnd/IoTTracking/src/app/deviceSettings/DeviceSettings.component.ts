import { Component, OnInit,HostListener } from '@angular/core';
import { TestBed } from '@angular/core/testing';
import { AlertifyService } from '../services/alertify.service';
import * as _ from 'lodash';

declare var $: any;
declare var test: any;
declare var Redips :any;


// var url = '../../../externalLibrary/header.js';
var url = 'C:\Users\Gokhan\header.js';
@Component({
  selector: 'app-DeviceSettings',
  templateUrl: './DeviceSettings.component.html',
  styleUrls: ['./DeviceSettings.component.css']
})



export class DeviceSettingsComponent implements OnInit {

  constructor(private alertifyService:AlertifyService) {
    
   }
   loadAPI: Promise<any>;
  ngOnInit() {
  // Redips();
  // test();
   this.loadAPI = new Promise((resolve) => {
    console.log('resolving promise...');
    this.loadScript();
});
    this.alertifyService.success("Cihaz Eklemek İçin, eklemek istediğiniz cihazı sürükleyerek tabloya bırakınız.")

  }
   loadScript() {
    console.log('preparing to load...')
    let node = document.createElement('script');
    node.src = url;
    node.type = 'text/javascript';
    node.async = true;
    node.charset = 'utf-8';
    document.getElementsByTagName('head')[0].appendChild(node);
}
  


  @HostListener("click") onClick(){
    $("ac0").click(function(){
      this.alertify.success("Tıklandı");
    })
    console.log("User Click using Host Listener")
  }
}
