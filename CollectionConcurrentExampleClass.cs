using System;
using System.Collections.Concurrent;

namespace CollectionsExamples
{
    /// <summary>
    /// Class to implement Concurrent Collections
    /// </summary>
    class CollectionConcurrentExamplesClass
    {
        BlockingCollection<int> blockingcollection;
        ConcurrentDictionary<int, string> dictionary;
        ConcurrentStack<int> stack;
        ConcurrentQueue<int> queue;
        ConcurrentBag<int> concurrentbag;
        CollectionConcurrentExamplesClass()
        {
            blockingcollection = new BlockingCollection<int>(8);
            dictionary = new ConcurrentDictionary<int, string>();
            stack = new ConcurrentStack<int>();
            queue = new ConcurrentQueue<int>();
            concurrentbag = new ConcurrentBag<int>();
        }
        /// <summary>
        /// Method to perform BlockingCollection Operations
        /// </summary>
        public void BlockingCollectionsOperations()
        {
            Console.WriteLine("Blocking_Collections_Operations");
            blockingcollection.Add(1);
            blockingcollection.Add(2);
            blockingcollection.Add(3);
            blockingcollection.Add(4);
            blockingcollection.Add(5);
            blockingcollection.Add(6);
            blockingcollection.CompleteAdding();
            Console.WriteLine("The elements added:");
            foreach (int x in blockingcollection)
            {
                Console.WriteLine(x);
            }
            int item = blockingcollection.Take();
            Console.WriteLine("The number deleted is " + item);
            Console.WriteLine("Remaining elements:");
            foreach (int x in blockingcollection)
            {
                Console.WriteLine(x);
            }
        }
        /// <summary>
        /// Method to perform Concurrent Dictionary Operations
        /// </summary>
        public void Concurrent_dictionary_Operations()
        {
            Console.WriteLine("Concurrent_Dictionary_Operations");
            string x;
            dictionary.TryAdd(1, "one");
            dictionary.TryAdd(2, "two");
            dictionary.TryAdd(3, "three");
            dictionary.TryAdd(4, "four");
            dictionary.TryAdd(5, "five");
            foreach (var i in dictionary)
            {
                Console.WriteLine(i.Key + ":" + i.Value);
            }
            //The contains key check whether it has a key or not
            Console.WriteLine("This has a key 2 in it:" + dictionary.ContainsKey(2));
            dictionary.TryRemove(3, out x);
            Console.WriteLine("The deleted value is " + x);
            Console.WriteLine("Remaining elements:");
            foreach (var i in dictionary)
            {
                Console.WriteLine(i.Key + ":" + i.Value);
            }
        }
        /// <summary>
        /// Method to perform Concurrent Stack Operations
        /// </summary>
        public void Concurrent_Stack_Operations()
        {
            Console.WriteLine("Concurrent_Stack_Operations");
            int y;
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.TryPop(out y);
            Console.WriteLine("The poped value is " + y);
            int[] i = { 6, 7, 8 };
            stack.PushRange(i);
           
            int count = stack.Count;
            Console.WriteLine("The number of elements in stack :" + count);
            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }
        }
        /// <summary>
        /// Method to perform Concurrent Queue Operations
        /// </summary>
        public void Concurrent_Queue_Operations()
        {
            Console.WriteLine("Concurrent_Queue_Operations");
            int y;
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            
            queue.TryDequeue(out y);
            Console.WriteLine("The Dequeued value is " + y);
            int count = queue.Count;
            Console.WriteLine("The number of elements in queue :" + count);
            foreach (int x in queue)
            {
                Console.WriteLine(x);
            }
        }
        /// <summary>
        /// Method to perform Concurrent Bag Operations
        /// </summary>
        public void Concurrent_Bag_Operations()
        {
            Console.WriteLine("Concurrent_Bag_Operations");
            int y;
            concurrentbag.Add(54);
            concurrentbag.Add(45);
            concurrentbag.Add(90);
            concurrentbag.Add(75);
            concurrentbag.Add(90);
           
            concurrentbag.TryTake(out y);
            Console.WriteLine("The Deleted value is " + y);
            int count = concurrentbag.Count;
            Console.WriteLine("The total number of elements in bag :" + count);
            foreach (int x in concurrentbag)
            {
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            CollectionConcurrentExamplesClass obj = new CollectionConcurrentExamplesClass();
            obj.Concurrent_Bag_Operations();
            obj.Concurrent_dictionary_Operations();
            obj.BlockingCollectionsOperations();
            obj.Concurrent_Queue_Operations();
            obj.Concurrent_Stack_Operations();
            
        }
    }
}
