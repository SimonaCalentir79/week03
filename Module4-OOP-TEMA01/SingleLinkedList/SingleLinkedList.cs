using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class SingleLinkedList
    {
        private Node First;

        public Node AddFirst(int value)
        {
            Node node = new Node();
            node.Value = value;
            node.Next = null;

            First = node;

            return node;
        }
        public Node AddAfter(Node node, int val)
        {
            Node newNode = new Node();
            newNode.Value = val;
            node.Next = newNode;

            return newNode;
        }

        public bool DedectCycle()
        {
            bool esteCiclic = false;
            Node currentNode = First;

            List<Node> listaNoduri = new List<Node>();

            while (currentNode != null)
            {
                listaNoduri.Add(currentNode);
                if (listaNoduri.Contains(currentNode.Next))
                {
                    esteCiclic = true;
                    break;
                }
                else
                {
                    currentNode = currentNode.Next;
                    esteCiclic = false;
                }
            }
            return esteCiclic;
        }

        public void Print()
        {
            Node currentNode = First;

            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");

                currentNode = currentNode.Next;
            }
        }

    }
}
