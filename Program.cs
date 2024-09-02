using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new("123456789", "Nokia 3310", "123456789", 16);
Iphone iphone = new("987654321", "iPhone 12", "987654321", 128);

Console.WriteLine(nokia.Modelo);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Telegram");
nokia.InstalarAplicativo("Signal");
nokia.LerAplicativosInstalados();

Console.WriteLine("\n"+iphone.Modelo);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Facebook");
iphone.InstalarAplicativo("Twitter");
iphone.LerAplicativosInstalados();
