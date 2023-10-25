using System.Runtime.InteropServices;

namespace Generics
{
    public class Tal<T>
    {
        private T[] arr;
        private int i;

        public Tal(int size)
        {
            arr=new T[size];
            i = 0;
        }
        public override string ToString()
        {
            return "TAL CLASS";
        }
    }
    internal class Program
    {

        public static X GetFirst<X>(X[] a)
        {
            X x = a[0];
            return x;
        }

        public static bool IsExist<T>(T[] a, T tofind)
        {
            for(int i=0;i<a.Length;i++)
            {
                if (a[i].Equals(tofind))
                    return true;
            }
            return false;

        }
        public static void PrintArr<T>(T[] a)
        {
            for(int i=0; i<a.Length; i++)
                Console.WriteLine(a[i] );
        }

        
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 7, 6 };
            string[] arr2 = { "Tal", "Ofek", "Gal", "Ro" };
            Tal<string>[] tals = { new Tal<string>(4), new Tal<string>(3), new Tal<string>(2) };
            PrintArr(arr);
            PrintArr(arr2);
            PrintArr(tals);
            int b = GetFirst(arr);
            string c = GetFirst(arr2);
            Console.WriteLine(  IsExist(arr,6));
            Console.WriteLine(  IsExist(arr2,"Lynn"));
            //Console.WriteLine(IsExist(arr,"Lynn"));

        }
    }
}