using System;
using System.Collections.Generic;

namespace Breakfast_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;
            double total = 0.0, BeforeTax, TenderedAmount, AmountDue, Change, newtotal;
            string code;
            var ItemCode = new List<string> { "B1", "B2", "B3", "B4", "B5", "B6", "D1", "D2", "D3" };
            var ItemName = new List<string> { "Sausage Biscuit", "Sausage with Egg Biscuit",
                "Bacon, Egg & Cheese Biscuit","Bacon, Egg & Cheese Bagel","Hotcakes","Hotcakes & Sausage","Coffee","Soft Drink","Tea" };
            var Price = new List<double> { 3.50, 4.00, 4.25, 4.50, 3.75, 4.75, 2.50, 1.50, 1.75 };
            
            for (; ;) {
                Console.Write("Please enter the item code: ");
                code = Console.ReadLine();
                if (ItemCode.Contains(code))
                {
                    Console.Write("Please enter the quantity: ");
                    q = Convert.ToInt32(Console.ReadLine());
                    BeforeTax = (q * Price[ItemCode.IndexOf(code)]) * 0.06;
                    total += (q * Price[ItemCode.IndexOf(code)]) + BeforeTax;

                }
                else if (code == "")
                {
                    Console.WriteLine($"The total is ${Math.Round(total, 2)}");
                    Console.Write("Please enter the tendered amount: ");
                    TenderedAmount = Convert.ToDouble(Console.ReadLine());
                    Change = TenderedAmount - total;
                    if (TenderedAmount >=total)
                    {
                        Console.WriteLine($"The change is: ${Math.Round(Change, 2)}");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("The item code is invalid.");
                    
                    
                    // If the tendered amount is short, the customer have to pay for the amount due. 
                    //else {
                    //    while (TenderedAmount < total) {
                    //        AmountDue = total - TenderedAmount;

                    //        Console.WriteLine($"Total amount due: ${AmountDue}");
                    //        Console.Write("Please enter the tendered amount: ");
                    //        TenderedAmount = Convert.ToDouble(Console.ReadLine());
                    //        total = AmountDue;
                    //    }


                    //    Change = TenderedAmount - AmountDue; // Error at this line

                    //}

                }
                
            }
           

         

        }




            
    }




   }

