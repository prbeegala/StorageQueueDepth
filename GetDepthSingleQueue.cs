using System;
using Microsoft.WindowsAzure.Storage;
using System.Net;
using Newtonsoft.Json;
using Azure.Storage.Queues; 
using Azure.Storage.Queues.Models; 
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace prbeegala.functions
{
    public static class GetDepthSingleQueue
    {
        [FunctionName("GetDepthSingleQueue")]
        public static void Run([TimerTrigger("*/3 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
            // Get the connection string from app settings
             string connectionString = System.Environment.GetEnvironmentVariable("StorageConnectionString", EnvironmentVariableTarget.Process);
            
            var queueName = "processorders";
            QueueClient queueClient = new QueueClient(connectionString, queueName);
            QueueProperties properties = queueClient.GetProperties();
            // Retrieve the cached approximate message count.
            int cachedMessagesCount = properties.ApproximateMessagesCount;
            log.Info($"C# Timer trigger function executed at: {cachedMessagesCount}");
        }
    }
}
