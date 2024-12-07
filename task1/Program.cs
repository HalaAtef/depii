using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Print
            Console.WriteLine("Print");
            Console.WriteLine("Name: Hala");
            Console.WriteLine("Age: 32");
            Console.WriteLine("Hobby: Cooking");
            #endregion

            #region MyRegion
            Console.WriteLine();
            Console.WriteLine("******** DataType *******");
            int num;
            double dou_num;
            string name;
            bool is_child;

            num = 1;
            dou_num = 5.8;
            name = "Mawada";
            is_child = true;

            Console.WriteLine(num);
            Console.WriteLine(dou_num);
            Console.WriteLine(name);
            Console.WriteLine(is_child);
            #endregion

            #region temperature
            Console.WriteLine();
            Console.WriteLine("********Temperature converter *******");
            double cel = 37.5;
            double feh;
            feh = ((cel * 9) / 5) + 32;
            Console.WriteLine();
            Console.WriteLine("37.5 Celsius temperature is " +feh+ " Fahrenheit");
            #endregion

            #region operations
            Console.WriteLine();
            Console.WriteLine("******** Calculation *******");
            Console.Write("Enter First Number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            double num2 = double.Parse(Console.ReadLine());
            double sum=num1 + num2;
            double sub=num1 - num2;
            double multi=num1*num2;
            double div=num1/num2;
            Console.WriteLine();
            Console.WriteLine("sum= "+sum + ", subtraction= "+sub+ " , multiply= "+multi+ " , divition= " +div);
            #endregion

            #region rectangle_area
            Console.WriteLine();
            Console.WriteLine("********Area of rectangle *******");
            
            Console.Write("Enter Lenght: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            double wid = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle is "+ len*wid);
            #endregion

            #region Age
            Console.WriteLine();
            Console.WriteLine("********Eligible Age *******");
            Console.Write("Enter your age: ");
            double age = double.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            #endregion

            #region GradeSystem
            Console.WriteLine();
            Console.WriteLine("*************Grade System**********");
            Console.Write("Enter a score between (0-100): ");
            double Grade = double.Parse(Console.ReadLine());
            if (Grade < 0)
                Console.WriteLine("Degree is wrong");
            else if (Grade >= 0 && Grade < 60)
                Console.WriteLine("Grade is F");
            else if (Grade >= 60 && Grade <= 69)
                Console.WriteLine("Grade is D");
            else if (Grade >= 70 && Grade <= 79)
                Console.WriteLine("Grade is C");
            else if (Grade >= 80 && Grade <= 89)
                Console.WriteLine("Grade is B");
            else if (Grade >= 90 && Grade <= 100)
                Console.WriteLine("Grade is A");
            #endregion
        }
    }
}
