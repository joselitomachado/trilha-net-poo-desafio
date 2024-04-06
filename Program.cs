using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new(numero: "654321", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");