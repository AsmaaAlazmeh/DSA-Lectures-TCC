using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
           
            if (First == null)
            {
                Node newnode = new Node(val);
                newnode.Data = val;              
                First = newnode;                
            }
            Node move = First;
            while (move.Next!=null)
            {
                move = move.Next;
            }
            Node new_node = new Node(val);
            new_node.Data = val;
            move.Next = new_node;
            move = new_node;
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            Node move = First;
            while (move.Next.Data!=key)
            {
                move = move.Next;
            }
            move = move.Next.Next;
            
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            Node move = this.First;
            while (move.Next!=null)
            {
                move = move.Next;
            }
            move.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            if (First==null || First.Next==null)
            {
                return;
            }
            Node prev = null, curr = First, next = null;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            First = prev;
        }
    }
}
