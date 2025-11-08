using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de criação (ajuste os parâmetros conforme seus construtores)
        var nokia = new Nokia("1111-2222", "Nokia 3310", "IMEI-NOKIA-0001", 32);
        var iphone = new Iphone("3333-4444", "iPhone 12", "IMEI-IPHONE-0001", 128);

        // Testes básicos
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");
        nokia.ReceberLigacao();
        nokia.Desligar();

        System.Console.WriteLine();

        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");
        iphone.ReceberLigacao();
        iphone.Desligar();
    }
}