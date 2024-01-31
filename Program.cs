using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11976405388", modelo: "8", imei: "7", memoria: 80);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-----------------------");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "11976405388", modelo: "15", imei: "9", memoria: 95);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

