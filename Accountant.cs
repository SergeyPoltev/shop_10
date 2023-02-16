using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10
{
    internal class BookeePingentry : ICrud
    {
        const string readmenutext = "Бухгалтер Read";
        const string createmenutext = "Бухгалтер Create";
        const string updatemenutext = "Бухгалтер Update";
        private static skladp ChoseUser = null;
        private static int ChoseUserpos;
        private static int ChoseUserposDelit = -1;
        private const string hadtabulate = "ID Name Cost Data Plus";
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
            Menu.Meni(createmenutext + ": " + Authoriz.username, MainClass.CUBPcontent);
            skladp newe = new skladp();
            while (Control.key.Key != ConsoleKey.Escape)
            {
                ChoseUserpos = Menu.MenuCUBP(newe, ChoseUserpos, false);
            }
            Console.Clear();
            Menu.Meni(MainClass.bookeepingentrytext + ": " + Authoriz.username, MainClass.ICrudc);
        }
        private static void Dlete()
        {

            if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && ChoseUserposDelit != ChoseUserpos)
            {
                List<skladp> checusers = Serialize.desteruser<List<skladp>>(Startname.cost);
                checusers.RemoveAt(ChoseUserpos);
                ChoseUserposDelit = ChoseUserpos;
                Serialize.steruser(checusers, Startname.cost);
            }
        }
        private static void Read()
        {
            string find = null;
            string findteg = null;
            string text = null;
            Console.Clear();
            Menu.Meni(readmenutext + ": " + Authoriz.username, Skladpw.ListUsers(find, findteg, hadtabulate));
            while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Escape)
            {
                Control.ReadKey(Skladpw.Finde.Count + 1);
                Control.MenuArrow(Skladpw.Finde.Count + 1);
                if (Control.key.Key == (ConsoleKey)MainClass.keybinds.Enter && Control.ymarg - 2 != 0)
                {
                    ChoseUser = Skladpw.Finde[Control.ymarg - 3];
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
                    Menu.Meni(readmenutext + ": " + Authoriz.username, Skladpw.ListUsers(find, findteg, hadtabulate));
                }
            }
            Console.Clear();
            Menu.Meni(MainClass.bookeepingentrytext + ": " + Authoriz.username, MainClass.ICrudc);
        }
        private static void Update()
        {

            Console.Clear();
            Menu.Meni(updatemenutext + ": " + Authoriz.username, MainClass.CUBPcontent);
            skladp newe = new skladp();
            while (Control.key.Key != (ConsoleKey)MainClass.keybinds.Enter)
            {
                ChoseUserpos = Menu.MenuCUBP(newe, ChoseUserpos, true);
            }
            Console.Clear();
            Menu.Meni(MainClass.bookeepingentrytext + ": " + Authoriz.username, MainClass.ICrudc);

        }
    }
}