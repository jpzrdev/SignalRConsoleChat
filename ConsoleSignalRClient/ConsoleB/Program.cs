using System;
using Microsoft.AspNetCore.SignalR.Client;

var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7146/chat")
                .Build();

connection.On<string, string>("ReceiveMessage", (user, message) =>
{
    Console.WriteLine($"{user} diz: {message}");
});

await connection.StartAsync();

Console.WriteLine("Conectado ao serviço do SignalR.");

while (true)
{
    var message = Console.ReadLine();

    await connection.InvokeAsync("SendMessage", "Aplicativo B", message);
}