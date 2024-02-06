using System;

namespace Activity2
{

    public class Car
    {

        public String Brand { get; set; }
        public String Color { get; set; }
        public int Price { get; set; }

        public void Honk(string stringVariable)
        {

            Console.WriteLine($"{stringVariable}: Honk!!!");

        }


    }

    public class Program
    {

        public static void Main(string[] args)
        {

            List<Car> list = new List<Car>();

            while (true)
            {

                Console.WriteLine("Enter new data? [Y/N]");

                if (Console.ReadLine() == "N")
                {

                    break;

                }

                Car carl = new Car();

                Console.WriteLine("Enter Car Brand = ");
                carl.Brand = Console.ReadLine();

                Console.WriteLine("Enter Car Color = ");
                carl.Color = Console.ReadLine();

                Console.WriteLine("Enter Car Price = ");
                carl.Price = int.Parse(Console.ReadLine());

                list.Add(carl);


            }

            list.ForEach(x =>
            {

                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);
                Console.WriteLine("************************");

            });



        }



    }





}