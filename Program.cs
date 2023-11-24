using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Testando a classe Iphone
Smartphone iphone = new Iphone("123456789", "iPhone 13", "ABCD1234", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// Testando a classe Nokia
Smartphone nokia = new Nokia("987654321", "Nokia 3310", "EFGH5678", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");