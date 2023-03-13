using System;

namespace OnlineFoodOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int time;
            int breakfastset = 5;
            int weekendset = 2;
            int coffee = 3;
            
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
                        if (time >=11 ||breakfastset <0 )
                        {
                            Console.WriteLine("Sorry, your order is not available.");
                            break;
                        }
                        else if (breakfastset ==1 )
                        {
                            Console.WriteLine("Sorry, your order is out of stock.");
                            Console.WriteLine("Order accepted. Remaining Weekend Sets: "+weekendset);
                            Console.WriteLine("Order accepted. Remaining Coffees: "+coffee);
                            continue;
                        }
                        else
                        {
                            breakfastset--;
                            Console.WriteLine("Order accepted. Remaining Breakfast Sets: " + breakfastset);
                            Console.WriteLine("Order accepted. Remaining Weekend Sets: "+weekendset);
                            Console.WriteLine("Order accepted. Remaining Coffees: "+coffee);
                        }
                        break;
                        
                    case "Weekend Set":
                        if (day >= 1 && day <= 5 && weekendset <0 && time<8 && time>18)
                        {
                            Console.WriteLine("Sorry, your order is not available.");
                            continue;
                        }
                        else if (weekendset ==1)
                        {
                            Console.WriteLine("Order accepted. Remaining Breakfast Sets: " + breakfastset);
                            Console.WriteLine("Sorry, your order is out of stock.");
                            Console.WriteLine("Order accepted. Remaining Coffees:"+coffee);
                            continue;
                        }
                        else
                        {
                            weekendset--;
                            Console.WriteLine("Order accepted. Remaining Breakfast Sets: " + breakfastset);
                            Console.WriteLine("Order accepted. Remaining Weekend Sets: " + weekendset);
                            Console.WriteLine("Order accepted. Remaining Coffees: "+coffee);
                        }
                        break;
                        
                    case "Coffee":
                     if (time<8 && time>18 )
                        {
                            Console.WriteLine("Sorry, your order is not available.");
                            continue;
                        }
                     else if (coffee==1)
                        {
                            Console.WriteLine("Sorry, your order is out of stock.");
                            Console.WriteLine("Order accepted. Remaining Breakfast Sets: " + breakfastset);
                            Console.WriteLine("Order accepted. Remaining Weekend Sets: " + weekendset);
                            continue;
                        }
                        else
                        {
                            coffee--;
                            Console.WriteLine("Order accepted. Remaining Breakfast Sets: " + breakfastset);
                            Console.WriteLine("Order accepted. Remaining Weekend Sets: " + weekendset);
                            Console.WriteLine("Order accepted. Remaining Coffees: " + coffee);
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