namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int year ;


            //    do {
            //        Console.Write("Plz enter your year : -");
            //        year = int.Parse(Console.ReadLine());

            //    }while (year >2024);
            //    Console.WriteLine(  year);

            ////////////////////////////////    //////////////////////////////////
            ///



            Console.WriteLine("enter year: ");

            int year;
            bool flag = true;
            while (flag)
            {

                year = int.Parse(Console.ReadLine());
                if (year < 2024)
                {

                    flag = false;
                    Console.WriteLine(year);
                }
                if (flag)
                {
                    Console.WriteLine("enter a vaild year: ");
                }
            }
        }
    }
}
