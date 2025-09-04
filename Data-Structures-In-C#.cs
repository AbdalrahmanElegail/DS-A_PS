



            //Built-in Data Structures:

            //Array: A fixed-size collection of elements of the same type, stored contiguously in memory.
            //Code
            int[] numbers = new int[5] { 5, 2, 8, 1, 9 };
            

            //List<T>: A dynamic array that can grow or shrink in size.
            //Code
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            

            //Dictionary<TKey, TValue>: A collection of key-value pairs, optimized for fast lookups by key using a hash table.
            //Code
            Dictionary<int, string> users = new Dictionary<int, string> { { 1, "John" }, { 2, "Jane" } };
            

            //HashSet<T>: A collection of unique elements, optimized for fast membership testing.
            //Code
            HashSet<int> uniqueNumbers = new HashSet<int> { 1, 5, 2, 5, 3 }; // Contains 1, 5, 2, 3
            

            //Stack<T>: A Last - In, First - Out(LIFO) collection.
            //Code
            Stack<int> myStack = new Stack<int>();
            myStack.Push(10);
            int popped = myStack.Pop(); // popped is 10
            

            //Queue<T>: A First - In, First - Out(FIFO) collection.
            //Code
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Task A");
            string dequeued = myQueue.Dequeue(); // dequeued is "Task A"
            

            //LinkedList<T>: A doubly - linked list, allowing efficient insertion and deletion at any point.
            //Code
            LinkedList<char> chars = new LinkedList<char>();
            chars.AddLast('a');
            chars.AddFirst('b');

            //------------------------------------------------------------------------------------------------------------------


            //Sorted Versions and Implementations:

            //SortedList<TKey, TValue>: A sorted collection of key - value pairs
            //                                                  , sorted by key.It combines features of a List and a Dictionary.
            //Code
            SortedList<int, string> sortedUsers = new SortedList<int, string>();
            sortedUsers.Add(3, "David");
            sortedUsers.Add(1, "Alice"); // Elements are automatically sorted by key
            

            //SortedDictionary<TKey, TValue>: A sorted collection of key - value pairs
            //                                            , sorted by key using a binary search tree(red-black tree) internally.
            //Code
            SortedDictionary<string, int> sortedScores = new SortedDictionary<string, int>();
            sortedScores.Add("Bob", 90);
            sortedScores.Add("Alice", 95); // Elements are automatically sorted by key
            

            //SortedSet<T>: A collection of unique elements sorted in ascending order.
            //Code
            SortedSet<int> sortedUniqueNumbers = new SortedSet<int>();
            sortedUniqueNumbers.Add(5);
            sortedUniqueNumbers.Add(1);
            sortedUniqueNumbers.Add(3); // Contains 1, 3, 5

            //------------------------------------------------------------------------------------------------------------------


            //Sorting Existing Collections:
            //Many non-sorted collections can be sorted using built-in methods or LINQ.

            //List<T>.Sort(): Sorts the elements of the List<T> in place.
            //Code
            List<int> unsortedList = new List<int> { 5, 2, 8, 1 };
            unsortedList.Sort(); // unsortedList is now {1, 2, 5, 8}
            

            //LINQ's OrderBy() and OrderByDescending(): Creates a new sorted sequence without modifying the original collection.
            //Code
            int[] unsortedArray = { 5, 2, 8, 1 };
            var sortedArray = unsortedArray.OrderBy(x => x).ToArray(); // sortedArray is {1, 2, 5, 8}

            //------------------------------------------------------------------------------------------------------------------