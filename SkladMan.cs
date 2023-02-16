using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10;

internal class WarehouseManeger : ICrud
{
    const string readmenutext = "Склад Менеджер Read";
    const string createmenutext = "Склад Менеджер Create";
    const string updatemenutext = "Склад Менеджер Update";
    public static prod ChoseUser = null;
    private static int ChoseUserpos;
    private static int ChoseUserposDelit = -1;
    private const string hadtabulate = "ID Name Cost Count";

    public static bool CRUDe()
    {
        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter)
            switch (Control.ymarg - 1)
            {
                case 1:
                    Create();
                    Control.ymarg = 2;
                    return true;
                case 2:
                    if (ChoseUser != null)
                        Dlete();
                    return true;
                case 3:
                    Read();
                    Control.ymarg = 2;
                    return true;
                case 4:
                    if (ChoseUser != null)
                        Update();
                    Control.ymarg = 2;
                    return true;
            }
        return false;
    }
    private static void Create()
    {
        Console.Clear();
        Menu.Meni(createmenutext + ": " + Authoriz.username, MainClass.CUWMcontent);
        prod newe = new prod();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            ChoseUserpos = Menu.MenuCUWM(newe, ChoseUserpos, false);
        }
        Console.Clear();
        Menu.Meni(MainClass.warehousemanegertext + ": " + Authoriz.username, MainClass.ICrudc);
    }
    private static void Dlete()
    {

        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && ChoseUserposDelit != ChoseUserpos)
        {
            List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.pr);
            checusers.RemoveAt(ChoseUserpos);
            ChoseUserposDelit = ChoseUserpos;
            Serialize.steruser(checusers, Startname.pr);
        }
    }
    private static void Read()
    {
        string find = null;
        string findteg = null;
        string text = null;
        Console.Clear();
        Menu.Meni(readmenutext + ": " + Authoriz.username, TabulatWarehouseManeger.ListUsers(find, findteg, hadtabulate));
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            Control.ReadKey(TabulatWarehouseManeger.Finde.Count + 1);
            Control.MenuArrow(TabulatWarehouseManeger.Finde.Count + 1);
            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.ymarg - 2 != 0)
            {
                ChoseUser = TabulatWarehouseManeger.Finde[Control.ymarg - 3];
                ChoseUserpos = Control.ymarg - 3;
            }
            else if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.ymarg - 2 == 0)
            {
                Console.SetCursorPosition(9, Control.ymarg);
                text = Console.ReadLine();
                findteg = text.Split(": ")[0];
                if (text.Split(": ").Length == 2)
                    find = text.Split(": ")[1];
                Console.Clear();
                Menu.Meni(readmenutext + ": " + Authoriz.username, TabulatWarehouseManeger.ListUsers(find, findteg, hadtabulate));
            }
        }
        Console.Clear();
        Menu.Meni(MainClass.warehousemanegertext + ": " + Authoriz.username, MainClass.ICrudc);
    }
    private static void Update()
    {

        Console.Clear();
        Menu.Meni(updatemenutext + ": " + Authoriz.username, MainClass.CUWMcontent);
        prod newe = new prod();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            ChoseUserpos = Menu.MenuCUWM(newe, ChoseUserpos, true);
        }
        Console.Clear();
        Menu.Meni(MainClass.warehousemanegertext + ": " + Authoriz.username, MainClass.ICrudc);
    }
}
