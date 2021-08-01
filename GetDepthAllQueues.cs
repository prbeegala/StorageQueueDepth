using System;
using Azure.Storage.Queues; 
using Azure.Storage.Queues.Models; 
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace prbeegala.functions
{
    public static class GetDepthAllQueues
    {
        [FunctionName("GetDepthAllQueues")]
        public static void Run([TimerTrigger("*/2 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
            // Get the connection string from app settings
            string connectionString = System.Environment.GetEnvironmentVariable("StorageConnectionString", EnvironmentVariableTarget.Process);
            
            //Get all the queues in the given connection string
            QueueServiceClient serviceClient = new QueueServiceClient(connectionString);
            var myqueues = serviceClient.GetQueues().AsPages();
            var myqueue_client = serviceClient.GetQueueClient("processorders");
            foreach (Azure.Page<QueueItem> queuePage in myqueues)
            {
                foreach (QueueItem q in queuePage.Values)
                {
                    myqueue_client = serviceClient.GetQueueClient(q.Name);
                    QueueProperties properties = myqueue_client.GetProperties();
                    int cachedMessagesCount = properties.ApproximateMessagesCount;
                    log.Info($"C# Timer trigger function executed at: {q.Name+"==="+cachedMessagesCount}");
                }

            }            
        }
    }
}
