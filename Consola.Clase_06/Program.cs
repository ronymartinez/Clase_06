using System;
using System.Collections.Generic;

namespace Consola.Clase_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ LIST ---------");

            List<int> edades = new List<int>();
            edades.Add(4);
            edades.Add(2);
            edades.Add(1);
            edades.Add(2);
            edades[0] = 100;

            //Console.WriteLine(edades.Count );
            edades.Insert(1, -5);

            Console.WriteLine("------DICTIONARY---------");

            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            diccionario.Add("taco", "Mexico");
            diccionario.Add("burrito", "Mexico");
            diccionario.Add("pizza", "Italia");
            foreach (KeyValuePair<string, string> item in diccionario)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }

            diccionario.Remove("taco");
            Console.WriteLine("\n");


            diccionario["taco"] = "EE.UU";


            foreach (KeyValuePair<string, string> item in diccionario)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
            }
            Console.WriteLine("---------------");

            Console.WriteLine(diccionario.ContainsKey("pasta"));
            Console.WriteLine(diccionario.ContainsKey("pizza"));
            Console.WriteLine(diccionario.ContainsValue("Italia"));
            Console.WriteLine(diccionario.ContainsValue("Argentina"));


            Queue<string> clientes = new Queue<string>();

            clientes.Enqueue("Mauricio");
            clientes.Enqueue("Lautaro");
            clientes.Enqueue("Esteban");

            Console.WriteLine("---------------");

            foreach (string item in clientes)
            {
                Console.WriteLine(item);
            }


            //Console.WriteLine(clientes.Dequeue()); //Devuelve el último elemento y lo borra
            Console.WriteLine(clientes.Peek()); //Devuelve el primer elemento sin eliminarlo

            Console.WriteLine("---------------");

            foreach (string item in clientes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n-------- STACK -------");

            Stack<string> paises = new Stack<string>();

            paises.Push("Argentina");
            paises.Push("Brasil");
            paises.Push("Peru");
            paises.Push("Bolivia");

            foreach (string item in paises)
            {
                Console.WriteLine(item);
            }
            //paises.Pop();
            Console.WriteLine(paises.Peek());

            Console.WriteLine("\n");
            foreach (string item in paises)
            {
                Console.WriteLine(item);
            }




            //for (int i = 0; i < edades.Count; i++)
            //{
            //    if(edades[i] > 3)
            //    {
            //        edades.RemoveAt(i);
            //    }
            //}
            //foreach (int item in edades)
            //{
            //    //edades.Remove(4);
            //   // Console.WriteLine(item);
            //}

            //Console.WriteLine(edades[2]);

            //int[,] array2D = { { 1, 2, 9 }, { 3, 4, 8 }, { 5, 6,5 } };

            //int[] array = { 1, 2, 3, 4, 5 };
            //string[] nombres = { "Lautaro", "Mauricio", "Esteban" };



            //foreach (string item in nombres)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-------");

            //Array.Reverse(nombres);

            //foreach (string item in nombres)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(array2D.Length); //Length devuelve lac antidad de elementos
            //Console.WriteLine(array2D.Rank); // Rank devuelve la cantidad de dimensiones
            //Console.WriteLine(array2D.GetLength(0));//Recibe como parámetro la dimension y de indica la cantidad de elementos de la dimension


        }
    }
}



 