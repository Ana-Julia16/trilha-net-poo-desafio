using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testes com Nokia");
            Smartphone nokia = new Nokia(numero: "11999990000", modelo: "Nokia 3310", imei: "000111222333", memoria: 32);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");
            nokia.ReceberLigacao();

            Console.WriteLine();
            Console.WriteLine("Testes com iPhone");
            Smartphone iphone = new Iphone(numero: "11988887777", modelo: "iPhone 12", imei: "999888777666", memoria: 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
            iphone.Ligar();
        }
    }
}
