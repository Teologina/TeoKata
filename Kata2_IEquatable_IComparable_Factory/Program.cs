using Kata2_Inheritance;

#region Kata test of Member and MemberList
Console.WriteLine("Create a couple of members");
var member1 = RadissonMember.Factory.CreateWithRandomData();
Console.WriteLine($"member1: {member1}");
var member2 = RadissonMember.Factory.CreateWithRandomData();
Console.WriteLine($"member2: {member2}");

var member3 = HiltonMember.Factory.CreateWithRandomData();
Console.WriteLine($"member 3: {member3}");

var member4 = ScandicMember.Factory.CreateWithRandomData();
Console.WriteLine($"member 4: {member4}");

Console.WriteLine("\nCreate a 20 Hilton members");
var HiltonMembers = MemberList.Factory.CreateWithRandomData(20, "hilton"); 
HiltonMembers.Sort();
Console.WriteLine(HiltonMembers);

Console.WriteLine("\nCreate a 20 Radisson members");
var RadissonMembers = MemberList.Factory.CreateWithRandomData(20, "radisson");
RadissonMembers.Sort();
Console.WriteLine(RadissonMembers);

Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
Console.WriteLine($"Radisson member[0]: {RadissonMembers[0]}");
Console.WriteLine();

Console.WriteLine("\nCreate 20 random members by entering a non valid hotel name");
var members = MemberList.Factory.CreateWithRandomData(20,"ranasgsdg");
Console.WriteLine(members);


Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Add a list of members to a textfile");
var filename = members.Write("hotelguests.txt");
Console.WriteLine($"20 members has been added to this path: {filename}");

#endregion

#region For Exercise: Refresh how to generate random initialization data
Console.WriteLine(RandomDate());
Console.WriteLine(RandomCity());

static DateTime RandomDate()
{
    var rnd = new Random();
    while (true)
    {
        try
        {
            int year = rnd.Next(1980, DateTime.Today.Year);
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, 32);

            return new DateTime(year, month, day);
        }
        catch { }
    }
}
static string RandomCity()
{
    var rnd = new Random();
    string[] _cities = "Stockholm Göteborg Malmö".Split(' ');
    return _cities[rnd.Next(0, _cities.Length)];
}
#endregion