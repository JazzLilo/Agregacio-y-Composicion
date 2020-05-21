using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_AyC
{
    class Libro
    {
        private String titulo;
        private String autor;
        public Libro(String titulo, String autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public void mostrar()
        {
            Console.WriteLine("Titulo del Libro : " + titulo);
            Console.WriteLine("Autor del libro : " + autor);
            Console.WriteLine();
        }
        public String getAutor()
        {
            return this.autor;
        }
        public String getTitulo()
        {
            return this.titulo;
        }
    }
}
