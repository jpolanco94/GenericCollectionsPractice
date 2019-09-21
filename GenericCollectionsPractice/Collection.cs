using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsPractice
{
    public class Collection
    {
        //Queue
        public static Queue<int> MakingQueue()
        {
            //Instantiate Queue
            Queue<int> vs = new Queue<int>();

            //Filling the queue
            foreach (int number in new int[] { 17, -3, 4, 7, 14563 })
            {
                vs.Enqueue(number);
            }
            return vs;
        }
        public static void PrintQueue(Queue<int> ts)
        {
            //Printing queue
            Console.WriteLine("Queue populated with type int");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        //Stack
        public static Stack<string> MakingStack()
        {
            //Instantiate Stack
            Stack<string> vs = new Stack<string>();

            //Filling the queue
            foreach (string phrase in new string[] { "Goodbye", "You talking to me?", "I'm walking over here", "Keep the change", "Hello" })
            {
                vs.Push(phrase);
            }
            return vs;
        }
        public static void PrintStack(Stack<string> ts)
        {
            Console.WriteLine("Stack populated with type string");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        //List
        public static List<char> MakingList()
        {
            //Instantiate List
            List<char> vs = new List<char>();

            //Filling the queue
            foreach (char character in "hello")
            {
                vs.Add(character);
            }
            return vs;
        }
        public static void PrintList(List<char> ts)
        {
            Console.WriteLine("List populated with type char");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        //LinkedList
        public static LinkedList<double> MakingLinkedList()
        {
            //Instantiate Linked list
            LinkedList<double> vs = new LinkedList<double>();

            //Filling the linked list
            foreach (double number in new double[] { 3.14, 99, .00056, -3.1456 * Math.PI, Math.Cos(99) })
            {
                vs.AddFirst(number);
            }
            return vs;
        }
        public static void PrintLinkedList(LinkedList<double> ts)
        {
            Console.WriteLine("LinkedList populated with type double");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        public static Dictionary<string, char> MakeDictionary()
        {
            Dictionary<string, char> keyValuePairs = new Dictionary<string, char>()
            {
                ["Steve"] = 'h',
                ["John"] = 'q',
                ["Bob"] = 'r',
                ["Jasmine"] = 'x',
                ["Fulano"] = 'y'
            };
            return keyValuePairs;
        }
        public static void PrintDictionary(Dictionary<string, char> keyValuePairs)
        {
            Console.WriteLine("Dictionary with a string key and a char value");
            foreach(KeyValuePair<string, char> element in keyValuePairs)
            {
                string name = element.Key;
                char randomLetter = element.Value;
                Console.WriteLine($"Key is {name} and Value is {randomLetter}" );
            }
            Console.WriteLine("\n");
        }
        public static SortedList<double, string> MakeSortedList()
        {
            SortedList<double, string> keyValuePairs = new SortedList<double, string>()
            {
                {3.14, "are" },
                {5, "you" },
                {7.6, "doing" },
                {-8, "hello" },
                {0, "how" }
            };
            return keyValuePairs;
        }
        public static void PrintSortedList(SortedList<double, string> keyValuePairs)
        {
            Console.WriteLine("Sorted list with double key and a string value");
            foreach (KeyValuePair<double, string> element in keyValuePairs)
            {
                double number = element.Key;
                string word = element.Value;
                Console.WriteLine($"Key is {number} and Value is:'{word}'");
            }
            Console.WriteLine("\n");
        }
        public static HashSet<string>  PopulatingHashTables ()
        {
            HashSet<string> wordsThatStartWithLetterR = new HashSet<string>(new string[]
            {
                "Run", "Reverse", "Repeat", "Rich", "Reaper", "Reach", "Rap"
            });
            HashSet<string> wordsThatContaintLetterE = new HashSet<string>(new string[]
            {
                "Egg", "Reverse", "Repeat", "Elephant", "Reaper", "Reach", "Moneky"
            });
            //I wanted to return the line of code below this but the result of that
            //code is a void. What this line of code does is just alter my first hash set
            wordsThatStartWithLetterR.IntersectWith(wordsThatContaintLetterE);
            return wordsThatStartWithLetterR;
        }
        public static void PrintHash(HashSet<string> vs)
        {
            Console.WriteLine("Hash set populated with strings intersected with another hash set");
            foreach (var x in vs)
            {
                Console.WriteLine(x);
            }
        }
        public static void PopulateAll()
        {
            PrintQueue(MakingQueue());
            PrintStack(MakingStack());
            PrintList(MakingList());
            PrintLinkedList(MakingLinkedList());
            PrintSortedList(MakeSortedList());
            PrintDictionary(MakeDictionary());
            PrintHash(PopulatingHashTables());
        }


    }
}
