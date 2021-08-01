# StorageQueueDepth

This Azure function is to Get the Azure Storage Queue Approximate Depths. Currently there is no way to monitor the depths of the Azure storage queues automatically and hence the need to retrieve the list of the depths. You can then hook this data up to App Insights to alert when certain thresholds regards to the queue depths are breached.

**GetDepthAllQueues.cs** - This function gets the list of all the queues in the given connection string, and retrives the depth of each queue

**GetDepthSingleQueue.cs** - This function gets the depth of the named queue.

**References** - https://docs.microsoft.com/en-us/azure/storage/queues/storage-dotnet-how-to-use-queues?tabs=dotnet

https://blog.kloud.com.au/2017/09/07/monitoring-azure-storage-queues-with-application-insights-and-azure-monitor/

https://stackoverflow.com/questions/63986485/get-access-to-all-queues-in-azure-storage-account
