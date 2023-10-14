using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosV4.Clases
{
    public class Ejercicios
    {

        public void arreglot()
        {
            //a) Escriba una instrucción que declare y cree a t.
            int[,] t = new int[2, 3];
            t[0, 0] = 5;
            t[0, 1] = 4;
            t[0, 2] = 6;

            t[1,0] = 7;
            t[1,1] = 8;
            t[1,2] = 9;

            ////b) ¿Cuántas filas tiene t?
            Console.WriteLine($"el arreglo t tiene {t.GetLength(0)} filas");

            ////c) ¿Cuántas columnas tiene t?
            Console.WriteLine($"el arreglo t tiene {t.GetLength(1)} columnas");

            ////d) ¿Cuántos elementos tiene t?
            Console.WriteLine($"T tiene {t.GetLength(0) * t.GetLength(1)} elementos!");

            ////e) Escriba expresiones de acceso para todos los elementos en la fila 1 de t.
            for (int columna = 0; columna < t.GetLength(1); columna++)
            {
                int elemento = t[1, columna];
                Console.WriteLine("Elemento en la fila 1 y columna " + columna + ": " + elemento);
            }

            ////f ) Escriba expresiones de acceso para todos los elementos en la columna 2 de t.
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                int elemento = t[fila, 2];
                Console.WriteLine("Elementos en la columna 2 y fila " + fila + ": " + elemento);

            }

            //g) Escriba una sola instrucción que asigne cero al elemento de t en la fila 0 y la columna 1.
            t[0, 1] = 0;

            //h) Escriba una serie de instrucciones que inicialice cada elemento de t con cero. No utilice una instrucción de repetición.
            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;

            //i) Escriba una instrucción for anidada que inicialice cada elemento de t con cero.

            for (int x = 0; x < t.GetLength(0); x++)
            {

                for (int z = 0; z < t.GetLength(1); z++)
                {
                    t[x, z] = 0;
                }

            }

            //j) Escriba una instrucción for anidada que reciba como entrada del usuario los valores de los elementos de t.
            for (int x = 0; x < t.GetLength(0); x++)
            {

                for (int z = 0; z < t.GetLength(1); z++)
                {
                    Console.WriteLine($"¿Qué elementos desea colocar en la fila {x} y columna {z} del arreglo \"t\"");
                    t[x, z] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //k) Escriba una serie de instrucciones que determine e imprima el valor más pequeño en t.
            int valorMenor = t[0, 0];
            for (int x = 1; x < t.GetLength(0); x++)
            {

                for (int z = 1; z < t.GetLength(1); z++)
                {

                    if (t[x, z] < t[x - 1, z - 1])
                    {
                        valorMenor = t[x, z];
                    }

                }

            }
            Console.WriteLine($"El valor más pequeño del arreglo es {valorMenor}");

            ////l) Escriba una instrucción Console.WriteLine que muestre los elementos de la primera fila de t. No utilice repetición.
            Console.WriteLine($"Los elementos del arreglo en la fila 1 son {t[0, 0]}, {t[0, 1]}, {t[0, 2]}");

            ////m) Escriba una instrucción que totalice los elementos de la tercera columna de t. No utilice repetición.
            int total = t[0, 2] + t[1, 2];



            //n) Escriba una serie de instrucciones para imprimir el contenido de t en formato tabular.
            //Enliste los índices de columna como encabezados a
            //lo largo de la parte superior, y enliste los índices de fila a la izquierda de cada fila.
            Console.WriteLine("\tC0\tC1\tC2"); 
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                Console.Write("Fila " + fila + "\t"); 
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    Console.Write(t[fila, columna] + "\t");
                }
                Console.WriteLine();
            }




        }


    }
}
