using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11976405388", modelo: "8", imei: "222222222", memoria: 80);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-----------------------");


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "11976405388", modelo: "8", imei: "222222222", memoria: 80);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

