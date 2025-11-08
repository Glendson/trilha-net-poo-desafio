using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; }
        public string Modelo { get; }
        public string IMEI { get; }
        public int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"{Modelo} ({Numero}): Ligando...");
        }

        public void Desligar()
        {
            Console.WriteLine($"{Modelo} ({Numero}): Desligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo} ({Numero}): Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}