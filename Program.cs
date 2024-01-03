using DesafioPOO.Models;

Console.WriteLine("Play Store");
Smartphone nokia = new Nokia(numero: "123123", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("App Store");
Smartphone iphone = new Iphone(numero: "456456", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");