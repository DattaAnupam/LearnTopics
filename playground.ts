import { Car } from './Car';

let fortuner: Car = {
    make: 'Toyota',
    color: 'black',
    price: 3400000,
    isAvailable: true
}

// object destructureing
let { make, price } = fortuner

console.log(`Make: ${make} Cost: ${price}`)
