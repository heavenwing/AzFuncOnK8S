using System;
using System.Threading;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Zyg.Demo
{
    public static class MyMqFunction
    {
        [FunctionName("MyMqFunction")]
        public static void Run(
            [RabbitMQTrigger("queue", ConnectionStringSetting = "RabbitMqConnection")] string inputMessage,
            [RabbitMQ(QueueName = "downstream", ConnectionStringSetting = "RabbitMqConnection")] out string outputMessage,
             ILogger log)
        {
            Thread.Sleep(5000);
            outputMessage = inputMessage;
            log.LogInformation($"RabittMQ output binding function sent message: {outputMessage}");
        }
    }
}
