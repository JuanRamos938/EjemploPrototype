using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploPrototype
{
    public class Carro :ICloneable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public object Clone()
        {
           return this.MemberwiseClone();
        }
    }
}
