using System;
using System.IO;

namespace SegundoParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encontrado;
            StreamWriter archivoW;
            StreamReader archivoR;
            int opcion =0;
            char inOut;
            string cadena = "";
            try
            {
                Console.Write("Menu \n1- Escribir en un archivo\n2 - Leer numeros y ordenar\n3 - Leer archivo\nOpcion:");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1://ecribir en el archivo
                        do
                        {
                            archivoW = File.AppendText("archivo.txt");
                            Console.WriteLine("Ingresa texto:");
                            cadena = Console.ReadLine();
                            archivoW.WriteLine(cadena);
                            archivoW.Close();
                            Console.WriteLine("Deseas agregar mas texto en el archivo (s/n)");
                            inOut = Convert.ToChar(Console.ReadLine());
                        } while (inOut == 's');
                        //archivoW.Close();
                        break;
                    case 2:

                        break;
                    case 3://leer el archivo
                        archivoR = File.OpenText("archivo.txt");
                        cadena = archivoR.ReadLine();
                        while (cadena!=null )
                        {
                            Console.WriteLine(cadena);
                            cadena = archivoR.ReadLine();
                        }
                        archivoR.Close();
                        break;
                }

                Console.ReadKey();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("ERROR " + e.Message);

            }

        }
    }
}
