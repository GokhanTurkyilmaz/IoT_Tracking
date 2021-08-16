import { TemplateRef, ViewChild } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap'

@Component({
  selector: 'app-deviceSettingModal',
  templateUrl: './deviceSettingModal.component.html',
  styleUrls: ['./deviceSettingModal.component.css'],
 
})
export class DeviceSettingModalComponent implements OnInit {
  closeResult = '';
  @ViewChild('content') content : TemplateRef<any>
  constructor(private modalService: NgbModal) {}
  
  openModal(){
    this.modalService.open(this.content);
  }

  open(content) {
    this.modalService.open(content);
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

  ngOnInit() {

  }
}
