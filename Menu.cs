using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10;

internal static class Menu
{
    public static void Meni(string menitext, string content)
    {
        MeniUp(menitext);
        MeniContent(content);
    }
    private static void MeniUp(string menitext)
    {
        Console.SetCursorPosition((Console.WindowWidth - menitext.Length) / 2, 0);
        Console.WriteLine(menitext);
        for (int i = 0; i < Console.WindowWidth; i++)
            Console.Write("-");
    }
    public static void MeniContent(string content)
    {
        Console.SetCursorPosition(0, 2);
        Console.WriteLine(content);
    }
    public static int MenuCUA(ForAdm newe, int ChoseUserpos, bool CorU)
    {

        Control.ReadKey(MainClass.CUAcontent.Split("\n").Length - 5);
        Control.MenuArrow(MainClass.CUAcontent.Split("\n").Length - 5);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUAcontent.Split("\n")[Control.ymarg - 2].Length, Control.ymarg);
            string text = null;
            if (Control.ymarg - 2 != 5)
                text = Console.ReadLine();
            switch (Control.ymarg - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 1:
                    newe.login = text;
                    break;
                case 2:
                    newe.password = text;
                    break;
                case 3:
                    try { newe.role = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 4:
                    Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.login != null && newe.password != null)
                    {
                        List<ForAdm> checusers = Serialize.desteruser<List<ForAdm>>(Startname.Users);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Serialize.steruser(checusers, Startname.Users);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUAcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }

        }
        return ChoseUserpos;
    }
    public static int MenuCUPM(checku newe, int ChoseUserpos, bool CorU)
    {
        Control.ReadKey(MainClass.CUPMcontent.Split("\n").Length);
        Control.MenuArrow(MainClass.CUPMcontent.Split("\n").Length);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUPMcontent.Split("\n")[Control.ymarg - 2].Length, Control.ymarg);
            string text = null;
            if (Control.ymarg - 2 != 8)
                text = Console.ReadLine();
            switch (Control.ymarg - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 1:
                    newe.sname = text;
                    break;
                case 2:
                    newe.name = text;
                    break;
                case 3:
                    newe.otechestvo = text;
                    break;
                case 4:
                    try { newe.born = DateTime.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 5:
                    try { newe.numpass = Int32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 6:
                    newe.status = text;
                    break;
                case 7:
                    try { newe.pay = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 8:
                    try { newe.ideq = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 9:
                    Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.sname != null && newe.name != null && newe.otechestvo != null && newe.status != null)
                    {
                        List<checku> checusers = Serialize.desteruser<List<checku>>(Startname.Employee);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Serialize.steruser(checusers, Startname.Employee);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUPMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }

        }
        return ChoseUserpos;
    }
    public static int MenuCUWM(prod newe, int ChoseUserpos, bool CorU)
    {

        Control.ReadKey(MainClass.CUWMcontent.Split("\n").Length);
        Control.MenuArrow(MainClass.CUWMcontent.Split("\n").Length);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUWMcontent.Split("\n")[Control.ymarg - 2].Length, Control.ymarg);
            string text = null;
            if (Control.ymarg - 2 != 5)
                text = Console.ReadLine();
            switch (Control.ymarg - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 1:
                    newe.name = text;
                    break;
                case 2:
                    try { newe.cost = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 3:
                    try { newe.count = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите число в ID и roole");
                    }
                    break;
                case 4:
                    Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.id.ToString() != null && newe.name != null && newe.cost.ToString() != null && newe.count.ToString() != null)
                    {
                        List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.pr);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Serialize.steruser(checusers, Startname.pr);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUWMcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }
        }
        return ChoseUserpos;
    }
    public static int MenuCUBP(skladp newe, int ChoseUserpos, bool CorU)
    {

        Control.ReadKey(MainClass.CUBPcontent.Split("\n").Length);
        Control.MenuArrow(MainClass.CUBPcontent.Split("\n").Length);
        if (Control.key.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(MainClass.CUBPcontent.Split("\n")[Control.ymarg - 2].Length, Control.ymarg);
            string text = null;
            if (Control.ymarg - 2 != 6)
                text = Console.ReadLine();
            switch (Control.ymarg - 2)
            {
                case 0:
                    try { newe.id = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 1:
                    newe.name = text;
                    break;
                case 2:
                    try { newe.data = DateTime.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 3:
                    try { newe.cost = UInt32.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 4:
                    try { newe.plus = bool.Parse(text); }
                    catch
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Вводите Данные правильно");
                    }
                    break;
                case 5:
                    Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                    Console.WriteLine("                          ");
                    if (newe.id.ToString() != null && newe.name != null && newe.data.ToString() != null && newe.plus.ToString() != null && newe.cost != null)
                    {
                        List<skladp> checusers = Serialize.desteruser<List<skladp>>(Startname.cost);
                        if (CorU)
                        {
                            checusers.RemoveAt(ChoseUserpos);
                        }
                        checusers.Add(newe);
                        Serialize.steruser(checusers, Startname.cost);
                    }
                    else
                    {
                        Console.SetCursorPosition(0, MainClass.CUBPcontent.Split("\n").Length + 2);
                        Console.WriteLine("Заполните все поля");
                    }
                    break;
            }
        }
        return ChoseUserpos;
    }
}
