
//  	
// Project OOP
// © RIYA NAGPAL
// Written by: RIYA NAGPAL, 2220097
//  	

using The_Project;


string password, brand, model;
long sn;
double price;
int totalComputers, comp;
int enteredComp = 0;



Console.WriteLine("**********************************************************************");
Console.WriteLine("            Welcome to the Computer Store!!    ");
Console.WriteLine("**********************************************************************");
Console.WriteLine();
Console.WriteLine("--------------------------------------------------------------------");

do
{


    try
    {
        Console.Write("Please enter the maximum number of computers: ");
        totalComputers = Convert.ToInt32(Console.ReadLine());
        if (totalComputers < 0)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Total number of computers cannot be negative!!");
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Please Enter a Valid Value!!!!");
        Console.WriteLine("--------------------------------------------------------------------");
        totalComputers = -1;
    }
} while (totalComputers <= 0);


Computer[] computer = new Computer[totalComputers];

Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine($"You can enter upto {totalComputers} computers !!");

Char option;


do
{
    try
    {
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("-------------------- What do you want to do? -----------------------");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("|  Press 1 to Enter new Computer(password required)                |");
        Console.WriteLine("|  Press 2 to Change information of a computer (password required) |");
        Console.WriteLine("|  Press 3 to Display all computers by a specific brand.           |");
        Console.WriteLine("|  Press 4 to Display all computers under a certain a price.       |");
        Console.WriteLine("|  Press 5 to Display all computers.                               |");
        Console.WriteLine("|  Press 0 to Quit                                                 |");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Choose your option: ");
        option = Convert.ToChar(Console.ReadLine() ?? string.Empty);
    }
    catch (Exception)
    {
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Please Enter a Valid Value!!!!");
        option = 'u';
    }

    switch (option)
    {
        case '1':
            {

                Console.WriteLine("Enter the password: (You get 3 chances!)");
                password = Console.ReadLine() ?? string.Empty;

                if (password != "password")
                {
                    for (int count = 2; count > 0; count--)
                    {
                        if (password == "password" || password == "PASSWORD")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"ERROR!! Try Again");
                            Console.WriteLine($"Enter the password: (You get {count} chances!)");
                            password = Console.ReadLine() ?? string.Empty;
                        }
                    }

                }
                if (password == "password" || password == "PASSWORD")
                {
                    Console.WriteLine("Access is granted !!");
                    Console.WriteLine("--------------------------------------------------------------------");
                    do
                    {
                        try
                        {
                            Console.WriteLine("How many computers would you like to enter?");
                            comp = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("Please Enter a Valid Value!!!!");
                            Console.WriteLine("--------------------------------------------------------------------");
                            comp = -1;
                        }
                    } while (comp <= 0);

                    if (comp <= totalComputers)
                    {
                        for (int i = 0; i < comp; i++)
                        {
                            Console.WriteLine($"Enter the brand for computer {i + 1}: ");
                            brand = Console.ReadLine() ?? string.Empty;

                            Console.WriteLine($"Enter the model for computer {i + 1}: ");
                            model = Console.ReadLine() ?? string.Empty;

                            do
                            {
                                try
                                {
                                    Console.WriteLine($"Enter the Serial Number for computer {i + 1}:");
                                    sn = Convert.ToInt32(Console.ReadLine());
                                    if (sn < 0 || sn > 999999999999)
                                        Console.WriteLine("Serial Number cannot be negative!!!");

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Please enter a numerical value!!!");
                                    sn = -1;
                                }
                            } while (sn < 0);

                            do
                            {
                                try
                                {
                                    Console.WriteLine($"Enter the Price for computer {i + 1}:");
                                    price = Convert.ToDouble(Console.ReadLine());

                                    if (price < 0)
                                        Console.WriteLine("Price cannot be negative!!!");

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Please enter a numerical value!!!");
                                    price = -1;
                                }
                            } while (price < 0);

                            computer[enteredComp] = new Computer(brand, model, sn, price);
                            computer[enteredComp].showComputer();
                            ++enteredComp;
                            --totalComputers;

                        }

                        Console.WriteLine($"You can add {totalComputers} more computers!!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Number of Computers!");
                    }
                }

                break;
            }

        case '2':
            {
                int index;
                if (Computer.noOfComputers > 0)
                {
                    Console.WriteLine("Enter the password: (You get 3 chances!)");
                    password = Console.ReadLine() ?? string.Empty;

                    if (password != "password")
                    {
                        for (int count = 2; count > 0; count--)
                        {
                            if (password == "password" || password == "PASSWORD")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"ERROR!! Try Again");
                                Console.WriteLine($"Enter the password: (You get {count} chances!)");
                                password = Console.ReadLine() ?? string.Empty;
                            }
                        }
                    }
                    if (password == "password" || password == "PASSWORD")
                    {
                        char choice = '0';

                        for (int i = 0; i < Computer.noOfComputers; i++)
                        {
                            Console.WriteLine($"Index Computer: {i}");
                            computer[i].showComputer();
                            Console.WriteLine();
                        }
                        do
                        {
                            try
                            {
                                Console.WriteLine("Which computer do you want to change? (index)");
                                index = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Please enter a numerical value!!!");

                                index = -1;
                            }
                        } while (index < 0);

                        if (index < Computer.noOfComputers)
                        {
                            do
                            {
                                try
                                {

                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("Which information of the computer would you like to change?");
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("| Press 1 to change Brand                                          |");
                                    Console.WriteLine("| Press 2 to change Model                                          |");
                                    Console.WriteLine("| Press 3 to change Serial Number                                  |");
                                    Console.WriteLine("| Press 4 to change Price                                          |");
                                    Console.WriteLine("| Press 0 to Quit                                                  |");
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("Please enter your choice : ");
                                    choice = Convert.ToChar(Console.ReadLine() ?? string.Empty);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("Please Enter a Valid Value!!!!");
                                    choice = 'u';
                                }
                                switch (choice)
                                {

                                    case '1':
                                        {
                                            Console.Write("New Brand: ");
                                            brand = Console.ReadLine() ?? string.Empty;
                                            computer[index].setBrand(brand);
                                            computer[index].showComputer();
                                            break;
                                        }

                                    case '2':
                                        {
                                            Console.Write("New Model: ");
                                            model = Console.ReadLine() ?? string.Empty;
                                            computer[index].setModel(model);
                                            computer[index].showComputer();
                                            break;
                                        }

                                    case '3':
                                        {
                                            do
                                            {
                                                try
                                                {
                                                    Console.Write("New Serial Number: ");
                                                    sn = Convert.ToInt64(Console.ReadLine());
                                                    if (sn < 0)
                                                        Console.WriteLine("Serial Number cannot be negative!!!");
                                                }
                                                catch (Exception)
                                                {

                                                    Console.WriteLine("Please enter a numerical value!!!");

                                                    sn = -1;
                                                }
                                            } while (sn < 0);
                                            computer[index].setSN(sn);
                                            computer[index].showComputer();
                                            break;
                                        }

                                    case '4':
                                        {
                                            do
                                            {
                                                try
                                                {
                                                    Console.Write("New Price: ");
                                                    price = Convert.ToDouble(Console.ReadLine());
                                                    if (price < 0)
                                                        Console.WriteLine("Price cannot be negative!!!");
                                                }
                                                catch (Exception)
                                                {
                                                    Console.WriteLine("Please enter a numerical value!!!");
                                                    price = -1;
                                                }
                                            } while (price < 0);
                                            computer[index].setPrice(price);
                                            computer[index].showComputer();
                                            break;
                                        }
                                }
                            } while (choice != '0');
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("Pargol Please, Choose a correct Index!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No computer found!!");
                }
                break;
            }
        case '3':
            {
                if (Computer.noOfComputers > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("Please Enter the Brand name you want to search :");
                    brand = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------------------");

                    int i = 0;
                    Boolean flag = true;
                    for (i = 0; i < Computer.noOfComputers; i++)
                    {
                        if (computer[i].getBrand().ToLower() == brand.ToLower())
                        {
                            computer[i].showComputer();
                            flag = false;
                        }

                    }

                    if (flag)
                    {
                        Console.WriteLine("The computer of this brand does not exist!!");
                    }

                }
                else
                {
                    Console.WriteLine("No computer found!!");
                }
                break;
            }
        case '4':
            {
                if (Computer.noOfComputers > 0)
                {


                    do
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine("Please Enter the price :");
                            price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------");

                            if (price < 0)
                                Console.WriteLine("Price must be positive!!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid value!!");
                            price = -1;
                        }

                    } while (price < 0);

                    int i = 0;
                    Boolean flag = true;
                    for (i = 0; i < Computer.noOfComputers; i++)
                    {
                        if (computer[i].getPrice() < price)
                        {
                            flag = false;
                            computer[i].showComputer();

                        }

                    }
                    if (flag)
                    {
                        Console.WriteLine("The computer under this price doesn't exist!!");
                    }

                }
                else
                {
                    Console.WriteLine("No computer found!!");
                }
                break;
            }

        case '5':
            {
                for (int i = 0; i < Computer.noOfComputers; i++)
                {
                    computer[i].showComputer();
                }
                Console.WriteLine($"The total number of computers created are: {Computer.findNumberOfCreatedComputers()}");
                break;
            }
    }
} while (option != '0');



string computerList = "computerList.txt";

try
{

    using (StreamWriter textList = new StreamWriter(computerList))
    {

        textList.WriteLine("List of computers in the computer store:\n");

        for (int i = 0; i < computer.Length; i++)
        {

            if (computer[i] != null)
            {

                textList.WriteLine("-------------------------------");

                textList.WriteLine($"{i + 1}. Computer:");

                textList.WriteLine($"\t\tBrand: {computer[i].getBrand()}");

                textList.WriteLine($"\t\tModel: {computer[i].getModel()}");

                textList.WriteLine($"\t\tSN:    {computer[i].getSN()}");

                textList.WriteLine($"\t\tPrice: ${computer[i].getPrice()}");

            }

        }

    }
}
catch (Exception exp)
{

    Console.Write(exp.Message);

}
Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("The fun is over, Thank you for participating. GOODBYEE!!");
Console.WriteLine("--------------------------------------------------------------------");
string[] textFile = System.IO.File.ReadAllLines(@"computerList.txt");
System.Console.WriteLine("\nContents of computerList.txt file:");
foreach (string line in textFile)
{
    Console.WriteLine("\t" + line);
}
