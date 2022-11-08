using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using System;

//creating a Client Object

ServiceBusClient client;
ServiceBusSender sender;

// Creating a sender object

//No of Messages

const int noOfMessages = 3;

//initilizing Client and Sender with Azure credentials

client = new ServiceBusClient("Endpoint=sb://myportfolios.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=RLgvud41fAhu4K0XRk+2MJgPufXAS2BXT/0b6bCjMLs=");
sender = client.CreateSender("mytopic");
//Creating batch
using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

    for (int i = 0; i <= noOfMessages; i++)
    { 
        if(!messageBatch.TryAddMessage(new ServiceBusMessage($"Message{i}")))

        {
            throw new Exception($"the message{i} is to large to fit in the batch");
        }
    }
    try
    {
        await sender.SendMessagesAsync(messageBatch);
        Console.WriteLine($"A Batch of {noOfMessages} has been published to the object");
    }
    finally
    {
        await sender.DisposeAsync();
        await client.DisposeAsync();
    }
    Console.WriteLine("Press any key to stop the Execution");
    Console.ReadKey();


