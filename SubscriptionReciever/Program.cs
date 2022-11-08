using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using System;

ServiceBusClient client;
ServiceBusProcessor processor;


client = new ServiceBusClient("Endpoint=sb://myportfolios.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=RLgvud41fAhu4K0XRk+2MJgPufXAS2BXT/0b6bCjMLs=");
processor = client.CreateProcessor("mytopic", "s2",new ServiceBusProcessorOptions());

try
{
    processor.ProcessMessageAsync += MessageHandler;
    processor.ProcessErrorAsync += ErrorHandler;

    await processor.StartProcessingAsync();
    Console.WriteLine("Lets wait for a minute and then you can press a key to end the processing..!!");
    Console.ReadKey();
    Console.WriteLine("\n Stopping the reciever");
    await processor.StopProcessingAsync();
    Console.WriteLine("stopped recieving messages");

}
finally
{

    await processor.DisposeAsync();
    await client.DisposeAsync();
}

async Task MessageHandler(ProcessMessageEventArgs args)
{
    string body = args.Message.Body.ToString();
    Console.WriteLine($" recieved:{body} from subscription");
    await args.CompleteMessageAsync(args.Message);

}

Task ErrorHandler(ProcessErrorEventArgs args)
{
    Console.WriteLine(args.Exception.ToString());
    return Task.CompletedTask;
}