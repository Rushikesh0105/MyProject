using System;
namespace MyProject.Oops
{
    class Shopping
    
        {
            public string product_Name;
            public float quantity;
            public float price;
            public float total;

            public void Details(string name, float quant, float p)
            {
                product_Name = name;
                quantity = quant;
                price = p;
            }
            public void create_bill()
            {
                if (quantity > 0)
                {
                    for (int i = 0; i <= quantity; i++)
                    {
                        total = price * quantity;
                    }
                }
                else
                {
                    Console.WriteLine("Zero");
                }
            }

            public void Display_Details()
            {
                Console.WriteLine(" Name = " + product_Name + " Quantity = " + quantity + " Price = " + price + " Total = " + total);
            }

            static void Main(String[] args)
            {
                Shopping shop = new Shopping();
                shop.Details("Soap", 5, 150);
                shop.create_bill();
                shop.Display_Details();

            }
        }
    }
