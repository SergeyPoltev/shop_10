using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10;
internal class Control
{
    public static int ymarg = 2;
    public static ConsoleKeyInfo key;

    public static void ReadKey(int longe)
    {
        key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                if (ymarg > 2)
                    ymarg--;
                break;
            case ConsoleKey.DownArrow:
                if (ymarg < 1 + longe)
                    ymarg++;
                break;
        }
    }
    public static void MenuArrow(int longe)
    {
        if (ymarg != 2)
        {
            Console.SetCursorPosition(0, ymarg - 1);
            Console.WriteLine("  ");
        }
        if (ymarg != longe + 1)
        {
            Console.SetCursorPosition(0, ymarg + 1);
            Console.WriteLine("  ");
        }
        Console.SetCursorPosition(0, ymarg);
        Console.WriteLine("  ");
        Console.SetCursorPosition(0, ymarg);
        Console.WriteLine("=>");
        Console.SetCursorPosition(0, ymarg);
    }
}