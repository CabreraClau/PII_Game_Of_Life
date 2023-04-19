using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;
namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool[,] b { get; } //variable que representa el tablero
        public int width { get; } //variabe que representa el ancho del tablero
        public int height { get; } //variabe que representa altura del tablero

        public Tablero(ImportadorArchivo importador)
        {
            b = importador.board;
            width = b.GetLength(0);
            height = b.GetLength(1);
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (b[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                Thread.Sleep(300);
            }
        }
    }
}
