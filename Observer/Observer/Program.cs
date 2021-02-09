using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Threading;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;            
            string choice = "";

            Val val = new Val();
            Service service = new Service();
            List<Listener> listerners = new List<Listener>();

            while (choice != "0")
            {
                Console.WriteLine("Enter your choice: \n" +
                    "1.New user:\n" +
                    "2.New job:\n" +
                    "3.Remove job:\n" +
                    "4.Select user:\n");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": listerners.Add(new Listener()); break;

                    case "2":
                        do
                        {
                            Console.Write("Vacancy: ");
                            val.Vacancy = Console.ReadLine();

                        } while (val.Vacancy == "");

                        do
                        {
                            Console.Write("Company name: ");
                            val.CompanyName = Console.ReadLine();

                        } while (val.CompanyName == "");

                        do
                        {
                            Console.Write("Info: ");
                            val.Info = Console.ReadLine();

                        } while (val.Info == "");

                        do
                        {
                            Console.Write("Emploer: ");
                            val.Emploer = Console.ReadLine();

                        } while (val.Emploer == "");

                        service.NewJob(new Job(val.Vacancy, val.CompanyName, val.Info, val.Emploer));
                        break;

                    case "3":
                        do
                        {
                            Console.Write("Vacancy: ");
                            val.Vacancy = Console.ReadLine();

                        } while (val.Vacancy == "");

                        do
                        {
                            Console.Write("Company name: ");
                            val.CompanyName = Console.ReadLine();

                        } while (val.CompanyName == "");

                        do
                        {
                            Console.Write("Info: ");
                            val.Info = Console.ReadLine();

                        } while (val.Info == "");

                        do
                        {
                            Console.Write("Emploer: ");
                            val.Emploer = Console.ReadLine();

                        } while (val.Emploer == ""); ;
                        service.RemoveJob(new Job(val.Vacancy, val.CompanyName, val.Info, val.Emploer));
                        break;

                    case "4":
                        Console.WriteLine("Enter id:");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("What you want: \n" +
                            "1. Check your message:\n" +
                            "2. Subscribe:\n" +
                            "3. Unsubscribe:\n");
                        choice = Console.ReadLine();

                        if (choice == "1")
                            listerners[id].showMess();
                        if (choice == "2")
                            service.eventManager.subscriber(listerners[id]);
                        if (choice == "3")
                            service.eventManager.unsubscribe(listerners[id]);
                        break;

                }
            }
        }
    }
}