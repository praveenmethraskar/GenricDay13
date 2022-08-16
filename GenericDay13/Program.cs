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
                Console.WriteLine("Select option:\n 1.To find find maximum integer \n 2. To find max float \n 3. to find max string");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        FindMax obj = new FindMax();
                        int result = obj.FindMaxValue<int>(20, 30, 25);
                        Console.WriteLine(result+" is maxmium");
                        break;
                    case 2:
                        FindMax obj1 = new FindMax();
                        float result1 = obj1.FindMaxValue<float>(20.3f, 20.6f, 20.4f);
                        Console.WriteLine(result1+" is maxmium");
                        break ;
                    case 3:
                        FindMax obj2 = new FindMax();
                        string result2 = obj2.FindMaxValue<string>("apple", "boy", "cattle");
                        Console.WriteLine(result2+" is maxmium");
                        break;
                    default:
                        check = false;
                        break;
                }
            }
        }
    }
}