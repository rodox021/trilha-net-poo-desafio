using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(_numero: "548641235", _modelo: "TIJOLÃO", _imei: "48348346534IM", _memoria: 256);
Iphone iphone = new Iphone(_numero: "123456789", _modelo: "PRO MAX PICUDO", _imei: "48348346534IM", _memoria: 256);


Console.Clear();
System.Console.WriteLine($"Smartphone Nokia : {nokia.PegarModelo()} ");
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();

System.Console.WriteLine("\n\n");


System.Console.WriteLine($"Iphone : {iphone.PegarModelo()} ");
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();

