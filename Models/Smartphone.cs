using System;
using System.Collections;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        public Smartphone(){}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void NovoDispositivo()
        {
            Console.WriteLine("---------------------------");
            Console.Write("Numero: ");
            Numero = Console.ReadLine();
            Console.Write("Modelo: ");
            Modelo = Console.ReadLine();
            Console.Write("IMEI: ");
            IMEI = Console.ReadLine();
            Console.Write("Memoria: ");
            Memoria = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Novo Dispositivo Criado!");
            Console.WriteLine("---------------------------");
        }

        public void ConfiguracoesDoDispositivo() 
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine($"Configuração Do {Modelo}");
            Console.WriteLine();
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void ListarAplicativos();

        public abstract void DesinstalarAplicativos(string nomeApp);
    }
}