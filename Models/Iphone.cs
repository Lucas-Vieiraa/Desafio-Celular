
using System;
using System.Collections;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone 
    {
   
        public Iphone() : base() {}

        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }


        ArrayList lojaApp = new ArrayList();

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}...");
            Console.WriteLine();
            Thread.Sleep(3000);
            lojaApp.Add(nomeApp);
            Console.WriteLine($"{nomeApp} Instalado");
            Console.WriteLine();
        }

        public override void ListarAplicativos()
        {
            Console.WriteLine("Aplicativos Instalados: ");
            Console.WriteLine();
            foreach (var app in lojaApp)
            {
                Console.WriteLine(app.ToString());
               
            }
            Console.WriteLine();
        }

        public override void DesinstalarAplicativos(string nomeApp)
        {
            if (lojaApp.Contains(nomeApp))
            {
                Console.WriteLine($"Desinstalando {nomeApp}...");
                Console.WriteLine();
                Thread.Sleep(3000);
                lojaApp.Remove(nomeApp);
                Console.WriteLine($"{nomeApp} Desinstalado");
                Console.WriteLine();
            }
            else
            {
                throw new Exception("Aplicativo  não encontrado");


            }
        } 
    }
}