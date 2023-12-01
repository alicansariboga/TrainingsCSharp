using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Project12.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            products.Add("Item1");
            products.Add("Item2");
            products.Add("Item3");
            products.Add("Item4");
            products.Add("Item5");

            //Console.WriteLine(products[2]);
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("Toplam urun sayisi : " + products.Count); //5
            products[4] = "Itemx";
            Console.WriteLine(products[4]);

            MyList<string> products2 = new MyList<string>();
            products2.Add("Product1");
            products2.Add("Product2");
            products2.Add("Product3");
            products2.Add("Product4");
            products2.Add("Product5");
            products2.Add("Product6");
            products2[2] = "Productsx";
            Console.WriteLine(products2.Count);
            Console.WriteLine(products2[2]);
            Console.WriteLine(products2[3]); //in here, everything is okay but, it is[3] empty. The new list does not recognize the old list. So, there is not a memory. For this; I should add a temp for the array.

        }
        public class MyList<T>
        {
            private T[] _items;
            private T[] _tempItems; // temp array for the recognize the old array.
            public MyList()
            {
                _items = new T[0];
            }

            public int Count { get { return _items.Length; } }

            public void Add(T item)
            {
                _tempItems = _items;
                _items = new T[_items.Length + 1];
                for (int i = 0; i < _tempItems.Length; i++)
                {
                    _items[i] = _tempItems[i];
                }
                _items[_items.Length - 1] = item; //added new item to list.
            }
            public T this[int index] 
            {
                get
                {
                    return _items[index];
                }
                set
                {
                    _items[index] = value;
                } 
            }
        }
    }
}
