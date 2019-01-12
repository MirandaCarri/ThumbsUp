import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
registerMode = false;
// values: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    // this.getValues();
  }

  registerToggle() {
    this.registerMode = true;
  }

  // getValues() { // makes an http request from angular to fetch data from api
  //   this.http.get('http://localhost:5000/api/values').subscribe(response => {
  //     this.values = response; // the response will be return in this.values
  //   }, error => {
  //     console.log(error);
  //   });
  // }

  cancelRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

}
