let newList = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];

// binary search
function binary_search(list, item)
{
    /// Low and high keep track of which part of the list we'll search in.
    let low = 0;
    let high = list.length - 1;


    // While you haven't narrowed it down to one number.
    while (low <= high) 
    {
        // Calculates the middle and sets our guess to it.
        let mid = Math.floor((low + high) / 2);
        let guess = list[mid];

        // If our guess was right we return the number.
        if (guess == item)
        {
            return list[mid];
        }
        // If the guess was high we set our new high point to the middle of the array minus 1 (We set middle minus 1 since we've already checked it and won't need to again)
        else if (guess > item)
        {
            high = mid - 1;
        }
        // If the guess was too low we set the low point to the middle plus 1.
        else
        {
            low = mid + 1;
        }
    }

    // If we got to this point we know the number doesn't exist.
    return null;
}

console.log("Found: ", binary_search(newList, 20))
console.log("Found: ",binary_search(newList, 7))
console.log("Found: ",binary_search(newList, 42))
console.log("Found: ",binary_search(newList, -1))