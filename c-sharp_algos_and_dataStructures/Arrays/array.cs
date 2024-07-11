// Arrays can contain anything, are fixed in size, and are useful for their GET and SET features.
// Lists are arrays in C#

// ==================================================================

// How to insert at the end of an array.

// Create the array.
int[] intArray = new int[6];

// Make a variable to keep track of the length.
int length = 0;

// Adds data for us.
for (int i = 0; i < 8; i++)
{
    intArray[length] = i + 1;
    length++;
}

// Insert the data at the end.
intArray[length] = 8;
length++;

// ==================================================================

// How to insert at the start of the array.

for(int i = 3; i >= 0; i--)
{
    // This is rotates the values in the array.
    intArray[i + 1] = intArray[i];
}

intArray[0] = 20;

// ==================================================================

// How to insert anywhere in the array.

for (int i = 4; i >= 2; i--)
{
    // Were going to shift the values to the right of the index we are inserting the data in.
    intArray[i + 1] = intArray[i];
}

intArray[2] = 8;