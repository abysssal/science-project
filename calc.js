// To run, press F5 on your keyboard
let x = 20;
let y = 65;
let z = 234.43878;
let ans;

console.log("Here a couple variables used:");
console.log("x is 20");
console.log("y is 65");
console.log("z is 234.43878");

console.log("We are looking for approximately 7000");

console.log("Starting the calculations in JavaScript..");
console.log("x = x * 4");
x = x * 4;
console.log("x equals " + x);

console.log("x = y / 25.2842");
x = y / 25.2842;
console.log("x is " + x);

console.log("y = x * 23");
y = x * 23;
console.log("y is " + y);

console.log("y = y * z / x")
y = y * z / x;
console.log("y is " + y);

console.log("z = z * (x + 5 - 0.2432)");
z = z * (x + 5 - 0.2432);
console.log("z is " + z);

console.log("z = z + y + x");
z = z + y + x;
console.log("z is " + z);

ans = z;
console.log("Our answer is..");
console.log(ans + "!");