using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasy
{
    public class FileManager
    {
        public static String[] ReadAllLines()
        {

            string path = @"C:\Users\Juan\Downloads\FirstFantasy\Parte-pr-ctica-parcial\Users.txt";
            if (File.Exists(path))
            {
                string[] allText = File.ReadAllLines(path);
                return allText;
            }
            else
            {
                return null;
            }

        }
        public static void WriteFile(string append)
        {
            string path = @"C:\Users\Juan\Downloads\FirstFantasy\Parte-pr-ctica-parcial\Users.txt";
            File.AppendAllText(path, append + "\n");
        }

    }
}

