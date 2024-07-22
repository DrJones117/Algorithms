// A linked list is essentially an array that has been made into an object.
// Standard arrays are technicaclly fixed it's hard to insert into the middle
// but a linked list doesn't have that problem.

// A linked list cocnsists of a head, nodes, and a tail.
// A node consists of the data and to pointers: one pointing to tthe previous node and one pointing to the next node.
// The head is the node at the front of the list and has a pointer pointing to null behind it and a pointer to the next node in the list.
// The tail is the node at the end of the list and has a pointer pointing to the previous node and a pointer pointing to null in front of it.

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }
    public void DisplayNode()
    {
        Console.WriteLine(Data);
    }
}
