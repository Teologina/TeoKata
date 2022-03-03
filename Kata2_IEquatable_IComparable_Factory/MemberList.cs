using System;
using System.Collections.Generic;

namespace Kata2_Inheritance
{
    class MemberList : IMemberList
    {
        List<IMember> _members = new List<IMember>();

        public IMember this[int idx]
        {
            get { return _members[idx]; }
        }
        public int Count() => _members.Count;
        public int Count(int year)
        {
            int c = 0;
            foreach (var item in _members)
            {
                if (item.Since.Year == year)
                    c++;
            }
            return c;
        }

        public void Sort() => _members.Sort();

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _members.Count; i++)
            {
                sRet += $"{_members[i]}\n";
                if ((i + 1) % 10 == 0)
                {
                    sRet += "\n";
                }
            }
            return sRet;
        }

        #region Class Factory for creating an instance filled with Random data
        internal static class Factory
        {
            internal static IMemberList CreateWithRandomData(int NrOfItems, string KindOfMember)
            {
                var rnd = new Random();
                string s = KindOfMember.ToLower();
                var memberlist = new MemberList();
                for (int i = 0; i < NrOfItems; i++)
                {
                    if (s == "hilton")
                    {
                        memberlist._members.Add(HiltonMember.Factory.CreateWithRandomData());
                    }
                    if (s == "scandic")
                    {
                        memberlist._members.Add(ScandicMember.Factory.CreateWithRandomData());
                    }
                    if (s == "radisson")
                    {
                        memberlist._members.Add(RadissonMember.Factory.CreateWithRandomData());
                    }
                    else if (s != "hilton" && s!= "scandic" && s!= "radisson")
                    {

                         int rndNumber =  rnd.Next(1, 4);
                            if (rndNumber == 1)
                            {
                                memberlist._members.Add(HiltonMember.Factory.CreateWithRandomData());
                            }

                            if (rndNumber == 2)
                            {
                                memberlist._members.Add(ScandicMember.Factory.CreateWithRandomData());
                            }

                            if (rndNumber == 3)
                            {
                                memberlist._members.Add(RadissonMember.Factory.CreateWithRandomData());
                            }
                    }

                }
                return memberlist;
            }

        }
            #endregion

        public string Write(string filename)
        {
            string fn = fname(filename);

            using (FileStream fs = File.Create(fname(fn)))
            using (TextWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(this);
            }
            return fn;
        }
        static string fname(string name)
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            documentPath = Path.Combine(documentPath, "AOOP2", "Examples");
            if (!Directory.Exists(documentPath)) Directory.CreateDirectory(documentPath);
            return Path.Combine(documentPath, name);
        }
        public MemberList() { }
    }
}
