using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shop_10;

internal class prod
{
    public uint id { get; set; }
    public string name { get; set; }
    public uint cost { get; set; }
    public uint count { get; set; }
}
internal class skladp
{
    public uint id { get; set; }
    public string name { get; set; }
    public DateTime data { get; set; }
    public uint cost { get; set; }
    public bool plus { get; set; }
}
internal class Buyprod
{
    public uint id { get; set; }
    public List<prod> check { get; set; }
}
internal class ForAdm
{
    public uint id { get; set; }
    public string login { get; set; }
    public string password { get; set; }
    public uint role { get; set; }
}
internal class checku
{
    public uint id { get; set; }
    public string sname { get; set; }
    public string name { get; set; }
    public string otechestvo { get; set; }
    public DateTime born { get; set; }
    public int numpass { get; set; }
    public string status { get; set; }
    public uint pay { get; set; }
    public uint ideq { get; set; }
}
internal static class Serialize
{
    public static void steruser<T>(T listdata, string paff)
    {
        string paf = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string json = JsonSerializer.Serialize(listdata);
        File.WriteAllText(paf + paff, json);
    }
    public static T desteruser<T>(string paff)
    {
        string paf = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string jsontext = File.ReadAllText(paf + paff);
        T list = JsonSerializer.Deserialize<T>(jsontext);
        return list;
    }
}
