using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 01", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "456", modelo: "Modelo 02", imei: "15678943", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");