using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeWork3._1
{
    internal class ConsoleService
    {
        private List<Request> requests1;

        public ConsoleService(List<Request> requests)
        {
            requests1 = requests;
        }

        public void Start()
        {
            string operation;
            do
            {
                Console.Clear(); 
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Sort by data");
                Console.WriteLine("2. Filter by sender");
                Console.WriteLine("3. Concatenate lists");
                Console.WriteLine("4. Sort by time stamp");
                Console.WriteLine("5. Filter by data topic");

                Console.Write("\nEnter an operation:");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        Write(RequestsService.SortByData(requests1));
                        break;
                    case "2":
                        Write(RequestsService.FilterBySender(requests1));
                        break;
                    case "3":
                        Write(RequestsService.ConcatenateLists(requests1));
                        break;
                    case "4":
                        Write(RequestsService.SortByTime(requests1));
                        break;
                    case "5":
                        Write(RequestsService.FilterByData(requests1));
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(); 
            } while (operation != "0");
        }

        private void Write(List<Request> requests)
        {
            foreach (var request in requests)
            {
                Console.WriteLine($"{request.Name} {request.Timestamp} Data: {request.Data.Topic} {request.Data.Message} Sender: {request.Sender.UserId} {request.Sender.UserRole}\n");
            }
        }
    }
}
