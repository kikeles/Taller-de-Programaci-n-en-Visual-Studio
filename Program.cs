using System;
using System.IO;

namespace SegundoParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            StreamWriter archivoW;
            StreamReader archivoR;
            int opcion =0, TAM;
            char inOut;
            string cadena = "";
            int[] arreglo;
            try
            {

                do {
                    Console.Write("Menu \n1 - Escribir en un archivo\n2 - Leer numeros y ordenar\n3 - Leer archivo\n4 - salir\nOpcion:");
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
                            break;
                        case 2:
                            int i = 0, auxiliar = 0;
                                archivoW = File.AppendText("archivo.txt");
                                Console.WriteLine("Ingresa la cantidad de elementos del arreglo:");
                                TAM = Convert.ToInt32(Console.ReadLine());
                                arreglo = new int[TAM];
                                for(i = 0;i < arreglo.Length; i++)
                                {
                                    Console.Write(i + 1+" - Elemento:");
                                    arreglo[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                cadena = "\nNumeros desordenados";
                                archivoW.WriteLine(cadena);
                                for (i = 0; i < arreglo.Length; i++)
                                {
                                    cadena = Convert.ToString(arreglo[i]);
                                    archivoW.WriteLine(cadena);
                                }
                                //metodo burbuja 
                                for (i = 1; i < arreglo.Length; i++)
                                {
                                    for (int j = 0; j < arreglo.Length - i; j++)
                                    {


                                        if (arreglo[j] > arreglo[j + 1])
                                        {
                                            auxiliar = arreglo[j];
                                            arreglo[j] = arreglo[j + 1];
                                            arreglo[j + 1] = auxiliar;
                                        }
                                    }
                                }
                                cadena = "\nNumeros ordenados";
                                archivoW.WriteLine(cadena);
                                for (i = 0; i < arreglo.Length; i++)
                                {
                                    cadena = Convert.ToString(arreglo[i]);
                                    archivoW.WriteLine(cadena);
                                }
                                archivoW.Close();
                            break;
                        case 3://leer el archivo
                            archivoR = File.OpenText("archivo.txt");
                            cadena = archivoR.ReadLine();
                            while (cadena != null)
                            {
                                Console.WriteLine(cadena);
                                cadena = archivoR.ReadLine();
                            }
                            archivoR.Close();
                            break;
                        case 4:
                            salir = true;
                            break;
                    }

                } while (salir == false);
                Console.WriteLine("\nA salido del programa");
                    
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("ERROR " + e.Message);
            }

        }
    }
}
