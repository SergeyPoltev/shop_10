using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10;

internal class PersonnelManager : ICrud
{
    const string readmenutext = "Менеджер персонала Read";
    const string createmenutext = "Менеджер персонала Create";
    const string updatemenutext = "Менеджер персонала Update";
    private static checku ChoseUser = null;
    private static int ChoseUserpos;
    private static int ChoseUserposDelit = -1;
    private const string hadtabulate = "ID Фамилия Имя Отчество Д/Р Номер_Паспорта Статус Pay IDuser";
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
                        Delete();
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
        Menu.Meni(createmenutext + ": " + Authoriz.username, MainClass.CUPMcontent);
        checku newe = new checku();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            ChoseUserpos = Menu.MenuCUPM(newe, ChoseUserpos, false);
        }
        Console.Clear();
        Menu.Meni(MainClass.personnelmanagertext + ": " + Authoriz.username, MainClass.ICrudc);
    }
    private static void Delete()
    {

        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && ChoseUserposDelit != ChoseUserpos)
        {
            List<checku> checusers = Serialize.desteruser<List<checku>>(Startname.Employee);
            checusers.RemoveAt(ChoseUserpos);
            ChoseUserposDelit = ChoseUserpos;
            Serialize.steruser(checusers, Startname.Employee);
        }
    }
    private static void Read()
    {
        string poisk = null;
        string poiskt = null;
        string text = null;
        Console.Clear();
        Menu.Meni(readmenutext + ": " + Authoriz.username, Tabulate.ListUsers(poisk, poiskt, hadtabulate));
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            Control.ReadKey(Tabulate.Finde.Count + 1);
            Control.MenuArrow(Tabulate.Finde.Count + 1);
            if (Control.key.Key == ConsoleKey.Enter && Control.ymarg - 2 != 0)
            {
                ChoseUser = Tabulate.Finde[Control.ymarg - 3];
                ChoseUserpos = Control.ymarg - 3;
            }
            else if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.ymarg - 2 == 0)
            {
                Console.SetCursorPosition(9, Control.ymarg);
                text = Console.ReadLine();
                poiskt = text.Split(": ")[0];
                if (text.Split(": ").Length == 2)
                    poisk = text.Split(": ")[1];
                Console.Clear();
                Menu.Meni(readmenutext + ": " + Authoriz.username, Tabulate.ListUsers(poisk, poiskt, hadtabulate));
            }
        }
        Console.Clear();
        Menu.Meni(MainClass.personnelmanagertext + ": " + Authoriz.username, MainClass.ICrudc);
    }
    private static void Update()
    {

        Console.Clear();
        Menu.Meni(updatemenutext + ": " + Authoriz.username, MainClass.CUAcontent);
        checku newe = new checku();
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            ChoseUserpos = Menu.MenuCUPM(newe, ChoseUserpos, true);
        }
        Console.Clear();
        Menu.Meni(MainClass.personnelmanagertext + ": " + Authoriz.username, MainClass.ICrudc);

    }
}