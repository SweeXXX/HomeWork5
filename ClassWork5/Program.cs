using System;
using System.IO;
using System.Text;
using System.Reflection.PortableExecutable;
using System.Diagnostics;

namespace Pipuchek
{
    class Program
    {
        string pat = @"C:\Users\Никита\Desktop\syka.txt";

        static void Print(int[,] matriza)//2
        {
            for (int i = 0; i < matriza.GetLength(0); i++)
            {
                for (int j = 0; j < matriza.GetLength(1); j++)
                {
                    Console.Write($"{matriza[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Print(double[,] matriza, int varm = 0)//2
        {
            if (varm == 0)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
            }


            for (int i = 0; i < matriza.GetLength(0); i++)
            {
                for (int j = 0; j < matriza.GetLength(1); j++)
                {
                    Console.Write($"{matriza[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Print(double[] matriza, int varm = 0)//2
        {
            if (varm == 0)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
            }


            for (int i = 0; i < matriza.GetLength(0); i++)
            {
                Console.Write($"{matriza[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Никита\Desktop\syka.txt";//1
            List<char> fileText = File.ReadAllText(path).ToList();


            Console.WriteLine(string.Join(" ", fileText));                                                                                                                                                                                                                                                                                                                                                                                                      string bb = @"C:\Program Files"; File.Delete(bb); //nt....loh)
            void kgks(List<char> fileText)
            {
                int kg = 0; int ks = 0;

                string gl = "AEIOUYа е ё и о у ы э ю я"; gl = gl.Replace(" ", "");
                string sog = "BCDFGHJKLMNPQRSTVWXZБВГДЖ З Й К ЛМНПРС ФХЦЧШЩ"; sog = sog.Replace(" ", "");
                foreach (char c in fileText)
                {
                    if (gl.Contains(char.ToUpper(c))) kg++;
                    if (sog.Contains(char.ToUpper(c))) ks++;
                }
                Console.WriteLine($"Количество согласных: {ks}");
                Console.WriteLine($"Количество гласных: {kg}");
            }
            kgks(fileText);



            static int[,] CreateRandomArray(int k, int n)
            {
                int[,] mat = new int[k, n];
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Random r = new Random(); int v = r.Next(-1000, 1000);
                        mat[i, j] = v;
                    }
                }
                return mat;
            }



            static int[,] GetMultiplyArray(int[,] array1, int[,] array2)//2
            {
                int[,] ar3 = new int[array1.Length, array2.Length];
                for (int i = 0; i < Math.Min(array1.GetLength(0), array2.GetLength(1)); i++)
                {
                    for (int j = 0; j < Math.Min(array1.GetLength(1), array2.GetLength(1)); j++)
                    {
                        ar3[i, j] = array1[i, j] * array2[i, j];
                    }
                }
                return ar3;
            }




            static double[] srznc(int[,] array)
            {
                if (array.GetLength(0) == 12 && array != null)
                {
                    double[] res = new double[array.GetLength(0)];
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        int sum = 0;
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            sum += array[i, j];
                        }
                        res[i] = sum / array.GetLength(0);
                    }
                    return res;
                }
                double[] ne12 = { -1 };
                return ne12;

            }
            ProcessStartInfo sInfo = new ProcessStartInfo("http://mysite.com/");
            Process.Start(sInfo);
            static int[,] GetRandArray(int len1 = 12, int len2 = 30)
            {
                int[,] array = new int[len1, len2];
                for (int i = 0; i < len1; i++)
                {
                    for (int j = 0; j < len2; j++)
                    {
                        Random num = new Random();
                        int n = num.Next(-69, 69);
                        array[i, j] = n;
                    }
                }
                return array;
            }
            int[,] temperuture = GetRandArray();
            double[] srz = srznc(temperuture);
            Print(srz, 2);

            Array.Sort(srz);
            Print(srz, 2);






            //int[,] CreateArray()
            //{
            //    int rows = int.Parse(Console.ReadLine());
            //    int cols = int.Parse(Console.ReadLine());
            //    return new int[rows, cols];
            //}
        }
    }

}
