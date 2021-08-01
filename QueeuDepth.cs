using System;
using Microsoft.WindowsAzure.Storage;
using System.Net;
using Newtonsoft.Json;
using Azure.Storage.Queues; 
using Azure.Storage.Queues.Models; 
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;


namespace Company.Function
{
    public static class QueeuDepth
    {
        [FunctionName("QueeuDepth")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
            // Get the connection string from app settings
            // string connectionString = System.Environment.GetEnvironmentVariable("StorageConnectionString", EnvironmentVariableTarget.Process);
            
            // //Get all the queues in the given connection string
            // QueueServiceClient serviceClient = new QueueServiceClient(connectionString);
            // var myqueues = serviceClient.GetQueues().AsPages();
            // var myqueue_client = serviceClient.GetQueueClient("processorders");
            // foreach (Azure.Page<QueueItem> queuePage in myqueues)
            // {
            //     foreach (QueueItem q in queuePage.Values)
            //     {
            //         myqueue_client = serviceClient.GetQueueClient(q.Name);
            //         QueueProperties properties2 = myqueue_client.GetProperties();
            //         int cachedMessagesCount2 = properties2.ApproximateMessagesCount;
            //         Console.WriteLine(q.Name+"==="+cachedMessagesCount2);
            //     }

            // }
            /* For reference, to get the count from a named queue
            var queueName = "processorders";
            QueueClient queueClient = new QueueClient(connectionString, queueName);
            QueueProperties properties = queueClient.GetProperties();
            // Retrieve the cached approximate message count.
            int cachedMessagesCount = properties.ApproximateMessagesCount;
            */
            
        }
    }
}
