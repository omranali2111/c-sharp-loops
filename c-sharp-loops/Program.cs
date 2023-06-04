internal class Program
{
    private static void Main(string[] args)
    {//square patter using stars
       for(int i=0; i<=5; i++)
        {
            Console.Write("* ");


        }
        Console.WriteLine();
        for (int i=0; i<=3;i++)
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
        while (a<5)
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
        }while (b <5);

    }
}