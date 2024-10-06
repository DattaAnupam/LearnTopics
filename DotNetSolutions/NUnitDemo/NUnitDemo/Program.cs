using NUnitDemo;
using NUnitDemo.Interfaces;

IUtilities utilities = new Utilities();

ICalculator calculater = new Calculator(utilities);
var total = calculater.GetSum(1, 2);
