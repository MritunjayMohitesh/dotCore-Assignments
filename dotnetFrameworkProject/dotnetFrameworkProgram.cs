using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace toBeLinked2
{
    class dotnetFrameworkProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give two inputs : Operations performed are in the way -> A op B");
            dynamic number1 = Console.ReadLine();
            dynamic number2 = Console.ReadLine();
            dynamic ans = 0;
            ClassLibrary1.Class1 newObject = new ClassLibrary1.Class1();
            System.Type type1 = number1.GetType();
            System.Type type2 = number2.GetType();

            if (type1.Name == "Int32" && type2.Name == "Int32")
            {
                ans = newObject.Addition<int>(number1, number2);
                Console.WriteLine("The addition output is:{0}", ans);

                ans = 

                ans = newObject.Subtraction<int>(number1, number2);
                Console.WriteLine("The subtraction output is:{0}", ans);
                ans = newObject.Multiplication<int>(number1, number2);
                Console.WriteLine("The multiplication output is:{0}", ans);
                ans = newObject.Divison<int>(number1, number2);
                if (ans == 0)
                    Console.WriteLine("Divide by Zero Error");
                else
                    Console.WriteLine("The divison output is:{0}", ans);

            }
            else
            {
                number1 = Convert.ToDouble(number1);
                number2 = Convert.ToDouble(number2);
                ans = newObject.Addition<double>(number1, number2);
                Console.WriteLine("The addition output is:{0}", ans);
                ans = newObject.Subtraction<double>(number1, number2);
                Console.WriteLine("The subtraction output is:{0}", ans);
                ans = newObject.Multiplication<double>(number1, number2);
                Console.WriteLine("The multiplication output is:{0}", ans);
                ans = newObject.Divison<double>(number1, number2);
                if (ans == 0)
                    Console.WriteLine("Divide by Zero Error");
                else
                    Console.WriteLine("The divison output is:{0}", ans);

            }

            Console.WriteLine("Enter the numbers");
            List<double> list = new List<double>();
            int Val;
            do
            {
                double num = Convert.ToDouble(Console.ReadLine());
                list.Add(num);
                Console.WriteLine("Still want to continue...Press 1");
                Val = Convert.ToInt32(Console.ReadLine());
            } while (Val == 1);

            Console.WriteLine("The sum is:{0}", newObject.Addition<double>(list));




            Console.ReadKey();
        }
    }
}
