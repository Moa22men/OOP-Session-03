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


    internal class Program
    {
        static void Main(string[] args)
        {
            
    }
    }
}
