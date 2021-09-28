using System;

namespace _20210907_MavPASS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Pasta myPasta1 = new Pasta("new name",5);
            Pasta myPasta2 = new Pasta();
            Pasta myPasta3 = new Pasta();

            Console.WriteLine(myPasta1.Name);
            Console.WriteLine(myPasta1.Name);
            Console.WriteLine(myPasta1.TimeToCook);
            myPasta1.TimeToCook = 3;
            Console.WriteLine(myPasta1.TimeToCook);
            Console.WriteLine(myPasta1.Name);


            Console.ReadLine();
        }
    }
}
