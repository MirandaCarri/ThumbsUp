import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
values: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues(); // this loads whenn page loads
  }

  getValues() { // makes an http request from angular to fetch data from api
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.values = response; // the response will be return in this.values
    }, error => {
      console.log(error);
    });
  }

}
