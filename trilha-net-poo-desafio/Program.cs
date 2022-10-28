using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "721-5445", modelo: "NSan", imei: "123456789", memoria: 256);
nokia.InstalarAplicativo("TIKTOK");
nokia.Ligar();

Console.WriteLine("________________________________________________________________");

Smartphone iphone = new Iphone(numero: "9999-9999", modelo: "20pro", imei: "56789", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");


