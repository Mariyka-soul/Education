using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork3._1
{
    internal class RequestsService
    {
        public static List<Request> FilterByData(List<Request> requests)
        {
            Console.WriteLine("Enter topic:");
            var topic = Console.ReadLine();

            return Filter(requests, el => el.Data.Topic == topic.Trim().ToLower());
        }

        public static List<Request> SortByTime(List<Request> requests)
        {
            return requests.OrderByDescending(el => el.Timestamp).ToList();
        }

        public static List<Request> SortByData(List<Request> requests)
        {
            return Sort(requests, el => el.Data.Topic);
        }

        public static List<Request> FilterBySender(List<Request> requests)
        {
            Console.Write("Enter sender role:");
            var role = Console.ReadLine();

            return Filter(requests, el => el.Sender.UserRole == role.Trim().ToLower());
        }

        public static List<Request> ConcatenateLists(List<Request> requests)
        {
            var newList = new List<Request>
        {
            new Request
            {
                Name = "name12",
                Timestamp = DateTime.Now,
                Data = new Data
                {
                    Topic = "topic1",
                    Message = "message1",
                },
                Sender = new User
                {
                    UserId = Guid.NewGuid(),
                    UserRole = "user1"
                },
            },

            new Request
            {
                Name = "name22",
                Timestamp = DateTime.Now,
                Data = new Data
                {
                    Topic = "topic2",
                    Message = "message2",
                },
                Sender = new User
                {
                    UserId = Guid.NewGuid(),
                    UserRole = "user2"
                },
            },

            new Request
            {
                Name = "name32",
                Timestamp = DateTime.Now,
                Data = new Data
                {
                    Topic = "topic3",
                    Message = "message3",
                },
                Sender = new User
                {
                    UserId = Guid.NewGuid(),
                    UserRole = "user3"
                },
            },
        };

            return Concat(requests, newList);
        }

        private static List<Request> Filter(List<Request> request, Func<Request, bool> func)
        {
            return request
                .Where(func)
                .ToList();
        }

        private static List<Request> Concat(List<Request> request, List<Request> requests)
        {
            return request
                .Concat(requests)
                .ToList();
        }

        private static List<Request> Sort(List<Request> request, Func<Request, string> func)
        {
            return request
                .OrderBy(func)
                .ToList();
        }
    }
}
