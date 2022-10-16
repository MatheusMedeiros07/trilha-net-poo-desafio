using DesafioPOO.Models;

Console.WriteLine("\nSmarthphone iPhone...");

Iphone iphone1 = new Iphone("89232343", "iPhone 14 pro Max", "Cy378383", 8);
Console.WriteLine($"O número do Smarthphone é: { iphone1.Numero}");
iphone1.Ligar("(11)95154-0405");
iphone1.ReceberLigacao("(11)95154-0405");
iphone1.InstalarAplicativo("WhatsApp");
iphone1.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmarthphone Nokia...");

Nokia nokia1 = new Nokia("62847390", "Nokia Ilumia", "357t85ba43", 6);
Console.WriteLine($"O número do Smarthphone é: { nokia1.Numero}");
nokia1.Ligar("(11)90504-4515");
nokia1.ReceberLigacao("(11)90504-4515");
nokia1.InstalarAplicativo("Instagram");
nokia1.InstalarAplicativo("Telegram");
nokia1.InstalarAplicativo("TikTok");
