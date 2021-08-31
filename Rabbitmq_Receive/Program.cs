using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Rabbitmq_Receive
{
    class Program
    {
        static void Main(string[] args)
        {
            var connFactory = new ConnectionFactory { HostName = "localhost", Port = 5672 };          
            using (var connection = connFactory.CreateConnection())
            {                
                using (var channel = connection.CreateModel())
                {                    
                    TopicExchangeConsumer.Consume(channel);
                }
            }
        }
    }
}
