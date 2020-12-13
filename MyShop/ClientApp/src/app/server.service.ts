import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class ServerService {
  public baseUrl: string;

  constructor(private http: HttpClient) {
    this.baseUrl = this.getBaseUrl();
  }

  getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
  }

  getAllOrders(): Observable<FinalResult> {
    return this.http.get<FinalResult>(this.baseUrl + 'api/Shop/AllOrders');
  }

}

export class Order {
  orderID: number;
  companyName: string;
  address: string;
  city: string;
  region: string;
  shippingCost: number;
}

export class Summary {
  orderCount: number;
  sumShippingCost: number;
  avargeShippingCost: number;
}

export class FinalResult {
  orderList: Order[];
  summary: Summary;
}
