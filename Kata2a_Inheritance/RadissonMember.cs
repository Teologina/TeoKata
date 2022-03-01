using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2a_Inheritance
{
    internal class RadissonMember :Member, IRadissonMember
    {
        public override string[] Benefits { get; set; }
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

        #region Class Factory for creating an instance filled with Random data
        internal new static class Factory
        {
            internal static IMember CreateWithRandomData()
            {
                var member = new RadissonMember();
                member.RandomInit();
                return member;
            }
        }
        #endregion

    }
}
