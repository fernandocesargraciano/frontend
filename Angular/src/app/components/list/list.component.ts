import { Component, OnInit } from '@angular/core';
import { UtilsService } from '../../services/utils.service'


@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  list:any;
  current = null;
  currentIndex = -1;


  constructor(private UtilsService : UtilsService) { }

  ngOnInit(): void {
    this.retrieve()
  }

  retrieve() {
    this.UtilsService.getAll()
      .subscribe(
        data => {
          this.list = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
  refreshList() {
    this.retrieve();
    this.current = null;
    this.currentIndex = -1;
  }

}
