using System;

namespace OOP_Session_03
{
    #region Part 1 Q1
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    #endregion

    #region Part 1 Q2
    class Rectangle
    {
        int width;
        int height;

        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public Rectangle(int value)
        {
            width = value;
            height = value;
        }
    }
    #endregion

    #region Part 1 Q3
    class ComplexNumber
    {
        public int real;
        public int imag;

        public ComplexNumber(int r, int i)
        {
            real = r;
            imag = i;
        }
        public ComplexNumber()
        {
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber
            {
                real = a.real + b.real,
                imag = a.imag + b.imag
            };
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber
            {
                real = a.real - b.real,
                imag = a.imag - b.imag
            };
        }

        public void OutPut()
        {
            Console.WriteLine(real + " + " + imag);
        }
    }
    #endregion

    #region Part 1 Q4
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing");
        }
    }
    #endregion

    #region Part 1 Q5
    class BaseClass
    {
        public virtual void Message()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }

    class DerivedClass1 : BaseClass
    {
        public override void Message()
        {
            Console.WriteLine("Message from DerivedClass1 (override)");
        }
    }

    class DerivedClass2 : BaseClass
    {
        public new void Message()
        {
            Console.WriteLine("Message from DerivedClass2 (new)");
        }
    }
    #endregion

    #region Part 2 Q1
    class Duration
    {
        public int Hours;
        public int Minutes;
        public int Seconds;
        public Duration() { }
    
    #endregion

    #region Part 2 Q2
     public Duration(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
            
        }
    #endregion
    internal class Program
        {
        static void Main(string[] args)
        {
            
        }
        }
}
