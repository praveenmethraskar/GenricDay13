using System;

namespace GenericDay13
{


    public class Program
    {
        public static void Main(string[] args)
        {
            

            bool check = true;
            while(check)
            {
                Console.WriteLine("Select option:\n 1.To find find maximum integer \n 2. To find max string \n 3. to find max float");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        FindMax obj = new FindMax();
                        int result = obj.FindMaxInteger(20, 30, 25);
                        Console.WriteLine(result+" is maxmium");
                        break;
                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}