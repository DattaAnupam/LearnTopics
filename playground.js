"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
let fortuner = {
    make: 'Toyota',
    color: 'black',
    price: 3400000,
    isAvailable: true
};
// object destructureing
let { make: maker, price } = fortuner;
console.log(`Make: ${maker} Cost: ${price}`);
