using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepingSort_LinkedList_In_InsertionTime
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
    }

    public class NodeComparer
    {
        Node head = null;

        public bool IsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Insert(int value)
        {
            if (IsNull())
            {
                Node newnode = new Node();
                newnode.value = value;
                head = newnode;
            }
            else
            {
                Node newnode = new Node();
                newnode.value = value;

                Node tempHead = head;

                if (tempHead.next == null)
                {
                    if (tempHead.value > newnode.value)
                    {
                        tempHead.prev = newnode;
                        newnode.next = tempHead;
                        head = newnode;
                        return;
                    }
                    else
                    {
                        tempHead.next = newnode;
                        newnode.prev = tempHead;
                    }
                }

                while (tempHead.next != null)
                {
                    if (tempHead.value > newnode.value)
                    {
                        if (tempHead.prev == null)
                        {
                            tempHead.prev = newnode;
                            newnode.next = tempHead;
                            head = newnode;
                            return;
                        }
                        else
                        {
                            newnode.prev = tempHead.prev;
                            tempHead.prev.next = newnode;
                            newnode.next = tempHead;
                            tempHead.prev = newnode;
                            return;
                        }
                    }
                    tempHead = tempHead.next;
                }

                if (tempHead.value > newnode.value)
                {
                    newnode.prev = tempHead.prev;
                    tempHead.prev = newnode;
                    newnode.next = tempHead;
                    tempHead.next = null;
                }
                else
                {
                    tempHead.next = newnode;
                    newnode.prev = tempHead;
                }

            }
        }

        public void Print()
        {
            if (!IsNull())
            {
                var te = head;
                while (te != null)
                {
                    Console.WriteLine(te.value);
                    te = te.next;
                }
            }
        }
    }

}
