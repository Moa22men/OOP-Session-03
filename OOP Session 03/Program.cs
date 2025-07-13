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
        

        #endregion

        #region Part 2 Q2
        public Duration(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;

        }
        #endregion
        public Duration() { }

        #region Part 2 Q3
        public override string ToString()
        {
            string output = "";

            if (Hours > 0)
                output += $"Hours: {Hours}, ";

            if (Hours > 0 || Minutes > 0)
                output += $"Minutes: {Minutes}, ";

            output += $"Seconds: {Seconds}";

            return output;
        }

        public override int GetHashCode()
        {
            return TotalSeconds().GetHashCode();
        }

        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        #endregion

        #region Part 2 Q4

        #region Addition
        
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        public static Duration operator +(Duration d, int sec)
        {
            return new Duration(d.TotalSeconds() + sec);
        }

        public static Duration operator +(int sec, Duration d)
        {
            return new Duration(d.TotalSeconds() + sec);
        }

        #endregion

        #region Subtraction
        public static Duration operator -(Duration d1, Duration d2)
        {
            int total = d1.TotalSeconds() - d2.TotalSeconds();
            if (total < 0) total = 0;
            return new Duration(total);
        }

        #endregion

        #region Comparison
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        #endregion

        #endregion
        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
