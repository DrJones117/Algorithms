// Linear Search
// Linear Search starts at the beginning of an array and looks at each value until it finds the one it needs.

using Internal;

int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// The key is what value we are searching for.
bool LinearSearch(int[] array, int key)
{
    for (int i = 0; i < array; i++)
    {
        if(array[i] == key)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(LinearSearch(array, 10));