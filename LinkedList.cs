namespace DSA
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T data)
        {
            var newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var currentNode = Head;
                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }

        public Node<T> Find(T data)
        {
            var currentNode = Head;
            while(currentNode != null)
            {
                if (currentNode.Data.Equals(data))
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }

        public int Size()
        {
            var count = 0;
            var currentNode = Head;
            while(currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }
            return count;
        }

        public void PrintList()
        {
            var currentNode = Head;
            while(currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }

        public void RemoveFirst()
        {
            Head = Head.Next;
        }

        public void Remove(T data)
        {
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                return;
            }
            var currentNode = Head;
            while(currentNode.Next != null)
            {
                if (currentNode.Next.Data.Equals(data))
                {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }
                currentNode = currentNode.Next;
            }
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}
