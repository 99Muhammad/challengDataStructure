using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab7_LinkedList
{
    public class LinkedList
    {
        public Node head;
        public static int LengthOflinkedList = 0;

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

            LengthOflinkedList++;
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
            Node node=CurrentNode.Next;
            Node PrevNode = CurrentNode;
            while (node != null)
            {

                if (node.Value == CurrentNode.Value)
                {
                    LinkedList.LengthOflinkedList-=1;
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

            while(Current!=null)
            {
                
                CheckIfExist(Current);
                Current = Current.Next;
            }
        }
    }
}
