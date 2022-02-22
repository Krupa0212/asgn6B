// See https://aka.ms/new-console-template for more information



using System;
using System.Collections.Generic;
using System.Text;
namespace Prog6B2
{
    class SelectionSort
    {
        static public void Sort<T>(IList<T> sortArray, Func<T, T, bool>
       comparision)
        {
            for (int i = 0; i < sortArray.Count - 1; i++)
            {
                int key = i;
                for (int j = i + 1; j < sortArray.Count; j++)
                {
                    // find minimum element
                    if (comparision(sortArray[j], sortArray[key]))
                    {
                        key = j;
                    }
                }

                // swap the smallest element
                T temp = sortArray[i];
                sortArray[i] = sortArray[key];
                sortArray[key] = temp;
            }
        }
    }

    public enum TypeOfCake
    {
        Threelayercake = 5,
        Twolayercake = 4,
        Normalcake = 3,
        Pastry = 2,
        PieceCake = 1
    }
    class Cake
    {
        int cakeId;
        public float price;
        public string name;
        public TypeOfCake typeofCake;
        public Cake(int CakeId, float Price, string Name, TypeOfCake
       tpofcake)
        {
            this.cakeId = CakeId;
            this.price = Price;
            this.name = Name;
            this.typeofCake = tpofcake;
        }
        internal static bool ComparePrice(Cake c1, Cake c2)
        {
            return c1.price < c2.price;
        }
        internal static bool CompareName(Cake c1, Cake c2)
        {
            if (c1.name.CompareTo(c2.name) == 1)
            {
                // Console.WriteLine(c1.name.CompareTo(c2.name));
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static bool CompareTypeOfCake(Cake c1, Cake c2)
        {
            return c1.typeofCake < c2.typeofCake;
        }
    }

    public class TestGenericMethods
    {
        public static void Main(string[] args)
        {
            List<Cake> cakes = new List<Cake>(15);
            cakes.Add(new Cake(5, 1750, "Brown Chocolate",
           TypeOfCake.Threelayercake));
            cakes.Add(new Cake(3, 1450, "Red Velvet",
           TypeOfCake.Twolayercake));
            cakes.Add(new Cake(4, 2100, "Pineapple",
           TypeOfCake.Normalcake));
            cakes.Add(new Cake(1, 250, "Anglebyte",
           TypeOfCake.PieceCake));

            //sorting according to Name of Cakes
            Console.WriteLine("\nCakes according to Names : ");
            SelectionSort.Sort<Cake>(cakes, Cake.CompareName);
            cakes.Reverse();
            foreach (Cake c1 in cakes)
            {
                Console.WriteLine(c1.name);
            }
            //sorting according to TypeOFCake
            Console.WriteLine("\nCakes according to TypeOfCake : ");
            SelectionSort.Sort<Cake>(cakes, Cake.CompareTypeOfCake);
            foreach (Cake c1 in cakes)
            {
                Console.WriteLine($"{c1.name}   |     {c1.typeofCake}");
            }
            Console.WriteLine("\nSorted array according to price of cakes :  ");

            SelectionSort.Sort<Cake>(cakes, Cake.ComparePrice);
            foreach (Cake c1 in cakes)
            {
                Console.WriteLine($"{c1.name} :- Rs {c1.price}/-");
            }
        }
    }
}