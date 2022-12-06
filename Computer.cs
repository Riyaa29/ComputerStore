
//  	
// Project OOP
// © RIYA NAGPAL
// Written by: RIYA NAGPAL, 2220097
//  	

namespace The_Project
{

    public class Computer
    {
        public static int noOfComputers = 0;

        private string Brand;
        private string Model;
        private long SN;
        private double Price;

        public Computer()
        {
            Brand = "hey";
            Model = "bye";
            SN = 0;
            Price = 0;
            noOfComputers++;
        }

        public Computer(string brand, string model, long sn, double price)
        {

            Brand = brand;
            Model = model;
            SN = sn;
            Price = price;
            noOfComputers++;
        }

        public void setBrand(string brand)
        {
            Brand = brand;
        }

        public string getBrand()
        {
            return Brand;
        }

        public void setModel(string model)
        {
            Model = model;
        }

        public string getModel()
        {
            return Model;
        }

        public void setSN(long sn)
        {
            if (sn > 0)
            {
                SN = sn;
            }
            else
            {
                Console.WriteLine("ERROR! Try Again!! Serial Number cannot be negative!!");
            }
        }

        public long getSN()
        {
            return SN;
        }

        public void setPrice(double price)
        {
            if (price > 0)
            {
                Price = price;
            }
            else
            {
                Console.WriteLine("ERROR! Try Again!! Price cannot be negative!!");
            }
        }

        public double getPrice()
        {
            return Price;
        }

        public static int findNumberOfCreatedComputers()
        {
            return noOfComputers;
        }

        public void showComputer()
        {
            Console.WriteLine($"-------- Computer ----------");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Serial Number: {SN}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine("----------------------------");
        }


    }


}