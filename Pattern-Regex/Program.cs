using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Regex re = new Regex(@"^([1|۱][۰-۹|0-9]{3}([0|۰][۱-۶|1-6])([0|۰][۱-۹|1-9]|[۱۲|12][۰-۹|0-9]|[3|۳][01|۰۱])|[1|۱][۰-۹|0-9]{3}([۰|0][۷-۹|7-9]|[1|۱][۰۱۲|012])([۰|0][1-9 ۱-۹]|[12۱۲][0-9|۰-۹]|(30|۳۰)))$");
                while (true)
                {
                    Console.Write("date:");
                    var text = Console.ReadLine();
                    if (text == "exit")
                        break;
                    var isMatch = re.IsMatch(text);
                    if (isMatch)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Match!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not Match!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
