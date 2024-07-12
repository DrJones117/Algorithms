// Arrays can contain anything, are fixed in size, and are useful for their GET and SET features.
// Lists are arrays in C#

// ==================================================================

// How to insert at the end of an array.

// Create the array.
using System.Security.Principal;

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

// ==================================================================

// How to Delete from the end of an array.

int[] delIntArray = new int[9];

int length = 0;

for(int i = 0; i < 6; i++)
{
    delIntArray[length] = i;
    length++;
}

// Here we reduce the length of the array effectivly deleting the last item.
// length--;

// ==================================================================

// How to delete from the begining of the array.
for(int i = 1; i<length; i++)
{
    delIntArray[i - 1] = delIntArray[i];
}

// We still reduce the length of the array because we have one item fewer.
// length--;

// ==================================================================

// How to delete an item in the middle of the array.

// The second number of the array gets deleted. ==> "int i = 2;"
for(int i = 2; i < length; i++)
{
    delIntArray[i - 1] = delIntArray[i];
}

// Reduce the length.
length--;


// ==================================================================

// Print the arraay.
for(int i = 0; i < length; i++)
{
    Console.WriteLine(delIntArray[i]);
}

// ==================================================================

