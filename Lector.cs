using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_AyC
{
    class Lector
    {
        private String nombre;
        private String ci;
        public Lector(String nombre, String ci)
        {
            this.nombre = nombre;
            this.ci = ci;
        }
        public void mostrar()
        {
            Console.WriteLine("Nombre del Lector : " + nombre);
            Console.WriteLine("C.I del Lector : " + ci);
            Console.WriteLine("");
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public String getCi()
        {
            return this.ci;
        }
    }
  
}
