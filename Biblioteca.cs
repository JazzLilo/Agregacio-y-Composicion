using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_AyC
{
    class Biblioteca
    {
        private String nombre;
        private int nLec;
        private Lector[] le = new Lector[50];
        private int nLibro;
        private Libro[] li = new Libro[50];
        public Biblioteca(String nombre,int nLibro,String titulo,String autor)
        {
            this.nombre = nombre;
            this.nLec = 0;
            this.nLibro = nLibro;
            for(int i = 0;i<nLibro; i++)
            {
                li[i] = new Libro(titulo, autor);
            }

        }
        public void AddLectores(Lector[] le, int nLec)
        {
            this.nLec = nLec;
            this.le = le;
        }

        public void mostrar()
        {
            Console.WriteLine("Nombre: " + nombre);
            if (nLec != 0)
            {
                Console.WriteLine("Nro de Lectores: " + nLec);
                for (int i = 0; i < nLec; i++)
                {
                    le[i].mostrar();
                }
            }

            Console.WriteLine("Numero de Libros : " + nLibro);
            for (int i = 0; i < nLibro; i++)
            {
                li[i].mostrar();
            }
        }
        //c
        public void contarAutores(String x)
        {
            int con = 0;
            for (int i = 0; i < this.nLibro; i++)
            {
                if (li[i].getAutor().Equals(x))
                {
                    con++;
                }
            }
            if (con == 0)
            {
                Console.WriteLine("NO existen libros con autor: " + x);
            }
            else
            {
                Console.WriteLine("EXISTEN " + con + " libros con el autor : " + x);
            }
        }
        // inciso d
        public void mostrarNombreLector(String ciX)
        {
            bool sw = false;
            int pos = 0;
            for (int i = 0; i < nLec; i++)
            {
                if (le[i].getCi().Equals(ciX))
                {
                    sw = true;
                    pos = i;
                }
            }
            if (sw)
            {
                Console.WriteLine(" El Nombre del Lector de C.I " + ciX + " es: " + le[pos].getNombre());
            }
            else
            {
                Console.WriteLine("NO Existe el lector de C.I: " + ciX);
            }
        }
        // inciso e
        public void adicionarLibro()
        {
            Libro libro = new Libro("Ojos de mi princesa", "Bustamante");
            bool sw = true;
            for (int i = 0; i < nLibro; i++)
            {
                if (libro.getAutor().Equals(li[i].getAutor()) && libro.getTitulo().Equals(li[i].getTitulo()))
                {
                    sw = false;
                    break;
                }
            }
            if (sw)
            {
                li[nLibro] = libro;
                nLibro++;
                Console.WriteLine("");
                Console.WriteLine("Libro Añadido:");
                li[nLibro - 1].mostrar();
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("El libro ya existe y no se puede añadir");
            }
        }
    }
}
