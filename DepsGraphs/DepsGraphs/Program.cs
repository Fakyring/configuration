using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DepsGraphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string s, command;
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.Write("Выберите платформу (0-python, 1-npm): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название библиотеки: ");
            s = Console.ReadLine();
            switch (a)
            {
                case 0:
                    {
                        command = $"/C pipdeptree -p {s} --graph-output png > {Directory.GetCurrentDirectory()}/{s}.png";
                        Process.Start("cmd.exe", command);
                        break;
                    }
                case 1:
                    {
                        command = $"/C node-dependency-visualizer -p {s} -l | dot -Tpng > {Directory.GetCurrentDirectory()}/{s}.png";
                        Process.Start("cmd.exe", command);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
