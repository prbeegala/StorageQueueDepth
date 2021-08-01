# StorageQueueDepth

This Azure function is to Get the Azure Storage Queue Approximate Depths. Currently there is no way to monitor the depths of the Azure storage queues automatically and hence the need to retrieve the list of the depths. You can then hook this data up to App Insights to alert when certain thresholds regards to the queue depths are breached.

**GetDepthAllQueues.cs** - This function gets the list of all the queues in the given connection string, and retrives the depth of each queue

**GetDepthSingleQueue.cs** - This function gets the depth of the named queue.