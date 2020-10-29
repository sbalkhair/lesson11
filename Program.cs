using System;
using System.IO;
using System.Linq;

namespace lesson11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var path = @"/Users/sbalkhair/Downloads/";

            var foler = Directory.CreateDirectory(path + "Roya");

            //if (Directory.Exists(path + "Roya"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            //Console.ReadKey();

            //File.Create(@"/Users/sbalkhair/Downloads/Roya/myinfo.txt");

            //var output = File.ReadAllText(@"/Users/sbalkhair/Downloads/Roya/myinfo.txt");

            //Console.WriteLine(output);
            //Console.ReadKey();

            //var directories = Directory.GetFiles(@"/Users/sbalkhair/Downloads/Roya");

            //foreach (var filePath in directories)
            //{
            //    //Console.WriteLine(Path.GetFileName(filePath));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(filePath));
            //    Console.WriteLine(Path.GetExtension(filePath));
            //}
            //Console.ReadKey();

            //File.Copy(@"/Users/sbalkhair/Downloads/download.png", @"/Users/sbalkhair/Downloads/Roya", true);
            //File.Delete(@"/Users/sbalkhair/Downloads/Roya/download.png");

            //foreach (var item in Directory.GetFiles(path))
            //{

            //    if (Path.GetExtension(item) == ".jpg")
            //    {
            //        Console.WriteLine(Path.GetFileName(item));
            //    }
            //}
            //Console.ReadKey();

            Console.WriteLine(Directory.GetFiles(path).Count());
            Console.ReadKey();
        }
    }
}
