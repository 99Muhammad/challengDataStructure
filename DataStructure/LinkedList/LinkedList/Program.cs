namespace lab7_LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();

            linked.InsertAtBeginning(1);
            linked.InsertAtBeginning(2);
            linked.InsertAtBeginning(3);
            linked.InsertAtBeginning(4);

            Console.WriteLine("The content of linked list : ");
            linked.PrintList();
            Console.WriteLine("\nShow Include Function when search about not founded data ");
            int value = 10;

            if (linked.Includes(value))
            {
                Console.WriteLine($"The value {value} is exist");
            }
            else
            {
                Console.WriteLine($"The value {value} is NOT exist");
            }

            value = 2;

            Console.WriteLine("\nShow Include Function when search about founded data ");

            if (linked.Includes(2))
            {
                Console.WriteLine($"The value {value} is exist");
            }
            else
            {
                Console.WriteLine($"The value {value} is NOT exist");

            }
            Console.WriteLine("\nShow Remove Function when remove an element ");
            
            linked.Remove(1);

            Console.WriteLine("The content of linked list after implement Remove Function: ");
            linked.PrintList();
            Console.WriteLine();
          

        }
    }
}
