using DesafioPOO.Models;

Console.WriteLine();
Console.WriteLine("Smartphone Nokia: ");
Smartphone celularNokia = new Nokia();

Console.WriteLine();
celularNokia.NovoDispositivo();

Console.WriteLine();
celularNokia.ConfiguracoesDoDispositivo();


Console.WriteLine();
celularNokia.Ligar();


Console.WriteLine();
celularNokia.InstalarAplicativo("Facebook");
celularNokia.InstalarAplicativo("Tik Tok");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone: ");
Smartphone celularIphone = new Iphone();


Console.WriteLine();
celularIphone.NovoDispositivo();

Console.WriteLine();
celularIphone.ConfiguracoesDoDispositivo();

Console.WriteLine();
celularIphone.ReceberLigacao();


Console.WriteLine();
celularIphone.InstalarAplicativo("Instagram");

celularIphone.InstalarAplicativo("Whatsapp");

celularIphone.InstalarAplicativo("tik tok");

Console.WriteLine();
celularIphone.ListarAplicativos();

celularIphone.DesinstalarAplicativos("Instagram");

celularIphone.ListarAplicativos();