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

            #region HashSets
            Console.WriteLine();
            Console.WriteLine("A HashSet is a collection of unique elements. It doesn’t allow duplicate values.");
            var hashSet = new HashSet<int>();
            hashSet.Add(10);
            hashSet.Add(10);
            hashSet.Add(109);
            hashSet.Add(100);
            hashSet.Add(104);
            hashSet.Add(10);
            hashSet.Add(150);
            hashSet.Add(150);
            hashSet.Add(67);
            hashSet.Add(10);
            hashSet.Add(10);
            hashSet.Add(10);
            hashSet.Add(100);
            hashSet.Add(104);
            hashSet.Add(10);
            hashSet.Add(150);
            hashSet.Add(150);
            hashSet.Add(67);

            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }

            hashSet.Remove(100);
            Console.WriteLine("Removed 100");
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Contains 10?");
            Console.WriteLine(hashSet.Contains(10));

            #endregion

            #region Dictionary
            Console.WriteLine();
            Console.WriteLine("A Dictionary is a collection of key/value pairs similar to a Hashtable, but it is strongly typed and generic.");

            var dictionary = new Dictionary<int, string>();
            dictionary.Add(3, "Three");
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(31, "ThreeOne");
            dictionary.Add(12, "Twelve");
            dictionary.Add(100, "OneHundred");
            Console.WriteLine();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            dictionary.Remove(12);
            Console.WriteLine("Removed 12");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("dictionary.ContainsKey(100)");
            Console.WriteLine(dictionary.ContainsKey(100));
            Console.WriteLine("dictionary[100])");
            Console.WriteLine(dictionary[100]);
            #endregion
        }
    }
}
