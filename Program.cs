using DesafioPOO.Models;

Smartphone nokia = new Nokia("999844751","Nokia 5.4", "123456789",32);
Smartphone iphone = new Iphone("987654321","8 plus", "987654321",64);

Console.WriteLine("\n");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Tiktok");
nokia.MostrarNumero();
nokia.ReceberLigacao();

Console.WriteLine("\n");
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.InstalarAplicativo("Instagram");
iphone.MostrarNumero();
iphone.ReceberLigacao();