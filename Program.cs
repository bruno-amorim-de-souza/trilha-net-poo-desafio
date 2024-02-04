using DesafioPOO.Models;

// (TODO: Realizar os testes com as classes Nokia e Iphone) OK
System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1895040", modelo: "Modelo Nokia 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine(("\n"));

System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "111222", modelo: "Modelo Iphone 1", imei: "1222222", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");