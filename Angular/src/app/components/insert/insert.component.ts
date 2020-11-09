import { Component, OnInit } from '@angular/core';
import { UtilsService } from '../../services/utils.service'
@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.css']
})
export class InsertComponent implements OnInit {
  insert = {
    businessEntityID: 0,
    phoneNumber:"",
    phoneNumberTypeID:0
  };
  submitted = false;
  constructor(private UtilsService : UtilsService) { }

  save() {
    const data = {
      businessEntityID: this.insert.businessEntityID,
      phoneNumber: this.insert.phoneNumber,
      phoneNumberTypeID: this.insert.phoneNumberTypeID,
    };

    this.UtilsService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
        });
  }
  newTutorial() {
    this.submitted = false;
    this.insert = {
      businessEntityID: 0,
      phoneNumber:"",
      phoneNumberTypeID:0
    };
  }
  ngOnInit(): void {
  }

}
