using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Threading;

namespace patern3
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string u_vacancy;
            string u_companyName;
            string u_info;
            string u_emploer;
            string choice = "";

            Service service = new Service();
            List<Listener> listerners = new List<Listener>();

            while(choice != "0")
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
                        Console.WriteLine("Vacancy: ");
                        u_vacancy = Console.ReadLine();

                        Console.WriteLine("Company name: ");
                        u_companyName = Console.ReadLine();

                        Console.WriteLine("Info: ");
                        u_info = Console.ReadLine();

                        Console.WriteLine("Emploer: ");
                        u_emploer = Console.ReadLine();
                        service.NewJob(new Job(u_vacancy, u_companyName, u_info, u_emploer));
                        break;

                    case "3":
                        Console.WriteLine("Vacancy: ");
                        u_vacancy = Console.ReadLine();

                        Console.WriteLine("Company name: ");
                        u_companyName = Console.ReadLine();

                        Console.WriteLine("Info: ");
                        u_info = Console.ReadLine();

                        Console.WriteLine("Emploer: ");
                        u_emploer = Console.ReadLine();
                        service.RemoveJob(new Job(u_vacancy, u_companyName, u_info, u_emploer));
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