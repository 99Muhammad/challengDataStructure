namespace lab7_LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList MergedListBeforeSorted = new LinkedList();
            LinkedList MergedListAfterSorted = new LinkedList();

           
            LinkedList linked1 = new LinkedList();
            LinkedList linked2 = new LinkedList();
            LinkedList linked = new LinkedList();

            linked.FillLinkedList(linked1, linked2, MergedListBeforeSorted);
            
            LinkedList.MergeSortedLists(linked1, linked2, MergedListBeforeSorted, MergedListAfterSorted);

            //  linked.MergeSortedLists();
            //linked.InsertAtBeginning(10);
            //linked.InsertAtBeginning(5);
            //linked.InsertAtBeginning(10);
            //linked.InsertAtBeginning(20);
            //linked.InsertAtBeginning(20);
            //linked.InsertAtBeginning(5);


            //linked.InsertAtBeginning(7);
            //linked.InsertAtBeginning(7);
            //linked.InsertAtBeginning(7);
            //linked.InsertAtBeginning(7);

            //linked.InsertAtBeginning(1);
            //linked.InsertAtBeginning(7);
            //linked.InsertAtBeginning(8);
            //linked.InsertAtBeginning(5);



            // Console.WriteLine("Linked List Before Remove duplicate\n");
            // linked.PrintList();

            //// Console.WriteLine("The content of linked list : ");
            // linked.RemoveDuplicateNode();
            // Console.WriteLine("\ninked List After Remove duplicate");
            // linked.PrintList();

            //Console.WriteLine("\nShow Include Function when search about not founded data ");
            //int value = 10;

            //if (linked.Includes(value))
            //{
            //    Console.WriteLine($"The value {value} is exist");
            //}
            //else
            //{
            //    Console.WriteLine($"The value {value} is NOT exist");
            //}

            //value = 2;

            //Console.WriteLine("\nShow Include Function when search about founded data ");

            //if (linked.Includes(2))
            //{
            //    Console.WriteLine($"The value {value} is exist");
            //}
            //else
            //{
            //    Console.WriteLine($"The value {value} is NOT exist");

            //}
            //Console.WriteLine("\nShow Remove Function when remove an element ");

            //linked.Remove(1);

            //Console.WriteLine("The content of linked list after implement Remove Function: ");
            //linked.PrintList();
            //Console.WriteLine();


        }
    }
}
