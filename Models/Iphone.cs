
using System;
using System.Collections;
namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        ArrayList lojaApp = new ArrayList();

        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}...");
            Thread.Sleep(3000);
            lojaApp.Add(nomeApp);
        }
           
        public override void ListarAplicativos()
        {
            foreach (var app in lojaApp)
            {
                Console.WriteLine(app.ToString());
            }
        }

        public override void DesinstalarAplicativos(string nomeApp)
        {
            if (lojaApp.Contains(nomeApp))
            {
                Console.WriteLine($"Desinstalando {nomeApp}...");
                Thread.Sleep(3000);
                lojaApp.Remove(nomeApp);
            }
            else
            {
                throw new Exception("Aplicativo  não encontrado");
            }

        }
    }
}