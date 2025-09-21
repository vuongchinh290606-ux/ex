using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises_14._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Phần 1: Sắp xếp bằng Bubble Sort 
            int[] numbers = NhapMang();
            BubbleSort(numbers);
            Console.WriteLine("\nDãy số sau khi sắp xếp :");
            InMang(numbers);

            // Phần 2: Tìm từ trong câu bằng Linear Search
            Console.WriteLine("\nNhập vào một câu:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Nhập vào một từ cần tìm:");
            string word = Console.ReadLine();

            TimTuTrongCau(sentence, word);

            Console.WriteLine("\nChương trình kết thúc.");
        }

        static int[] NhapMang()
        {
            int[] arr = new int[10];
            Console.WriteLine("Nhập vào 10 số nguyên:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void InMang(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void TimTuTrongCau(string sentence, string word)
        {
            string[] words = sentence.Split(' ');
            bool found = false;
            string wordLower = word.ToLower();

            int viTriThuc = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    viTriThuc++;

                    if (words[i].ToLower() == wordLower)
                    {
                        found = true;
                        Console.WriteLine($"Từ \"{word}\" xuất hiện ở vị trí thứ {viTriThuc} trong câu.");
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"Từ \"{word}\" không xuất hiện trong câu.");
            }
        }
    }
}

