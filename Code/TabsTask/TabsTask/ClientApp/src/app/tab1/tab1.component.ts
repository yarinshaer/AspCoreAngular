import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-tab1',
  templateUrl: './tab1.component.html',
  styleUrls: ['./tab1.component.css']
})
export class Tab1Component implements OnInit {

  response: any;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.response = [];
    http.get<any>(baseUrl + 'weatherforecast').subscribe(result => {
      this.response = result;
      console.log(this.response);
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}
