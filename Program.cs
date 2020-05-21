using System;

namespace Proyecto_AyC
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b1 = new Biblioteca("Biblioteca Municipal", 5, "Volar Sobre el Pantano", "Carlos Cuauhtémoc");
            b1.mostrar();
            Console.WriteLine("---------------------");
            int numLec = 4;
            Lector[] lec = new Lector[50];
            Lector l1 = new Lector("Heizeel", "9144142");
            Lector l2 = new Lector("Luz", "3359621");
            Lector l3 = new Lector("Aurora", "8475621");
            Lector l4 = new Lector("Lilo", "9155253");
            lec[0] = l1;
            lec[1] = l2;
            lec[2] = l3;
            lec[3] = l4;
            b1.AddLectores(lec, numLec);
            b1.mostrar();
            b1.contarAutores("SANCHEZ");
            b1.mostrarNombreLector("9155253");


            b1.adicionarLibro();
     
            b1.mostrar();
        }
    }
}
