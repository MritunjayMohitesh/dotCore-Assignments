using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Class1
    {
        public T Addition<T>(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
           
            return a + b;
        }

        public T Subtraction<T>(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a - b;
        }

        public T Multiplication<T>(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            return a * b;
        }

        public T Divison<T>(T number1, T number2)
        {
            dynamic a = number1;
            dynamic b = number2;
            dynamic c = 0;
            if (b == 0)
                return c;
            else
                return a / b;
        }

        public T Addition<T>(List<T> numbers)
        {
            dynamic sum = 0;
            foreach(T num in numbers)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
}
