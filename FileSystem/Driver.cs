using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    /// <summary>
    /// The Driver class reads input line by line and executes the correct function based on input.
    /// </summary>
    class Driver
    {
        static void Main(string[] args)
        {
            var fileSystem = FileSystem.Instance;
            var buffer = Buffer.Instance;

            var userEntry = "";
            int handle;

            while (true)
            {
                userEntry = Console.ReadLine();               
                var tokens = userEntry.Split(' ');

                switch (tokens[0].ToLower())
                {
                    case "cr":
                        fileSystem.Create(tokens[1]);
                        break;
                    case "de":
                        fileSystem.Destroy(tokens[1]);
                        break;
                    case "op":
                        handle = fileSystem.Open(tokens[1]);
                        break;
                    case "cl":
                        try
                        {
                            fileSystem.Close(Convert.ToInt32(tokens[1]));
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Parameter is not a valid integer");
                        }
                        
                        break;
                    case "rd":
                        try
                        {
                            fileSystem.Read(Convert.ToInt32(tokens[1]), buffer, Convert.ToInt32(tokens[2]));
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid read call: rd <index> <count>");
                        }
                        
                        break;
                    case "wr":
                        try
                        {
                            fileSystem.Write(Convert.ToInt32(tokens[1]), Convert.ToChar(tokens[2]), Convert.ToInt32(tokens[3]));
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid read call: rd <index> <char> <count>");
                        }
                        break;
                    case "sk":
                        break;
                    case "dr":
                        var files = fileSystem.Directory();

                        foreach (var file in files)
                        {
                            Console.WriteLine(file.ToString());
                        }
                        break;
                    case "in":
                        break;
                    case "sv":
                        break;
                    default:
                        Console.WriteLine("Error: invalid operation");
                        break;
                }
            } 
        }
    }
}
