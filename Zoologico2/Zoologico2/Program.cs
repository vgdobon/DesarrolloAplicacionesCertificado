﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuidador paco = new Cuidador("Paco", "Martinez", 20.5, true);
            Animal juancho = new Animal("Juancho","burro","Marrón",10,true);

            juancho.Dormir(10);
            juancho.Comer("lechuga");

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine(paco.Nombre + " va a cobrar este mes: " + paco.Cobrar(160) + " \u20AC.");

            Animal animal = new Animal(null,null);

            Console.WriteLine(animal);

            Console.ReadLine();
        }
    }
}
