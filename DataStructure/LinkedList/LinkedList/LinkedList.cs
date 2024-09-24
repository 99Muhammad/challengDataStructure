using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab7_LinkedList
{
    public class LinkedList
    {
        public Node head { get; set; }

        public static int LengthOflinkedList = 0;

        public int Count = 0;
        public bool isEmpty => Count == 0;

        public bool Includes(int data)
        {
            if (head == null)
                return false;

            Node Current = head;
            while (Current != null)
            {
                if (Current.Value == data)
                    return true;
                Current = Current.Next;
            }
            return false;
        }


        public void InsertAtBeginning(int Value)
        {
            Node Current = new Node();

            Current.Next = head;
            Current.Value = Value;
            head = Current;

            Count++;
            LengthOflinkedList++;
        }
        public void InsertAtEnd(int Value) 
        {
            Node newNode = new Node();
            newNode.Value = Value;

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
          


        }

        public void Remove(int data)
        {
            if (!Includes(data))
            {
                Console.WriteLine("This node is not exist ");
                return;
            }

            Node Prev = head;
            if (head == null)
                return;

            Node Current = head;

            if (Current.Value == data)
            {
                LengthOflinkedList--;
                head = Current.Next;
                return;
            }

            while (Current != null && Current.Value != data)
            {
                Prev = Current;
                Current = Current.Next;
            }
            if (Current == null)
                return;

            Prev.Next = Current.Next;
            LengthOflinkedList--;
        }

        public void PrintList()
        {
            Node Current = head;
            while (Current != null)
            {
                Console.Write(Current.Value + " ");
                Current = Current.Next;
            }
        }
        public void CheckIfExist(Node CurrentNode)
        {
            Node node = CurrentNode.Next;
            Node PrevNode = CurrentNode;
            while (node != null)
            {

                if (node.Value == CurrentNode.Value)
                {
                    LinkedList.LengthOflinkedList -= 1;
                    PrevNode.Next = node.Next;

                    node = node.Next;
                } else
                {
                    PrevNode = node;
                    node = node.Next;
                }

            }
        }
        public void RemoveDuplicateNode()
        {
            Node Current = head;

            while (Current != null)
            {

                CheckIfExist(Current);
                Current = Current.Next;
            }
        }
        public static Node GetSmallestNodeInAList(Node currentNode)
        {
            Node SmallestNode = currentNode;

            while (currentNode != null)
            {
                if (currentNode.Value < SmallestNode.Value)
                {
                    SmallestNode = currentNode;
                }
                currentNode = currentNode.Next;

            }
            return SmallestNode;
        }
       

        public void FillLinkedList(LinkedList List1, LinkedList List2, LinkedList MergedList)
        {
            //List1.InsertAtBeginning(5);
            //MergedList.InsertAtBeginning(5);
            //List1.InsertAtBeginning(3);
            //MergedList.InsertAtBeginning(3);
            //List1.InsertAtBeginning(1);
            //MergedList.InsertAtBeginning(1);

            //List2.InsertAtBeginning(6);
            //MergedList.InsertAtBeginning(6);
            //List2.InsertAtBeginning(4);
            //MergedList.InsertAtBeginning(4);
            //List2.InsertAtBeginning(2);
            //MergedList.InsertAtBeginning(2);

            List1.InsertAtBeginning(30);
            MergedList.InsertAtBeginning(30);
            List1.InsertAtBeginning(20);
            MergedList.InsertAtBeginning(20);
            List1.InsertAtBeginning(10);
            MergedList.InsertAtBeginning(10);

            List2.InsertAtBeginning(35);
            MergedList.InsertAtBeginning(35);
            List2.InsertAtBeginning(25);
            MergedList.InsertAtBeginning(25);
            List2.InsertAtBeginning(15);
            MergedList.InsertAtBeginning(15);
            List2.InsertAtBeginning(5);
            MergedList.InsertAtBeginning(5);

        }

        public void MergedToList(ref Node SmallestNodeInList, ref Node CurrentNode,
            LinkedList MergedList, ref Node OtherNode, LinkedList List)
        {
           
            if (SmallestNodeInList != null)
            {
                CurrentNode = CurrentNode.Next;
                MergedList.InsertAtEnd(SmallestNodeInList.Value);

                List.Remove(SmallestNodeInList.Value);

                CurrentNode = List.head;

                SmallestNodeInList = GetSmallestNodeInAList(CurrentNode);

                //To include last node 
                if (OtherNode != null && SmallestNodeInList == null)
                {
                    MergedList.InsertAtEnd(OtherNode.Value);
                }
            }

        }
        public static void SortList(LinkedList SortedList, LinkedList Sort2)
        {
            Node node = SortedList.head;
            Node smallestNode = node;
            smallestNode = GetSmallestNodeInAList(node);

            while (node != null)
            {

                node = node.Next;

                Sort2.InsertAtEnd(smallestNode.Value);
                Sort2.Count++;
                SortedList.Remove(smallestNode.Value);
                node = SortedList.head;
                smallestNode = GetSmallestNodeInAList(node);

            }
        }

        public static void MergeSortedLists(LinkedList List1,LinkedList List2,
            LinkedList MergedListBeforeSorted, LinkedList MergedListAfterSorted)
        {
 
            if (MergedListBeforeSorted.Count == 0)
            {
                Console.WriteLine("No Nodes in Lists");
                return;
            }

            SortList(MergedListBeforeSorted, MergedListAfterSorted);

            MergedListAfterSorted.PrintList();
        }

    
}
}



       

    

