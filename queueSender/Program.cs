using Azure.Messaging.ServiceBus;
using Azure.Identity;
using System;


        ServiceBusClient client;

        ServiceBusSender sender;


        const int no_of_messages = 3;
        var clientOptions = new ServiceBusClientOptions
        {
            TransportType = ServiceBusTransportType.AmqpWebSockets
        };

        client = new ServiceBusClient("Endpoint=sb://cakeshop.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=WedJwIXsPiLaZttjFRnmN2QbsM1yKH2u+Ew2EHOt9hc=", clientOptions);
        sender = client.CreateSender("myqueue");

        //creating a batch

        using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
        for (int i = 0; i < no_of_messages; i++)
        {
            //try adding a message to the batch
            if (!messageBatch.TryAddMessage(new ServiceBusMessage($"Message {i}")))
            {
                throw new Exception($"The Message is too large to fit in the batch");
            }
        }
        try
        {
            await sender.SendMessagesAsync(messageBatch);
            Console.WriteLine($"A Batch of {no_of_messages} has been published to the Queue");
        }
        finally
        {
            //Need to cleanup objects and Resources in the network
            await sender.DisposeAsync();
            await client.DisposeAsync();

        }
        Console.WriteLine("press any key to close the application");
        Console.ReadKey();
    
