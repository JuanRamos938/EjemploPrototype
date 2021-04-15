using System;

namespace EjemploPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "Ferrari", Modelo = "Spider" };
            Carro carroClonado = carro.Clone() as Carro;
            carroClonado.Modelo = "Monza";

            Console.WriteLine("*********OBJETO ORIGINAL**********");
            Console.WriteLine("Marca: " + carro.Marca + " Modelo: " + carro.Modelo + "\n");
            Console.WriteLine("*********OBJETO CLONADO**********");
            Console.WriteLine("Marca: " + carroClonado.Marca + " Modelo: " + carroClonado.Modelo + "\n");
            Console.ReadKey();
        }
    }
}
