// THis is correct, but very slow for the higher numbers in the sequence.
// It's not very efficient.

const fib = (n) => {
    if (n <= 2) {
        return 1;
    }
    return fib(n - 1) + fib (n - 2);
}

console.log(fib(6))
console.log(fib(7))
console.log(fib(8))
console.log(fib(50))