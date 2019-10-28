﻿using System;
namespace LinkedList.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public Node Insert(int value)
        {
            Node newNode = new Node(value);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            return Head;
        }

        public bool Include(int value)
        {
            bool include = false;
            if(Head == null)
            {
                return include;
            }
            Node current = Head;
            while(current != null)
            {
                if(current.Value == value)
                {
                    include = true;
                }
                current = current.Next;
            }
            return include;
        }

        public string ListToString()
        {
            string list = "";
            if (Head == null)
            {
                return list;
            }
            Node current = Head;
            while (current != null)
            {
                list = list + current.Value + " ";
                current = current.Next;
            }
            return list;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
            }
        }

        public void InsertBefore(int value, int newValue)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node previous = null;
                Node current = Head;
                while (current.Value != value)
                {
                    previous = current;
                    current = current.Next;
                }
                if (previous == null)
                {
                    Head = new Node(newValue);
                }
                else
                {
                    previous.Next = new Node(newValue);
                }
            }
        }

        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Value != value)
                {
                    current = current.Next;
                }
                current.Next = new Node(newValue);
            }
        }

        public int KthFromEnd(int num)
        {
            Node current = Head;
            Node argument = null;
            int countList = 0;

            while (current.Next != null)
            {
                if (countList == num)
                {
                    argument = current;
                }
                current = current.Next;
                countList++;
            }

            if (countList != 0)
            {
                int countNum = 0;
                while (argument.Next != null)
                {
                    argument = argument.Next;
                    countNum++;
                }

                current = Head;
                for (int i = 0; i < num - countNum; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }
            return current.Value;
        }
    }
}
