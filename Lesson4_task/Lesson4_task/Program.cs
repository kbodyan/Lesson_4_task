using System;

namespace Title4_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string size;
            int n;
            do
            {
                Console.Write("Enter array size: ");
                size = Console.ReadLine();
            }
            while (!int.TryParse(size, out n));
            Random rand = new Random();
            int[] array = new int[n];
            dynamic[] newArray1 = new dynamic[n];
            dynamic[] newArray2 = new dynamic[n];
            int j1 = 0, j2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 26);
                if (array[i] % 2 == 0)
                {
                    newArray1[j1++] = array[i];
                }
                else
                {
                    newArray2[j2++] = array[i];
                }
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Array.Resize<dynamic>(ref newArray1, j1);
            Array.Resize<dynamic>(ref newArray2, j2);
            PrintArray(newArray1, "Array 1");
            PrintArray(newArray2, "Array 2");
            string letters = "aeidhj";
            int up1 = ChangeToLetters(newArray1);
            int up2 = ChangeToLetters(newArray2);
            PrintArray(newArray1, "Array 1");
            PrintArray(newArray2, "Array 2");
            Console.WriteLine("\n{0} contains more upper letters", up1 > up2 ? "Array 1" : up1 < up2 ? "Array 2" : "None array");

            int ChangeToLetters(dynamic[] ar)
            {
                int count = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = (char)((int)'a' + ar[i] - 1);
                    if (letters.Contains(ar[i]))
                    {
                        ar[i] = char.ToUpper(ar[i]);
                        count++;
                    }
                }

                return count;
            }

            void PrintArray(object[] ar, string mes)
            {
                Console.WriteLine();
                Console.Write(mes + ": ");
                foreach (var item in ar)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }
    }
}