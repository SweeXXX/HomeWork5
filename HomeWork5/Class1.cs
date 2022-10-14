using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace std
{
    public class Cl
    {
        public struct Citizen
        {
            public string Name = "Oleg";
            public string passport;
            public string problem;
            public int Mudak = 10;
            public byte smart = 1;
            
            public Citizen(string Name, string passport, string problem, int Mudak, byte smart)
            {
                this.Name = Name;
                this.passport = passport;
                this.problem = problem;
                this.Mudak = Mudak;
                this.smart = smart;
            }
        }
    }
    public class Zina
    {
        public static int banWords(Cl.Citizen citizen)
        {
            if(citizen.smart==0)
            {
                Random num = new Random();   int p = num.Next(1, 4);
                return p;
            }
                
            if(citizen.problem.ToLower().Contains("отопление") || citizen.problem.ToLower().Contains("холодно") || citizen.problem.ToLower().Contains("гони отопление, чорт"))
                return 1;
            else if (citizen.problem.ToLower().Contains("как оплатить?") || citizen.problem.ToLower().Contains("оплатить") || citizen.problem.ToLower().Contains("оплата") || citizen.problem.ToLower().Contains("заткнись и возьми мои деньги!"))            
                return 2;
            else
                return 3;
        }
    }
    public enum subject
    {
        infa=0,
        phisic = 2,
        language=101010
    }
    public class Student
    {
        public string Surname;
        public string Name;
        public int yearOfBurn = 2004;
        public subject ex= subject.language;
        public int ball = 60;
        public Student(string surname, string name, int yearOfBurn, subject ex)
        {
            this.Surname = surname;
            this.Name = name;
            this.yearOfBurn=yearOfBurn;
            this.ex = ex;
        }
        public Student(string surname, string name, int yearOfBurn, subject ex, int ball)
        {
            this.Surname = surname;
            this.Name = name;
            this.yearOfBurn = yearOfBurn;
            this.ex = ex;
            this.ball = ball;
        }
        public Student(string surname, string name, int yearOfBurn, int ball)
        {
            this.Surname = surname;
            this.Name = name;
            this.yearOfBurn = yearOfBurn;
            this.ball = ball;
        }
    }
}
