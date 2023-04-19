using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ImportadorArchivo importador = new ImportadorArchivo("ruta_del_archivo.txt");

            
            Tablero tablero = new Tablero(importador);

            
            Console.ReadKey();
        }
    }
}

