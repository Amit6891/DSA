namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            Console.WriteLine("--------------Arrays----------");

            var intArray = new int[] { 4, 7, 9, 1, 2, 3, 4, 5 };
            int[] intArray2 = { 6, 7, 8, 9, 2, 5, 6 };
            Console.WriteLine("Print Array");
            foreach (var item in intArray)
            {
                Console.Write(item + ", ");
            }

            Array.Sort(intArray);
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            foreach (var item in intArray)
            {
                Console.Write(item + ", ");
            }

            Array.Reverse(intArray);
            Console.WriteLine();
            Console.WriteLine("Reverse Sort Array");
            foreach (var item in intArray)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("INdex of number 4");
            Console.WriteLine(Array.IndexOf(intArray, 4));

            Console.WriteLine();

            #endregion

            #region Linked List

            Console.WriteLine("--------------Linked List----------");

            // Create a linked list
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            list.PrintList();  // Output: 10 -> 20 -> 30 -> null

            list.AddFirst(5);
            list.PrintList();  // Output: 5 -> 10 -> 20 -> 30 -> null

            list.Remove(20);
            list.PrintList();  // Output: 5 -> 10 -> 30 -> null

            Node<int> foundNode = list.Find(10);
            Console.WriteLine(foundNode != null ? "Found" : "Not Found");  // Output: Found

            Console.WriteLine("Size: " + list.Size());  // Output: Size: 3
            Console.WriteLine("Is Empty: " + list.IsEmpty());  // Output: Is Empty: False

            #endregion
        }
    }
}
