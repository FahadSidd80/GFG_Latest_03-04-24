using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GFG_Lang_Fundmntls._4_Methods
{
    internal class Methods
    {
        //        Example : 

        ////        Method Name --> GetCircleArea()
        ////        Return Type ---> double
        ///
        //static double GetCircleArea(double radius)
        //{
        //    const float pi = 3.14F;
        //    double area = pi * radius * radius;
        //    return area;
        //}

        //static double getCircleArea(double radius)
        //{
        //    const float pi = 3.14F;
        //    double area = pi * radius * radius;
        //    return area;
        //}

        //static int sum(int x, int y)
        //{
        //    int a=x, b=y;
        //    int result = a + b;
        //    return result;
        //}

        //static void printSentence()
        //{
        //    Console.WriteLine("No parameter and no returntype !");
        //}

        //static int SumGet()
        //{
        //    int a = 10;
        //    int b = 19;
        //    int sum = a + b;
        //    return sum;
        //}

        //static void SqrPermeter(int p)
        //{
        //    Console.WriteLine("Perimeter of square is : "+ 4 * p);
        //}

        //static int factorial(int n)
        //{
        //    int f = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        f = f * i;
        //    }
        //    return f;
        //}

        //public int Add(int a, int b)
        //{
        //    int sum = a + b;
        //    return sum;
        //}

        //public int Add(int a, int b,int c)
        //{
        //    int sum = a + b+c;
        //    return sum;
        //}

        //public int Add(int a, int b, int c)
        //{
        //    int sum = a + b + c;
        //    return sum;
        //}

        //public double Add(double a, double b, double c)
        //{
        //    double sum = a + b + c;
        //    return sum;
        //}

        //public void Identity(String name, int id)
        //{
        //    Console.WriteLine("Name1: "+ name +", "+ "Id1 :"+ id);
        //}

        //public void Identity(int id, String name)
        //{
        //    Console.WriteLine("Name2: " + name +", "+ "Id2 :" + id);
        //}

        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        //public double Add(int a, int b)
        //{
        //    double sum = a + b +0.0;
        //    return sum;
        //}
        public static void Main()
        {
            //Console.WriteLine("Methods");

            //double areas = GetCircleArea(3);
            //Console.WriteLine("Area of circle " + areas);

            //Methods metd = new Methods();
            //double areass = getCircleArea(3);
            //Console.WriteLine("Area of Circle : "+ areass);

            //< Access_Modifier > < return_type > < method_name > ([< parameter_list >])

            // Same method name but different parameter - method overloading.


            //            The below syntax describes the basic structure of the method body:
            //              Syntax:

            //              < return_type > < method_name > (< parameter_list >)
            //              {

            //                // Implementation of the method code goes here.....

            //              }
            //int a = 12;
            //int b = 13;
            //Console.WriteLine("Enter value of a and b :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //int c = sum(a,b);
            //Console.WriteLine("the sum of Values a nd b is :"+c );

            //printSentence();

            //int resultSum =  SumGet();
            //Console.WriteLine("The sum of A nad B is :"+resultSum);

            //int p = 5;
            ////SqrPermeter(5);
            //SqrPermeter(p);
            //int n = 10;
            //Console.WriteLine("Factorial of number is : "+ factorial(n));

            //C# can distinguish the methods with different method signatures. i.e. 
            //the methods can have the same name but with different parameters 
            //list (i.e. the number of the parameters, order of the parameters,
            //and data types of the parameters

            //Methods obj = new Methods();
            //int res1 = obj.Add(1,2);
            //Console.WriteLine("Sum of two two integer value: "+ res1);


            //int res2 = obj.Add(1, 2, 3);
            //Console.WriteLine("Sum of three two integer value: " + res2);

            //Methods ob = new Methods();
            //int res1 = ob.Add(1,2,3);
            //Console.WriteLine("Sum of three parameter of int type value: "+res1);

            //double res2 = ob.Add(1.0, 2.0, 3.0);
            //Console.WriteLine("Sum of three parameter of double type value: " + res2);

            //double res2 = ob.Add(1.0, 2.0, 3);
            //Console.WriteLine("Sum of three parameter of double type value: " + res2);

            //double res2 = ob.Add(1.0, 2, 4);
            //Console.WriteLine("Sum of three parameter of double type value: " + res2);


            //Methods ob = new Methods();
            //ob.Identity("fahad", 12);
            //ob.Identity(15,"Hamza");

            //Methods ob = new Methods();
            //int sum1 = ob.Add(1, 2);
            //Console.WriteLine("sum of the two "
            //                  + "integer value :" + sum1);

            //int sum2 = ob.Add(1, 2);
            //Console.WriteLine("sum of the three "
            //                  + "integer value :" + sum2);


        }
    }
}
