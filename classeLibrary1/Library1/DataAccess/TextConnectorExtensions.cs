using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using Library1.DataAccess;

namespace Library1.DataAccess
{
    public static class TextConnectorExtensions
    {
        public static string FullFilePath(this string fileName)
        {
            // Pega a pasta do app + nome do arquivo
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<string>();
            }

            return File.ReadAllLines(filePath).ToList();
        }


    }
}
