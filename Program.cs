using System;
using System.IO;
using Microsoft.Extensions.Configuration;

using static System.Console;

namespace dotenv_in_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetCurrentDirectory();
            var dotenv = Path.Combine(root, ".env");
            DotEnv.Load(dotenv);

            var config =
                new ConfigurationBuilder()
                    .AddEnvironmentVariables()
                    .Build();

            WriteLine(config["FOO"]);
            WriteLine(config["HELLO"]);
        }
    }
}
