using System;

namespace OnlineFoodOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int time;
            int breakfastsetCount = 5;
            int weekendsetCount = 2;
            int coffeeCount = 3;
            
                Console.WriteLine("Enter the your days:");
                day = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter the time your times:");
                time = int.Parse(Console.ReadLine());
                while (true)
                {
                Console.WriteLine("Enter the menu you want to order (Write 'end' to exit):");
                string menu = Console.ReadLine();
            
                if (menu.Equals("end"))
                {
                    Console.WriteLine("Thank you for your order!");
                    break;
                }

                switch (menu)
                {
                    case "Breakfast Set":
                        if (time >=11 ||breakfastsetCount <0 )
                        {
                            Console.WriteLine("Sorry, your order is not available.");
                            break;
                        }
                        else if (breakfastsetCount ==1 )
                        {
                            Console.WriteLine("Sorry, your order is out of stock.");
                            continue;
                        }
                        else
                        {
                            breakfastsetCount--;
                            Console.WriteLine("Order accepted. Remaining Breakfast Sets: " + breakfastsetCount);
                        }
                        break;
                        
                    case "Weekend Set":
                        if (day >= 1 && day <= 5 && weekendsetCount <0 && time<8 && time>18)
                        {
                            Console.WriteLine("Sorry, your order is not available.");
                            continue;
                        }
                        else if (weekendsetCount ==1)
                        {
                            Console.WriteLine("Sorry, your order is out of stock.");
                            continue;
                        }
                        else
                        {
                            weekendsetCount--;
                            Console.WriteLine("Order accepted. Remaining Weekend Sets: " + weekendsetCount);
                        }
                        break;
                        
                    case "Coffee":
                     if (time<8 && time>18 )
                        {
                            Console.WriteLine("Sorry, your order is not available.");
                            continue;
                        }
                     else if (coffeeCount==1)
                        {
                            Console.WriteLine("Sorry, your order is out of stock.");
                            continue;
                        }
                        else
                        {
                            coffeeCount--;
                            Console.WriteLine("Order accepted. Remaining Coffees: " + coffeeCount);
                        }
                        break;
                        
                    default:
                        Console.WriteLine("Please enter a valid menu.");
                        
                        break;

                }
            }
        }
    }
}








