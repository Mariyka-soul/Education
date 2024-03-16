namespace HomeWork3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var requests = new List<Request>
            {
                new Request
                {
                    Name = "name1",
                    Timestamp = DateTime.Now,
                    Data = new Data
                    {
                        Topic = "topic1",
                        Message = "message1",
                    },
                    Sender = new User
                    {
                        UserId =  Guid.NewGuid(),
                        UserRole = "user1"
                    },
                },

                new Request
                {
                    Name = "name2",
                    Timestamp = DateTime.Now,
                    Data = new Data
                    {
                        Topic = "topic2",
                        Message = "message2",
                    },
                    Sender = new User
                    {
                        UserId =  Guid.NewGuid(),
                        UserRole = "user2"
                    },
                },

                new Request
                {
                    Name = "name3",
                    Timestamp = DateTime.Now,
                    Data = new Data
                    {
                        Topic = "topic3",
                        Message = "message3",
                    },
                    Sender = new User
                    {
                        UserId =  Guid.NewGuid(),
                        UserRole = "user3"
                    },
                },
            };

            var console = new ConsoleService(requests);
            console.Start();
        }
    }
}
