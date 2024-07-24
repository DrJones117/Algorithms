// Here is the easiest way to do it. Not very clever and won't be seen as good in an interview.

// Here we create our string.
let string1 = "First Method";

function reverseString1 (string1)
{
    return string1.split("").reverse().join("");
}

console.log(reverseString1(string1));

// Here is the second way to do it. 

let string2 = "Second method"

function reverseString2 (string)
{
    let reversed = "";

    for (const c of string)
    {
        reversed = c + reversed;
    }

    return reversed;
}

console.log(reverseString2(string2));

// Here is the third method

let string3 = "Third method"

function reverseString3 (string3)
{
    return Array.from(string3).reduce((reversed, c) => c + reversed, "");
}

console.log(reverseString3(string3));

// Here a fourth and unique method.

let string4 = "Fourth method";

function reverseString4 (string4) 
{
    let chars = string4.split("");
    let left = 0;
    let right = string4.length - 1;

    while (left < right)
    {
        let temp = chars[right];

        chars[right] = chars[left];

        chars[left] = temp;
        
        left++
        right--
    }
    return chars.join("");
}

console.log(reverseString4(string4));