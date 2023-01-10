using DesafioPOO.Models;





Console.WriteLine("\n");

Console.WriteLine("***********************SMARTPHONE NOKIA*****************************");
Smartphone nokia = new Nokia(numero:"(92)99999-8888", modelo: " NKPPQ0356", imei: "000001111122223333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("***********************SMARTPHONE IPHONE********************************");
Smartphone iphone = new Iphone(numero: "(92)99999-8888", modelo:"IP6589", imei: "444455556666777777777", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");
