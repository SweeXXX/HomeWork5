using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using HomeWork5;
using std;
using System.Collections;
using HomeWork5;

namespace std // otsilka ;)
{
    class DZ
    {
        static Stack<Cl.Citizen> SS(Stack<Cl.Citizen> st, Cl.Citizen num1, int position)
        {
            List<Cl.Citizen> ints = st.ToList();
            position%=st.Count;
            
            ints.Insert(position,num1);
            ints.Remove(num1);
            //(ints[num1], ints[position]) = (ints[position], ints[num1]);
            Stack<Cl.Citizen> myStack = new Stack<Cl.Citizen>(ints);
            return myStack;
        }
        static void Main()
        {
            static void ex1()
            {
                Student Bob = new Student("kult", "Bob", 2004, subject.infa,50);
                Student Vika = new Student("Fedorova", "Vika", 2004, subject.infa,100);
                Student Daniil = new Student("Morozov", "Daniil", 2004, subject.infa,80);
                Student Karina = new Student("huzeva", "Karina", 2004, subject.language);
                Student Alina = new Student("Aliarova", "Alina", 2004, subject.language,30 );
                Student Vitaliy = new Student("Shpack", "Bob", 2004, subject.infa);
                Student Nikita = new Student("Poletaev", "Nikita", 2004, subject.infa,80);
                Student Radmir = new Student("Salimov", "Radmir", 2004, subject.infa, 90);
                Student Artem = new Student("artemov", "Artem", 2004, subject.phisic,80);
                Student Maksim = new Student("Zarecniy", "Maksim", 2004, subject.language);

                Dictionary<string, Student> stttd = new Dictionary<string, Student>(); // slovarik

                stttd.Add("kult", Bob);
                stttd.Add("Fedorova", Vika);
                stttd.Add("Morozov", Daniil);
                stttd.Add("huzeva", Karina);
                stttd.Add("Aliarova", Alina);
                stttd.Add("Shpack", Vitaliy);
                stttd.Add("Poletaev", Nikita);
                stttd.Add("Salimov", Radmir);
                stttd.Add("artemov", Artem);
                stttd.Add("Zarecniy", Maksim);
                while(true)
                {
                    string word = Console.ReadLine().ToLower();
                    if (word.Equals("удалить"))
                    {
                        Console.Write("Введите фамилию и имя через запятую: ");
                        try
                        {
                            string[] stud = Console.ReadLine().Split(",");
                            stttd.Remove(stud[0]);
                        }
                        catch
                        {
                            Console.WriteLine("Неверный ввод!(1)");
                            break;
                        }
                    }
                    else if (word.Equals("сортировать"))
                    {
                        var sorted = stttd.OrderBy(x => x.Value.ball).ToDictionary(x => x.Key, x => x.Value.ball);
                        Console.WriteLine(String.Join("\n", sorted));
                    }
                    else if (word.Equals("новый студент"))
                    {
                        try
                        {
                            Console.Write("Введите фамилию, имя, год рождения, балл через запятую");
                            string[] s = Console.ReadLine().Split(",");
                            Student st = new Student(s[0], s[1], int.Parse(s[2]), int.Parse(s[3]));
                            stttd.Add(s[0], st);
                        }
                        catch
                        {
                            Console.WriteLine("Неверный ввод(2)");
                        }
                            
                    }
                    else if(word.Equals("stop") || word.Equals("стоп"))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            static void ex2()
            {
                try // 2 ex
                {
                    int[] f = File.ReadLines("C:\\Users\\Никита\\Desktop\\эксерсайз 2(.txt").First().Split().Select(x => int.Parse(x)).ToArray();
                    int[] s = File.ReadLines("C:\\Users\\Никита\\Desktop\\эксерсайз 2(.txt").Skip(1).First().Split().Select(x => int.Parse(x)).ToArray();
                    GetEx2(s, f);
                    static void GetEx2(int[] first, int[] second, int k = 5)
                    {
                        int count1 = 0;
                        int count2 = 0;
                        foreach (int i in first)
                            if (i == k) count1++;
                        foreach (int j in second)
                            if (j == k) count2++;

                        if (count1 == count2)
                            Console.WriteLine("««Drinks All Round! Free Beers on Bjorg!»»");

                        else
                            Console.WriteLine("««Ой, Бьорг -\r\nпончик! Ни для кого пива!»»");
                    }
                }
                catch
                {
                    Console.WriteLine("Что-то пошло не так :(");
                }//2
            }
            
            static void ex3(int k = 7)
            {
                Stack<Cl.Citizen> people = new Stack<Cl.Citizen>();
                try
                {
                    for (int i = 0; i < k; i++)
                    {
                        string[] file = File.ReadLines("C:\\Users\\Никита\\Desktop\\Ex 3.txt").Skip(i).First().Split(",").ToArray();
                        var citizen = new Cl.Citizen(file[0], file[1], file[2], int.Parse(file[3]), byte.Parse(file[4]));
                        people.Push(citizen);
                    }

                    //people = SS(people, people.Peek(), 8);
                    for (int i = 0; i < k; i++)
                    {
                        if (people.Peek().smart == 10000)
                        {
                            Console.Write($"{people.Peek().Name}. Vvedite Sdvig:");
                            int sdvig = int.Parse(Console.ReadLine()) % people.Count;
                            people = SS(people, people.Peek(), (k+sdvig)%k);
                            //Console.WriteLine(people.Count);
                            //Console.WriteLine(people.Peek().Name);
                        }
                        
                        Console.WriteLine($"{people.Peek().Name}, Ваше окно:{Zina.banWords(people.Peek())}");
                        people.Pop();
                        
                        //Console.WriteLine(people.Peek().Name);
                        //people.Pop();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                //Console.WriteLine(people.Count);

            }
            //ex3();
            //List<int> nums = new List<int>{ 1, 2, 3, 5, 5, 1, 13 };
            //nums.Remove(5);
            //Console.WriteLine(String.Join(" ", nums));
            //Stack<int> mystack = new Stack<int>();
            //mystack.Prepend(152);
            //mystack.Push(1423);
            //mystack.Push(1111234);
            //mystack.Prepend(152);
            //int num = mystack.Peek();
            //Console.WriteLine(String.Join(" ", mystack));
            //mystack.Pop();
            
            //Console.WriteLine(String.Join(" ", mystack));
            //Console.WriteLine(num);
        }
    }
}
