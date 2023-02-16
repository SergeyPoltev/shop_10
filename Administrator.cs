using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Shop_10.MainClass;

namespace Shop_10;

internal class Administrator : ICrud
{
    const string readmenutext = "Админ Read";
    const string createmenutext = "Админ Create";
    const string updatemenutext = "Админ Update";
    public static ForAdm ChoseUser = null;
    private static int ChoseUserpos;
    private static int ChoseUserposDelit = -1;
    private const string hadtabulate = "ID Login Password Role";

    public static bool ICrud()
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
        Menu.Meni(createmenutext + ": " + Authoriz.username, MainClass.CUAcontent);
        ForAdm newe = new ForAdm();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            ChoseUserpos = Menu.MenuCUA(newe, ChoseUserpos, false);
        }
        Console.Clear();
        Menu.Meni(MainClass.adminmenutext + ": " + Authoriz.username, MainClass.ICrudc);
    }
    private static void Dlete()
    {

        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && ChoseUserposDelit != ChoseUserpos)
        {
            List<ForAdm> checusers = Serialize.desteruser<List<ForAdm>>(Startname.Users);
            checusers.RemoveAt(ChoseUserpos);
            ChoseUserposDelit = ChoseUserpos;
            Serialize.steruser(checusers, Startname.Users);
        }
    }
    private static void Read()
    {
        string find = null;
        string findteg = null;
        string text = null;
        Console.Clear();
        Menu.Meni(readmenutext + ": " + Authoriz.username, TabulatAdmin.ListUsers(find, findteg, hadtabulate));
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            Control.ReadKey(TabulatAdmin.Finde.Count + 1);
            Control.MenuArrow(TabulatAdmin.Finde.Count + 1);
            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.ymarg - 2 != 0)
            {
                ChoseUser = TabulatAdmin.Finde[Control.ymarg - 3];
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
                Menu.Meni(readmenutext + ": " + Authoriz.username, TabulatAdmin.ListUsers(find, findteg, hadtabulate));
            }
        }
        Console.Clear();
        Menu.Meni(MainClass.adminmenutext + ": " + Authoriz.username, MainClass.ICrudc);
    }
    private static void Update()
    {

        Console.Clear();
        Menu.Meni(updatemenutext + ": " + Authoriz.username, MainClass.CUAcontent);
        ForAdm newe = new ForAdm();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            ChoseUserpos = Menu.MenuCUA(newe, ChoseUserpos, true);
        }
        Console.Clear();
        Menu.Meni(MainClass.adminmenutext + ": " + Authoriz.username, MainClass.ICrudc);
    }
}