using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;

namespace PII_Game_Of_Life
{
    public class ImportadorArchivo
    {
        private string[] contentLines; // Cambiado a una variable de instancia
        public bool[,] board { get; } // Propiedad que representa el tablero

        public ImportadorArchivo(string url)
        {
            string content = File.ReadAllText(url); // Lectura del contenido del archivo
            contentLines = content.Split('\n'); // División del contenido en líneas

            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }
        }
    }
}


