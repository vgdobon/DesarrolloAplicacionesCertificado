using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico2
{
    public class Animal
    {

        private String Nombre;

        public String Especie { get; set; }

        public String Color { get; set; }

        public int Edad
        {
            get { return this.Edad; }
            set
            {
                if (value > 20 || value < 0)
                {
                    Edad = 0;
                }
                else
                {
                    Edad = value;
                }
            } }

        public Boolean TieneHambre {  get; set; }

        public Animal(string nombre, string especie)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Especie = especie ?? throw new ArgumentNullException(nameof(especie));
        }

        public Animal(string nombre, string especie, string color, int edad, bool tieneHambre)
        {
            Nombre = nombre;
            Especie = especie;
            Color = color;
            Edad = edad;
            TieneHambre = tieneHambre;
        }

        public String GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(String nombre)
        {
            this.Nombre = nombre;
        }

        public void Dormir(int horas)
        {
            Console.WriteLine("El/la " + Especie + " " + Nombre + " lleva durmiendo " + " " +  horas + " horas");
        }

        public void Comer(String comida)
        {
            Console.WriteLine("El/la " + Especie + " " + Nombre + " está comiendo " + comida + ".");
        }
    }
}
