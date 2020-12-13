import { Component, OnInit } from '@angular/core';
import { ServerService, Order, FinalResult, Summary } from '../server.service';
import { NgModule } from '@angular/core';


@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {

  data: FinalResult;
  sumCost; //The sum of all orders
  avgCost; //Average of order amounts

  constructor(private server: ServerService) {
  }

  ngOnInit() {
    this.server.getAllOrders().subscribe(
      result => {
        this.data = result;
        this.calculate();
      });
  }

  calculate() {
    this.sumCost = 0;
    this.data.orderList.forEach(o => { this.sumCost += +o.shippingCost });

    this.avgCost = this.sumCost / this.data.orderList.length;
  }

  setNameEditable(order) {
    order.nameInEdit = true;
  }

  setNameUneditable(order) {
    order.nameInEdit = false;
  }

  setCostEditable(order) {
    order.costInEdit = true;
  }

  setCostUneditable(order) {
    if (order.shippingCost < 0)
      order.shippingCost = 0;
    else if (order.shippingCost > 99)
      order.shippingCost = 99;

    order.costInEdit = false;
    this.calculate();
  }
}
