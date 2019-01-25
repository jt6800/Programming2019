using System;
using System.IO;

class Test
{
    public static void Main()
    {
        try
        {   // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader(@"C:\Users\jt6800\Desktop\TestText.txt"))
            {
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
                Console.ReadKey();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}