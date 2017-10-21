using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamesspaces
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "We want to write this to our file.";
            File.WriteAllText(@"C:\Users\MARMIG\mentoria-marcos-cezar\Notes\AssembliesAndNamesspaces\text.txt",text);


            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");


            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
