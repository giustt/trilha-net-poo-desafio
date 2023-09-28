using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone n = new Nokia( numero: "9564654654",  modelo: "n001", imei: "11111111" , memoria: 64 );
Smartphone i = new Iphone( numero: "1321321312",  modelo: "i001", imei: "22222222" , memoria: 128 );

Console.WriteLine("Testando os celulares: ");


Console.WriteLine("\nTeste Nokia: ");
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Whatsapp");
n.InstalarAplicativo("Instagram");

Console.WriteLine("\nTeste Iphone: ");
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Telegram");
i.InstalarAplicativo("TikTok");