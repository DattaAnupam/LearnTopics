﻿using System;

static int Sum(int num1, int num2) => num1 + num2;

// Declare Func with two parameters
Func<int, int, int> add = Sum;

// Use Func
Console.WriteLine($"Sum of two numbers: {add(4, 5)}");