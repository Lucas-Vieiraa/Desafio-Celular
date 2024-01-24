using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone celularNokia = new Nokia("1234-5678", "Modelo Nokia", "IMEI: 11111111", 64);

celularNokia.Ligar();

celularNokia.InstalarAplicativo("Facebook");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone: ");
Smartphone celularIphone = new Nokia("8765-4321", "Modelo Iphone", "IMEI: 22222222", 128);

celularIphone.ReceberLigacao();

celularIphone.InstalarAplicativo("Instagram");

celularIphone.InstalarAplicativo("Whatsapp");

celularIphone.InstalarAplicativo("tik tok");

celularIphone.ListarAplicativos();

celularIphone.DesinstalarAplicativos("Instagram");

celularIphone.ListarAplicativos();