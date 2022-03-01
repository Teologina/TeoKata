using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2a_Inheritance
{
    internal class RadissonMember :Member, IRadissonMember
    {
        public new void RandomInit()
        {
            base.RandomInit();

            var rnd = new Random();
            Benefits = "R:Free breakfast, R:Late checkin, R:One free drink in the bar".Split(',');
        }

        public RadissonMember()
        {
            RandomInit();
        }
    }
}
