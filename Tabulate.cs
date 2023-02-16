using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10;
class Tabulate
{
    private static int tabulate;
    public static List<checku> Finde;
    public static string ListUsers(string find, string findteg, string header)
    {
        List<checku> checusers = Serialize.desteruser<List<checku>>(Startname.Employee);
        Finde = new List<checku>();
        string spisoku = "  Поиск: ";
        tabulate = spisoku.Length;
        spisoku = Format(spisoku, header.Split(" ")[0], header);
        spisoku = Format(spisoku, header.Split(" ")[1], header);
        spisoku = Format(spisoku, header.Split(" ")[2], header);
        spisoku = Format(spisoku, header.Split(" ")[3], header);
        spisoku = Format(spisoku, header.Split(" ")[4], header);
        spisoku = Format(spisoku, header.Split(" ")[5], header);
        spisoku = Format(spisoku, header.Split(" ")[6], header);
        spisoku = Format(spisoku, header.Split(" ")[7], header);
        spisoku = Format(spisoku, header.Split(" ")[8], header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        foreach (checku checuser in checusers)
        {
            switch (findteg)
            {
                case "ID":
                    if (find == checuser.id.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Surname":
                    if (find == checuser.sname)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Name":
                    if (find == checuser.name)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Patronymic":
                    if (find == checuser.otechestvo)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "born":
                    if (find == checuser.born.ToShortDateString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Serialnumber":
                    if (find == checuser.numpass.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Status":
                    if (find == checuser.status)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Pay":
                    if (find == checuser.pay.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Iduser":
                    if (find == checuser.ideq.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case null:
                    spisoku = Formats(spisoku, checuser, header);
                    break;
                default:
                    if (findteg == checuser.id.ToString() || findteg == checuser.sname || findteg == checuser.name || findteg == checuser.otechestvo || find == checuser.pay.ToString()
                        || findteg == checuser.born.ToShortDateString() || findteg == checuser.numpass.ToString() || findteg == checuser.status || findteg == checuser.ideq.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
            }
        }
        return spisoku;
    }
    private static string Formats(string spisoku, checku checuser, string header)
    {
        Finde.Add(checuser);
        spisoku = Format(spisoku, checuser.id.ToString(), header);
        spisoku = Format(spisoku, checuser.sname, header);
        spisoku = Format(spisoku, checuser.name, header);
        spisoku = Format(spisoku, checuser.otechestvo, header);
        spisoku = Format(spisoku, checuser.born.ToShortDateString(), header);
        spisoku = Format(spisoku, checuser.numpass.ToString(), header);
        spisoku = Format(spisoku, checuser.status, header);
        spisoku = Format(spisoku, checuser.pay.ToString(), header);
        spisoku = Format(spisoku, checuser.ideq.ToString(), header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        return spisoku;
    }
    private static string Format(string speaker, string table, string had)
    {
        for (int i = 0; i < Console.WindowWidth / (had.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class TabulatAdmin
{
    private static int tabulate;
    public static List<ForAdm> Finde;
    public static string ListUsers(string find, string findteg, string header)
    {
        List<ForAdm> checusers = Serialize.desteruser<List<ForAdm>>(Startname.Users);
        Finde = new List<ForAdm>();
        string spisoku = "  Поиск: ";
        tabulate = spisoku.Length;
        spisoku = Format(spisoku, header.Split(" ")[0], header);
        spisoku = Format(spisoku, header.Split(" ")[1], header);
        spisoku = Format(spisoku, header.Split(" ")[2], header);
        spisoku = Format(spisoku, header.Split(" ")[3], header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        foreach (ForAdm checuser in checusers)
        {
            switch (findteg)
            {
                case "ID":
                    if (find == checuser.id.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Login":
                    if (find == checuser.login)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Password":
                    if (find == checuser.password)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Role":
                    if (find == checuser.role.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case null:
                    spisoku = Formats(spisoku, checuser, header);
                    break;
                default:
                    if (findteg == checuser.id.ToString() || findteg == checuser.login || findteg == checuser.password || findteg == checuser.role.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
            }
        }
        return spisoku;
    }
    private static string Formats(string spisoku, ForAdm checuser, string header)
    {
        Finde.Add(checuser);
        spisoku = Format(spisoku, checuser.id.ToString(), header);
        spisoku = Format(spisoku, checuser.login, header);
        spisoku = Format(spisoku, checuser.password, header);
        spisoku = Format(spisoku, checuser.role.ToString(), header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        return spisoku;
    }
    private static string Format(string speaker, string table, string header)
    {
        for (int i = 0; i < Console.WindowWidth / (header.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class TabulatWarehouseManeger
{
    private static int tabulate;
    public static List<prod> Finde;
    public static string ListUsers(string find, string findteg, string header)
    {
        List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.pr);
        Finde = new List<prod>();
        string spisoku = "  Поиск: ";
        tabulate = spisoku.Length;
        spisoku = Format(spisoku, header.Split(" ")[0], header);
        spisoku = Format(spisoku, header.Split(" ")[1], header);
        spisoku = Format(spisoku, header.Split(" ")[2], header);
        spisoku = Format(spisoku, header.Split(" ")[3], header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        foreach (prod checuser in checusers)
        {
            switch (findteg)
            {
                case "ID":
                    if (find == checuser.id.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Login":
                    if (find == checuser.name)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Password":
                    if (find == checuser.cost.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Role":
                    if (find == checuser.count.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case null:
                    spisoku = Formats(spisoku, checuser, header);
                    break;
                default:
                    if (findteg == checuser.name || findteg == checuser.id.ToString() || findteg == checuser.count.ToString() || findteg == checuser.cost.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
            }
        }
        return spisoku;
    }
    private static string Formats(string spisoku, prod checuser, string header)
    {
        Finde.Add(checuser);
        spisoku = Format(spisoku, checuser.id.ToString(), header);
        spisoku = Format(spisoku, checuser.name, header);
        spisoku = Format(spisoku, checuser.cost.ToString(), header);
        spisoku = Format(spisoku, checuser.count.ToString(), header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        return spisoku;
    }
    private static string Format(string speaker, string table, string header)
    {
        for (int i = 0; i < Console.WindowWidth / (header.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class Skladpw
{
    private static int tabulate;
    public static List<skladp> Finde;
    public static string ListUsers(string find, string findteg, string header)
    {
        List<skladp> checusers = Serialize.desteruser<List<skladp>>(Startname.cost);
        Finde = new List<skladp>();
        string spisoku = "  Поиск: ";
        tabulate = spisoku.Length;
        spisoku = Format(spisoku, header.Split(" ")[0], header);
        spisoku = Format(spisoku, header.Split(" ")[1], header);
        spisoku = Format(spisoku, header.Split(" ")[2], header);
        spisoku = Format(spisoku, header.Split(" ")[3], header);
        spisoku = Format(spisoku, header.Split(" ")[4], header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        int total = 0;
        foreach (skladp checuser in checusers)
        {
            switch (findteg)
            {
                case "ID":
                    if (find == checuser.id.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Name":
                    if (find == checuser.name)
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Cost":
                    if (find == checuser.cost.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Data":
                    if (find == checuser.data.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case "Plus":
                    if (find == checuser.plus.ToString())
                        spisoku = Formats(spisoku, checuser, header);
                    break;
                case null:
                    spisoku = Formats(spisoku, checuser, header);
                    if (checuser.plus)
                        total += (int)checuser.cost;
                    else
                        total -= (int)checuser.cost;
                    break;
                default:
                    if (findteg == checuser.name || findteg == checuser.id.ToString() || findteg == checuser.data.ToString() || findteg == checuser.cost.ToString() || findteg == checuser.plus.ToString())
                    {
                        spisoku = Formats(spisoku, checuser, header);
                        if (checuser.plus)
                            total += (int)checuser.cost;
                        else
                            total -= (int)checuser.cost;
                    }
                    break;
            }
        }
        spisoku += "Итог: " + total.ToString();
        return spisoku;
    }
    private static string Formats(string spisoku, skladp checuser, string header)
    {
        Finde.Add(checuser);
        spisoku = Format(spisoku, checuser.id.ToString(), header);
        spisoku = Format(spisoku, checuser.name, header);
        spisoku = Format(spisoku, checuser.cost.ToString(), header);
        spisoku = Format(spisoku, checuser.data.ToString(), header);
        spisoku = Format(spisoku, checuser.plus.ToString(), header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        return spisoku;
    }
    private static string Format(string speaker, string table, string had)
    {
        for (int i = 0; i < Console.WindowWidth / (had.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}
class TabulatBy
{
    private static int tabulate;
    public static List<prod> Finde;
    public static string ListUsers(string find, string findteg, string header)
    {
        List<prod> checusers = Serialize.desteruser<List<prod>>(Startname.buy);
        Finde = new List<prod>();
        string spisoku = "";
        tabulate = spisoku.Length;
        spisoku = Format(spisoku, header.Split(" ")[0], header);
        spisoku = Format(spisoku, header.Split(" ")[1], header);
        spisoku = Format(spisoku, header.Split(" ")[2], header);
        spisoku = Format(spisoku, header.Split(" ")[3], header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        foreach (prod checuser in checusers)
        {
            spisoku = Formats(spisoku, checuser, header);
        }
        return spisoku;
    }
    private static string Formats(string spisoku, prod checuser, string header)
    {

        Finde.Add(checuser);
        spisoku = Format(spisoku, checuser.id.ToString(), header);
        spisoku = Format(spisoku, checuser.name, header);
        spisoku = Format(spisoku, checuser.cost.ToString(), header);
        spisoku = Format(spisoku, checuser.count.ToString(), header);
        spisoku = spisoku + "\n";
        tabulate = 0;
        return spisoku;
    }
    private static string Format(string speaker, string table, string header)
    {
        for (int i = 0; i < Console.WindowWidth / (header.Split(" ").Length + 1) - tabulate; i++)
            speaker = speaker + " ";
        speaker = speaker + table;
        tabulate = table.Length;
        return speaker;
    }
}