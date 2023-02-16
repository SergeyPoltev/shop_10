using System.Collections.Generic;
using System.Data;

namespace Shop_10;
class MainClass
{
    const string autmenutext = "Добро пожаловать в магазин ХОМЯЧКИ";
    public const string autcontent = "  Логин: \n  Пароль: \n  Авторизоваться";
    public const string adminmenutext = "Админ CRUD";
    public const string personnelmanagertext = "Менеджер персонала CRUD";
    public const string warehousemanegertext = "Склад Менеджер CRUD";
    public const string bookeepingentrytext = "Бухгалтер  CRUD";
    public const string сashirtext = "Касир ";
    public const string сashircontent = "  Заказ\n  Оформить\n  Сбросить";
    public const string ICrudc = "  Create\n  Dlete Нажмите Enter для удаления\n  Read\n  Update";
    public const string CUAcontent = "  ID: \n  Login: \n  Password: \n  roole: \n  Создать\n1-admin\n2-personnelmanager\n3-\n4-\n5-";
    public const string CUPMcontent = "  ID: \n  Surname: \n  Name: \n  Patronymic: \n  Born: \n  Serialnumber: \n  Status: \n  Iduser: \n  Создать";
    public const string CUWMcontent = "  ID: \n  Name: \n  Cost: \n  Count: \n  Создать";
    public const string CUBPcontent = "  ID: \n  Name: \n  Data: \n  Cost: \n  Pluss: \n  Создать";
    const int autlonge = 3;
    const int CRUDlonge = 4;
    public enum keybinds
    {
        Escape = ConsoleKey.Escape,
        Enter = ConsoleKey.Enter
    }
    public static void Main(string[] args)
    {

        List<ForAdm> list = Startname.startname();
        Serialize.steruser(list, Startname.Users);
        List<checku> liste = Startname.startnameempoloe();
        Serialize.steruser(liste, Startname.Employee);
        List<prod> listee = Startname.startnameq();
        Serialize.steruser(listee, Startname.pr);
        List<skladp> listeee = Startname.startnamecost();
        Serialize.steruser(listeee, Startname.cost);

        Console.WindowHeight = Console.LargestWindowHeight;
        Console.WindowWidth = Console.LargestWindowWidth;

        bool keepRunning = true;
        Console.WriteLine("Нажмите CTRL+C для входа в магазин");
        Console.CancelKeyPress += delegate (object? sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            keepRunning = false;
        };
        while (keepRunning) { }
        while (true)
        {
            Auten();
            switch (Authoriz.role)
            {
                case 1:
                    Admine();
                    break;
                case 2:
                    PersonnelManagere();
                    break;
                case 3:
                    WarehouseManegere();
                    break;
                case 4:
                    Bookeepingentrye();
                    break;
                case 5:
                    Cashire();
                    break;

            }
            Control.ymarg = 2;
        }
    }
    static void Auten()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(autmenutext, autcontent);
        while (chec)
        {
            Control.ReadKey(autlonge);
            Control.MenuArrow(autlonge);
            if (Control.key.Key == (ConsoleKey)keybinds.Enter)
                chec = Authoriz.Read(autlonge);
        }
    }
    static void Admine()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(warehousemanegertext + ": " + Authoriz.username, ICrudc);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = Administrator.ICrud();
        }
    }
    static void PersonnelManagere()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(personnelmanagertext + ": " + Authoriz.username, ICrudc);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = PersonnelManager.CRUDe();
        }
    }
    static void WarehouseManegere()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(warehousemanegertext + ": " + Authoriz.username, ICrudc);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = WarehouseManeger.CRUDe();
        }
    }
    static void Bookeepingentrye()
    {
        bool chec = true;
        Console.Clear();
        Menu.Meni(bookeepingentrytext + ": " + Authoriz.username, ICrudc);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = BookeePingentry.CRUDe();
        }
    }
    static void Cashire()
    {
        List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.pr);
        foreach (prod item in checusers)
            item.count = 0;
        Serialize.steruser(checusers, Startname.buy);
        bool chec = true;
        Console.Clear();
        Menu.Meni(сashirtext + ": " + Authoriz.username, сashircontent);
        while (Control.key.Key != (ConsoleKey)keybinds.Escape || chec)
        {
            Control.ReadKey(CRUDlonge);
            Control.MenuArrow(CRUDlonge);
            chec = Paym.Shop();
        }
    }
}