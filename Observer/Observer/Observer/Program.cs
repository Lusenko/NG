using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            string u_vacancy;
            string u_companyName;
            string u_info;
            string u_emploer;
            int id = 1; 
            string choice = "";
          
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
                            u_vacancy = Console.ReadLine();

                        } while (u_vacancy == "");

                        do
                        {
                            Console.Write("Company name: ");
                            u_companyName = Console.ReadLine();

                        } while (u_companyName == "");

                        do
                        {
                            Console.Write("Info: ");
                            u_info = Console.ReadLine();

                        } while (u_info == "");

                        do
                        {
                            Console.Write("Emploer: ");
                            u_emploer = Console.ReadLine();

                        } while (u_emploer == "");

                        service.NewJob(new Job(u_vacancy, u_companyName, u_info, u_emploer));
                        break;

                    case "3":
                        do
                        {
                            Console.Write("Vacancy: ");
                            u_vacancy = Console.ReadLine();

                        } while (u_vacancy == "");

                        do
                        {
                            Console.Write("Company name: ");
                            u_companyName = Console.ReadLine();

                        } while (u_companyName == "");

                        do
                        {
                            Console.Write("Info: ");
                            u_info = Console.ReadLine();

                        } while (u_info == "");

                        do
                        {
                            Console.Write("Emploer: ");
                            u_emploer = Console.ReadLine();

                        } while (u_emploer == ""); ;
                        service.RemoveJob(new Job(u_vacancy, u_companyName, u_info, u_emploer));
                        break;

                    case "4":
                        Console.WriteLine("Enter id:");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (id <= listerners.Count)
                        {
                            Console.WriteLine("What you want: \n" +
                           "1. Check your message:\n" +
                           "2. Subscribe:\n" +
                           "3. Unsubscribe:\n");
                            choice = Console.ReadLine();

                            if (choice == "1")
                                listerners[id - 1].showMess();
                            if (choice == "2")
                                service.eventManager.subscriber(listerners[id - 1]);
                            if (choice == "3")
                                service.eventManager.unsubscribe(listerners[id - 1]);
                        }
                        break;

                }
            }
        }
    }
}