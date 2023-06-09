﻿using RabbitMQ.Client;
using ShippingApp.Models;
using System.Text.Json;
using System.Text;

namespace ShippingApp.Services
{
    public class MessageProducerService : IMessageProducerService
    {
		private readonly IConfiguration configuration;

		public MessageProducerService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        //----------- A Function to produce message in queue ------------>
        public ResponseModel producer(string queueName, object message)
        {
            //connecting with rabbit mq
            var factory = new ConnectionFactory
            {
                Uri
                = new Uri(configuration.GetSection("RabbitMQ:Url").Value!)
            };
            //Configuring Queue
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            channel.QueueDeclare(queueName,
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            //data to send in body
            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));

            channel.BasicPublish("", queueName,null, body);
            return new ResponseModel();
        }
    }
}
