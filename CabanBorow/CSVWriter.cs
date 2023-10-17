using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CabanBorow
{
    public static class CSVWriter
    {
        static string path = "C:\\Users\\Serg\\Desktop\\Отзывы.CSV";

        public static void WriteInFile(int rating)
        {
            using (StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8)) 
            {
                writer.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy H:mm:ss")};{rating}");
            }
        }
    }
}
