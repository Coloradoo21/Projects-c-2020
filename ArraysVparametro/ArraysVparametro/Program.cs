﻿using System;

namespace ArraysVparametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el main.");

            foreach (int i in arrayElementos) Console.WriteLine(i);


            /*int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            ProcesaDatos(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }*/
        }



        static int [] LeerDatos()
        {
            Console.WriteLine("Cuantos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;

            }
            return datos;

        }

        /*static void ProcesaDatos(int[] datos)
        {
            for(int i = 0; i < 4; i++)
            {
                datos[i] += 10;
            }







            foreach(int i in datos)
            {
                Console.WriteLine(i);
            }*/
        }
    }

