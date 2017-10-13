using System;
using System.Collections.Generic;
using System.Text;

namespace MotobikeStore
{
    class Program
    {
        static void Main(string[] args)
        {
            MotobikeAgent motobikeAgent = new MotobikeAgent();
            int choice = 0;

            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. List");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Iswarrannty");
                Console.WriteLine("5. quit");
                choice = Wrappers.GetInt("Enter your choice: ");

                switch (choice)
                { 
                    case 1:
                        BuyMotobikeCustomer bmc = GetBuyMotobikeCustomer();
                        motobikeAgent.Add(bmc);
                        break;
                    case 2:
                        List(motobikeAgent);
                        break;
                    case 3:
                        if (motobikeAgent.GetCount() == 0)
                        {
                            Console.WriteLine("List is empty");
                        }
                        else
                        {
                            string name = Wrappers.GetString("Enter customer name: ");
                            Search(name, motobikeAgent);
                        }
                        break;
                    case 4:
                        if (motobikeAgent.GetCount() == 0)
                        {
                            Console.WriteLine("List is empty");
                        }
                        else
                        {
                            string namecus = Wrappers.GetString("Enter customer name: ");
                            string code = Wrappers.GetString("Enter motobike code: ");
                            Iswarranty(namecus, code, motobikeAgent);
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid your choice");
                        break;
                }
            } while (true);
        }

        public static BuyMotobikeCustomer GetBuyMotobikeCustomer()
        {
            BuyMotobikeCustomer buyMotobike = new BuyMotobikeCustomer();
            Motobike motobike;

            buyMotobike.Name = Wrappers.GetString("Enter customer name: ");
            buyMotobike.Address = Wrappers.GetString("Enter address: ");
            buyMotobike.Phone = Wrappers.GetString("Enter phone: ");
            buyMotobike.Email = Wrappers.GetEmail("Enter email: ");
            Console.WriteLine("Motobike type:");
            Console.WriteLine("1. New motobike");
            Console.WriteLine("2. Old motobike");
            do
            {
                int type = Wrappers.GetInt("Enter your choice: ");

                if (type == 1)
                {
                    motobike = new NewMotobike();
                    break;
                }
                else if (type == 2)
                {
                    motobike = new OldMotobike();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid your choice");
                }
            } while (true);

            motobike.Code = Wrappers.GetString("Enter Code: ");
            motobike.Name = Wrappers.GetString("Enter motobike Name: ");
            motobike.Price = Wrappers.GetDouble("Enter price: ");
            motobike.SaleDate = Wrappers.GetDateTime("Enter sale date: ");

            buyMotobike.BuyMotobike = motobike;
            return buyMotobike;
        }

        public static void List(MotobikeAgent mbAgent)
        {
            if (mbAgent.GetCount() == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                foreach (BuyMotobikeCustomer bmc in mbAgent.MotobikeList)
                {
                    Console.WriteLine("{0}\t\t{1}\n{2}\t\t{3}",bmc.Name,bmc.Address,bmc.Phone,bmc.Email);
                    Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-15}{4,-5}{5,-15}", bmc.BuyMotobike.Code, bmc.BuyMotobike.Name, bmc.BuyMotobike.Price, bmc.BuyMotobike.Type, bmc.BuyMotobike.Warranty, bmc.BuyMotobike.SaleDate);

                }
            }
        }

        public static void Search(string name,MotobikeAgent mbAgent)
        {
            int count=0;
            foreach (BuyMotobikeCustomer bmc in mbAgent.MotobikeList)
            {
                if (bmc.Name.Equals(name))
                {
                    Console.WriteLine("{0}\t\t{1}\n{2}\t\t{3}", bmc.Name, bmc.Address, bmc.Phone, bmc.Email);
                    Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-15}{4,-5}{5,-15}", bmc.BuyMotobike.Code, bmc.BuyMotobike.Name, bmc.BuyMotobike.Price, bmc.BuyMotobike.Type, bmc.BuyMotobike.Warranty, bmc.BuyMotobike.SaleDate);
                }
                count++;
                
            }

            if (count == 0)
            {
                Console.WriteLine("Does not have any customer have name {0}", name);
            }
        }

        public static void Iswarranty(string name, string code,MotobikeAgent mbAgent)
        {
            Boolean check =false;
            foreach (BuyMotobikeCustomer bmc in mbAgent.MotobikeList)
            {
                if (bmc.Name == name)
                {
                    if (bmc.BuyMotobike.Code == code)
                    {
                        Console.WriteLine("{0} has {1} days warranty",bmc.BuyMotobike.Name,bmc.BuyMotobike.WarrantyRemain);

                        if (bmc.BuyMotobike.WarrantyRemain <= 0)
                        {
                            Console.WriteLine("This product not in warranty");
                        }
                        else
                        {
                            Console.WriteLine("This product still in warranty");
                        }
                    }

                    check = true;
                }

                
            }
            if (check == false)
            {
                Console.WriteLine("Does not have customer or customer does not match with this code");
            }
        }

    }
}
