internal class Program
{
    private static void Main(string[] args)
    {//square patter using stars
        for (int i = 0; i <= 5; i++)
        {
            Console.Write("* ");


        }
        Console.WriteLine();
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine("*         *");

        }
        for (int i = 0; i <= 5; i++)
        {
            Console.Write("* ");


        }

        Console.WriteLine();
        //while loop
        ///
        int a = 0;
        while (a < 5)
        {
            Console.WriteLine(a);
            a++;
        }

        //do while loop
        ///
        int b = 0;
        do
        {
            Console.WriteLine(b);
            b++;
        } while (b < 5);

        //increment 
        ///postincrement: a++ =>a=+1
        ///preincrement: ++a
        ///
        int x = 1;
        Console.WriteLine(x++);//output is 1
        Console.WriteLine(++x);//output is 3


        //task1
        ///write code that take two numbers from user (start & end)
        ///and then write the even numbers inbetween them

        int startNumber;
        int endNumber;
        Console.WriteLine("Enet a start  Number:  ");
        startNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enet an end Number:  ");
        endNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("**********************");
        for (int i = startNumber; i <= endNumber; i+=2)
        {
            Console.WriteLine(i);
        }


        //task2
        ///write code that take one numbers and performe  factorial operation
        ///
        {
            int Number;
            Console.WriteLine("Enet a  Number:  ");
            Number = int.Parse(Console.ReadLine());
            int i,fact=1;
         for(i = 1; i <=Number; i++)
            {

                fact = fact * i;
            }
            
            Console.WriteLine("Factorial of " + Number + " is: " + fact);
        }


        


    }
}