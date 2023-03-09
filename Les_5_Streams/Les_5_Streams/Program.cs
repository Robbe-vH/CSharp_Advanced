using System;
using System.IO;

namespace Les_5_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo StreamWriter

            //string fileName = "pxl.txt";
            //StreamWriter streamWriter = new StreamWriter(fileName);

            //streamWriter.WriteLine("Hello World");
            //streamWriter.Close(); // altijd sluiten

            // Demo StreamReader

            StreamReader streamReader = new StreamReader("pxl.txt");
            string lineFromFile = streamReader.ReadLine();
            Console.WriteLine("Een lijn");
            Console.WriteLine(lineFromFile);
            Console.ReadLine();
            streamReader.Close();

            StreamReader oefening1 = new StreamReader("notes.txt");
            string wholeFile = oefening1.ReadToEnd();
            Console.WriteLine("Heel bestand");
            Console.WriteLine(wholeFile);
            Console.ReadLine();
            streamReader.Close();

            StreamReader oefening2 = new StreamReader("notes.txt");
            Console.WriteLine("End Of stream loop");
            Console.WriteLine(oefening2.ReadLine());
            while (!oefening2.EndOfStream)
            {
                Console.WriteLine(oefening2.ReadLine());
            }
            Console.ReadLine();
            streamReader.Close();


            // Filestreams
            FileStream fs = new FileStream("notes.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine("djksfkjsdf");
            sr.Close();
            fs.Close();

            Console.ReadLine();

            //File 

            if (File.Exists("PXL.txt"))
            {
                Console.WriteLine("Bestand bestaat");
            }

            FileInfo fi = new FileInfo();


            // Oefening 1

            //StreamWriter streamWriter = new StreamWriter("notes.txt");

            //string input = Console.ReadLine();
            //while (!input.ToLower().Equals("exit"))
            //{
            //    streamWriter.WriteLine(input);
            //    input = Console.ReadLine();
            //}  
            //streamWriter.Close();

        }
    }
}
