using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            Console.WriteLine("Nhập độ dài của mảng");
            n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(101);
            }
            PrintArray(arr, n); Console.WriteLine();
            // 1. Tìm giá trị trung bình
            Console.WriteLine("Gía trị trung bình của mảng là:");
            AvgOfArr(arr, n);
            // 2. Tìm giá trị:
            Console.WriteLine("Nhập giá trị cần tìm");
            int search = int.Parse(Console.ReadLine());
            if (SearchArr(arr, search, n))
            {
                Console.WriteLine("Có giá trị cần tìm");
            }
            else
            {
                Console.WriteLine("Không có giá trị cần tìm");
            }
            // 3. Tìm vị trí phần tử
            Console.WriteLine("Nhập phần tử cần tìm");
            int search1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vị trí của {search1}");
            Console.WriteLine(IndexArr(arr, search1, n));
            // 4. Xóa phần tử xuất hiện đầu tiên:
            Console.WriteLine("Nhập phần tử bạn muốn xóa: ");
            int search2 = int.Parse(Console.ReadLine());
            RemoveChar(arr, search2, ref n);
            Console.WriteLine("Mảng sau khi xóa: ");
            PrintArray(arr, n);
            // 5. Gía trị lớn nhất và nhỏ nhất của mảng
            MinMaxOfArr(arr, n);
            // 6. Đảo ngược mảng:
            Console.WriteLine("Mảng sau khi đảo ngược là:");
            ReverseArr(arr, n);
            // 7. Tìm phần tử trùng lặp:
            Console.WriteLine("Các phần tử trùng lặp trong mảng là");
            DuplicateArr(arr, n);
            // 8. Xóa phần tử trùng lặp:
            Console.WriteLine("Mảng sau khi xóa:");
            RemoveDupArr(arr, ref n);

            Console.ReadLine();

        }
        static void PrintArray(int[] arr, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
        static double AvgOfArr(int[] arr, int N)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        static bool SearchArr(int[] arr, int num, int N)
        {
            for (int i = 0; i < N; i++)
            {
                if (num == arr[i])
                {

                    return true;

                }
            }
            return false;

        }
        static int IndexArr(int[] arr, int num, int N)
        {
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == num)
                    return i;
            }
            return -1;
        }
        static void RemoveChar(int[] arr, int num, ref int N)
        {
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == num)
                {
                    for (int j = i; j < N - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                }
            }
            N--;
        }
        static void MinMaxOfArr(int[] arr, int N)
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < N; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }
        static void ReverseArr(int[] arr, int N)
        {
            int left = 0;
            int right = N - 1;
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }
        static void DuplicateArr(int[] arr, int N)
        {

            for (int i = 0; i < N; i++)
            {
                bool isDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        isDup = true;
                        break;
                    }
                }
                if (isDup)
                    continue;
                for (int k = i + 1; k < N; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        Console.WriteLine(arr[i]);
                        break;
                    }
                }

            }

        }
        static void RemoveDupArr(int[] arr, ref int N)
        {

            for (int i = 0; i < N; i++)
            {
                bool isDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        isDup = true;
                        break;
                    }
                }
                if (isDup)
                {
                    for (int k = i; k < N - 1; k++)
                    {
                        arr[k] = arr[k + 1];
                    }
                }
                N--;
                i--;

            }

        }




    }
}