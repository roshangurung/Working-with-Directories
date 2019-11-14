using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"C:\Program Files", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);
            

        }
    }
}
