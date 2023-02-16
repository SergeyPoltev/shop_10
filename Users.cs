using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_10;

internal class Startname
{
    public const string Users = "C:\\Users\\Сергей\\Desktop\\10_Shop\\users.json";
    public const string Employee = "C:\\Users\\Сергей\\Desktop\\10_Shop\\employe.json";
    public const string pr = "C:\\Users\\Сергей\\Desktop\\10_Shop\\pr.json";
    public const string cost = "C:\\Users\\Сергей\\Desktop\\10_Shop\\sklad.json";
    public const string buy = "C:\\Users\\Сергей\\Desktop\\10_Shop\\buy.json";
    public static List<skladp> startnamecost()
    {
        skladp user1 = new skladp();
        user1.id = 121;
        user1.name = "sdrre";
        user1.cost = 2;
        user1.data = new DateTime(1212, 12, 12);
        user1.plus = true;
        skladp user2 = new skladp();
        user2.id = 12;
        user2.name = "sudrre";
        user2.cost = 4;
        user2.data = new DateTime(1212, 12, 12);
        user2.plus = true;
        List<skladp> listuser = new List<skladp>();
        listuser.Add(user1);
        listuser.Add(user2);
        return listuser;
    }
    public static List<ForAdm> startname()
    {
        ForAdm user1 = new ForAdm();
        user1.id = 121;
        user1.login = "admin";
        user1.password = " ";
        user1.role = 1;
        ForAdm user2 = new ForAdm();
        user2.id = 11;
        user2.login = "user1";
        user2.password = " ";
        user2.role = 2;
        ForAdm user3 = new ForAdm();
        user3.id = 12;
        user3.login = "user2";
        user3.password = " ";
        user3.role = 3;
        ForAdm user4 = new ForAdm();
        user4.id = 21;
        user4.login = "user3";
        user4.password = " ";
        user4.role = 4;
        ForAdm user5 = new ForAdm();
        user5.id = 22;
        user5.login = "user4";
        user5.password = " ";
        user5.role = 5;
        List<ForAdm> listuser = new List<ForAdm>();
        listuser.Add(user1);
        listuser.Add(user2);
        listuser.Add(user3);
        listuser.Add(user4);
        listuser.Add(user5);
        return listuser;
    }
    public static List<checku> startnameempoloe()
    {
        checku user1 = new checku();
        user1.id = 111;
        user1.sname = "";
        user1.name = "";
        user1.otechestvo = "";
        user1.born = new DateTime(1212, 12, 12);
        user1.numpass = 1234123456;
        user1.status = "";
        user1.pay = 10;
        user1.ideq = 121;

        checku user2 = new checku();
        user2.id = 111;
        user2.sname = "";
        user2.name = "";
        user2.otechestvo = "";
        user2.born = new DateTime(1212, 12, 12);
        user2.numpass = 1234123456;
        user2.status = "";
        user2.pay = 2;
        user2.ideq = 11;

        checku user3 = new checku();
        user3.id = 111;
        user3.sname = "";
        user3.name = "";
        user3.otechestvo = "";
        user3.born = new DateTime(1212, 12, 12);
        user3.numpass = 1234123456;
        user3.status = "";
        user3.pay = 2;
        user3.ideq = 12;

        checku user4 = new checku();
        user4.id = 111;
        user4.sname = "";
        user4.name = "";
        user4.otechestvo = "";
        user4.born = new DateTime(1212, 12, 12);
        user4.numpass = 1234123456;
        user4.status = "";
        user4.pay = 2;
        user4.ideq = 21;

        checku user5 = new checku();
        user5.id = 111;
        user5.sname = "";
        user5.name = "";
        user5.otechestvo = "";
        user5.born = new DateTime(1212, 12, 12);
        user5.numpass = 1234123456;
        user5.status = "";
        user5.pay = 2;
        user5.ideq = 22;
        List<checku> listuser = new List<checku>();
        listuser.Add(user1);
        listuser.Add(user2);
        listuser.Add(user3);
        listuser.Add(user4);
        listuser.Add(user5);
        return listuser;
    }
    public static List<prod> startnameq()
    {
        prod user1 = new prod();
        user1.id = 121;
        user1.name = "sd";
        user1.cost = 2;
        user1.count = 1;
        prod user2 = new prod();
        user2.id = 12;
        user2.name = "sud";
        user2.cost = 4;
        user2.count = 6;
        List<prod> listuser = new List<prod>();
        listuser.Add(user1);
        listuser.Add(user2);
        return listuser;
    }
}