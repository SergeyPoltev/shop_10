using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10;

internal class Paym
{
    const string readmenutext = "Касса";
    private const string hadtabulate = "ID Name Cost Count";
    private static int ChoseUserpos;
    public static bool Shop()
    {
        if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter)
            switch (Control.ymarg - 1)
            {
                case 1:
                    Warehouse();
                    Control.ymarg = 2;
                    return true;
                case 2:
                    Control.ymarg = 2;
                    Chec();
                    return true;
                case 3:
                    List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.pr);
                    foreach (prod item in checusers)
                        item.count = 0;
                    Serialize.steruser(checusers, Startname.buy);
                    return true;
            }
        return false;
    }
    private static void Warehouse()
    {
        string find = null;
        string findteg = null;
        string text = null;
        Console.Clear();
        Menu.Meni(readmenutext + ": " + Authoriz.username, TabulatBy.ListUsers(find, findteg, hadtabulate));
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {

            Control.ReadKey(TabulatBy.Finde.Count + 1);
            Control.MenuArrow(TabulatBy.Finde.Count + 1);
            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.ymarg - 2 != 0)
            {
                ChoseUserpos = Control.ymarg - 3;
            }
            else if ((Control.key.Key == ConsoleKey.LeftArrow || Control.key.Key == ConsoleKey.RightArrow) && Control.ymarg - 2 != 0)
            {
                List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.pr);
                List<prod> checuserse = Serialize.desteruser<List<prod>>(Startname.buy);
                switch (Control.key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (checuserse[ChoseUserpos].count > 0)
                            checuserse[ChoseUserpos].count--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (checuserse[ChoseUserpos].count < checusers[ChoseUserpos].count)
                            checuserse[ChoseUserpos].count++;
                        break;
                }
                Serialize.steruser(checuserse, Startname.buy);
                Menu.Meni(readmenutext + ": " + Authoriz.username, TabulatBy.ListUsers(find, findteg, hadtabulate));
            }
        }
        Console.Clear();
        Menu.Meni(MainClass.сashirtext + ": " + Authoriz.username, MainClass.сashircontent);
    }
    private static void Chec()
    {
        List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.buy);
        List<prod> checusersee = Serialize.desteruser<List<prod>>(Startname.pr);
        List<skladp> bookee = Serialize.desteruser<List<skladp>>(Startname.cost);
        while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
        {
            Console.Clear();
            Console.WriteLine("чек:");
            uint total = 0;
            for (int i = 0; i < checusers.Count; i++)

                if (checusers[i].count == 0)
                    checusers.RemoveAt(i);
                else
                {
                    Console.WriteLine(checusers[i].name + " " + checusers[i].cost + "руб. " + checusers[i].count + "шт. " + Convert.ToString(checusers[i].count * checusers[i].cost) + "руб. Всего");
                    total += checusers[i].count * checusers[i].cost;
                }
            Console.WriteLine("Итог: " + total);
            skladp newe = new skladp();
            newe.id = 1;
            newe.name = "buy";
            newe.cost = total;
            newe.data = DateTime.Now;
            newe.plus = true;
            bookee.Add(newe);
            Control.ReadKey(0);
        }
        for (int i = 0; i < checusers.Count; i++)
            checusersee[i].count -= checusers[i].count;
        Serialize.steruser(checusersee, Startname.pr);
        Serialize.steruser(checusers, Startname.buy);
        Serialize.steruser(bookee, Startname.cost);
        Console.Clear();
        Menu.Meni(MainClass.сashirtext + ": " + Authoriz.username, MainClass.сashircontent);
    }
}