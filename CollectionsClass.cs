using System;
using System.Collections;

namespace Collections
{
    /// <summary>
    /// Class to implement Collections
    /// </summary>
    class CollectionsClass
    {
        ArrayList arrayList;
        Hashtable hashtable;
        Stack stack;
        Queue queue;
        CollectionsClass()
        {
            arrayList = new ArrayList();
            hashtable = new Hashtable();
            stack = new Stack();
            queue = new Queue();
        }
        /// <summary>
        /// Method to perform Array List Operations
        /// </summary>
        public void ArrayList_Operations()
        {
            Console.WriteLine("ArrayList_Operations");
            arrayList.Add(189);
            arrayList.Clear();
            arrayList.Add(1.9);
            arrayList.Add("sree");
            arrayList.Add(false);
            arrayList.AddRange(arrayList);
            Console.WriteLine("Number of Elements in ArrayList");
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(" Elements in ArrayList");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Index of sree= " + arrayList.IndexOf("sree"));
        }
        /// <summary>
        /// Method to perform hash table Operations
        /// </summary>
        public void hashTable_Operations()
        {
           
            hashtable.Add(1, "a");
            hashtable.Add(2, "b");
            hashtable.Add(3, "c");
            hashtable.Add(4, "d");
            Console.WriteLine("Number of Elements in  hashtable");
            Console.WriteLine(hashtable.Count);
            Console.WriteLine(" Elements in  hashtable");
            foreach (DictionaryEntry i in hashtable)
            {
                Console.WriteLine(i.Key + " -" + i.Value);
            }
        }
        /// <summary>
        /// Method to perform Stack Operations
        /// </summary>
        public void stack_Operations()
        {
          
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Top element of stack" + stack.Peek());
            stack.Pop();
            Console.WriteLine("Number of Elements in  Stack");
            Console.WriteLine(stack.Count);
            Console.WriteLine(" Elements in  Stack");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Method to perform Queue Operations
        /// </summary>
        public void queue_Operations()
        {
            Console.WriteLine("queue_Operations");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("Top element of queue" + queue.Peek());
            queue.Dequeue();
            Console.WriteLine("Number of Elements in  Queue");
            Console.WriteLine(queue.Count);
            Console.WriteLine(" Elements in Queue");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            CollectionsClass obj = new CollectionsClass();
            obj.hashTable_Operations();
            obj.queue_Operations();
            obj.stack_Operations();
            obj.ArrayList_Operations();
            

        }
    }
}
